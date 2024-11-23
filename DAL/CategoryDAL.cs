using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryDAL: DBConnection
    {
        public List<CategoryDTO> FindAllCategoriesWithPaging(int pageNumber, int limit)
        {
            List<CategoryDTO> categories = new List<CategoryDTO>();
            try
            {
                OpenConnection();
                string query = $"select category_id, category_name from CATEGORY order by category_id offset {pageNumber * limit} rows fetch next {limit} rows only";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int categoryID;
                string categoryName;
                while (reader.Read())
                {
                    categoryID = reader.GetInt32(0);
                    categoryName = reader.GetString(1);
                    categories.Add(new CategoryDTO(categoryID, categoryName));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return categories;
        }
        public bool InsertCategory(CategoryDTO category)
        {
            try
            {
                OpenConnection();
                string query = $"insert into CATEGORY(category_name) values (N'{category.CategoryName}')";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
        public bool UpdateCategory(CategoryDTO category)
        {
            try
            {
                OpenConnection();
                string query = $"update CATEGORY set category_name=N'{category.CategoryName}' where category_id={category.CategoryID}";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
        public bool DeleteCategory(string categoryID)
        {
            try
            {
                OpenConnection();
                string query = $"delete from CATEGORY where category_id={categoryID}";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
        public List<CategoryDTO> FindAllCategoriesByCategoryNameWithPaging(int pageNumber, int limit, string txtSearch)
        {
            List<CategoryDTO> categories = new List<CategoryDTO>();
            try
            {
                OpenConnection();
                string query = $"select category_id, category_name from CATEGORY where category_name like N'%{txtSearch}%' order by category_id offset {pageNumber * limit} rows fetch next {limit} rows only";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int categoryID;
                string categoryName;
                while (reader.Read())
                {
                    categoryID = reader.GetInt32(0);
                    categoryName = reader.GetString(1);
                    categories.Add(new CategoryDTO(categoryID, categoryName));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return categories;
        }
    }
}
