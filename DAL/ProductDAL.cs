using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDAL: DBConnection
    {
        public List<ProductDTO> FindAllProductsWithPaging(int pageNumber, int limit)
        {
            List<ProductDTO> products = new List<ProductDTO>();
            try
            {
                OpenConnection();
                string query = "select product_id, product_name, p.category_id, category_name, default_unit_id, unit_name from PRODUCT as p " + 
                    "inner join CATEGORY as c on p.category_id = c.category_id " +
                    "inner join UNIT as u on p.default_unit_id = u.unit_id " + 
                    $"order by product_id offset {pageNumber * limit} rows fetch next {limit} rows only";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                string productID, productName, categoryName, unitName;
                int categoryID, unitID;
                while (reader.Read())
                {
                    productID = reader.GetString(0);
                    productName = reader.GetString(1);
                    categoryID = reader.GetInt32(2);
                    categoryName = reader.GetString(3);
                    unitID = reader.GetInt32(4);
                    unitName = reader.GetString(5);
                    products.Add(new ProductDTO(productID, productName, new CategoryDTO(categoryID, categoryName), new UnitDTO(unitID, unitName)));
                }
            } catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return products;
        }
        public List<ProductDTO> FindAllProducts()
        {
            List<ProductDTO> products = new List<ProductDTO>();
            try
            {
                OpenConnection();
                string query = "select product_id, product_name, p.category_id, category_name, default_unit_id, unit_name from PRODUCT as p " +
                    "inner join CATEGORY as c on p.category_id = c.category_id " +
                    "inner join UNIT as u on p.default_unit_id = u.unit_id ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                string productID, productName, categoryName, unitName;
                int categoryID, unitID;
                while (reader.Read())
                {
                    productID = reader.GetString(0);
                    productName = reader.GetString(1);
                    categoryID = reader.GetInt32(2);
                    categoryName = reader.GetString(3);
                    unitID = reader.GetInt32(4);
                    unitName = reader.GetString(5);
                    products.Add(new ProductDTO(productID, productName, new CategoryDTO(categoryID, categoryName), new UnitDTO(unitID, unitName)));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return products;
        }
        public bool IsProductIDExist(string productID)
        {
            try
            {
                OpenConnection();
                string query = $"select count(product_id) from PRODUCT where product_id='{productID}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                return (int)cmd.ExecuteScalar() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return true;
        }
        public bool InsertProduct(ProductDTO product) 
        {
            try
            {
                OpenConnection();
                string query = $"insert into PRODUCT(product_id, product_name, category_id, default_unit_id) values ('{product.ProductID}', N'{product.ProductName}', {product.CategoryDTO.CategoryID}, {product.UnitDTO.UnitID})";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
        public bool UpdateProduct(ProductDTO product) 
        {
            try
            {
                OpenConnection();
                string query = $"update PRODUCT set product_name=N'{product.ProductName}', category_id={product.CategoryDTO.CategoryID}, default_unit_id={product.UnitDTO.UnitID} where product_id='{product.ProductID}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
        public bool DeleteProduct(string productID)
        {
            try
            {
                OpenConnection();
                string query = $"delete from PRODUCT where product_id='{productID}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
        public List<ProductDTO> FindAllProductsByProductNameWithPaging(int pageNumber, int limit, string txtSearch)
        {
            List<ProductDTO> products = new List<ProductDTO>();
            try
            {
                OpenConnection();
                string query = "select product_id, product_name, p.category_id, category_name, default_unit_id, unit_name from PRODUCT as p " +
                    "inner join CATEGORY as c on p.category_id = c.category_id " +
                    "inner join UNIT as u on p.default_unit_id = u.unit_id " +
                    $"where product_name like '%{txtSearch}%' " +
                    $"order by product_id offset {pageNumber * limit} rows fetch next {limit} rows only";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                string productID, productName, categoryName, unitName;
                int categoryID, unitID;
                while (reader.Read())
                {
                    productID = reader.GetString(0);
                    productName = reader.GetString(1);
                    categoryID = reader.GetInt32(2);
                    categoryName = reader.GetString(3);
                    unitID = reader.GetInt32(4);
                    unitName = reader.GetString(5);
                    products.Add(new ProductDTO(productID, productName, new CategoryDTO(categoryID, categoryName), new UnitDTO(unitID, unitName)));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return products;
        }
        public ProductDTO? FindProductByProductID(string productID)
        {
            try
            {
                OpenConnection();
                string query = "select product_id, product_name, p.category_id, category_name, default_unit_id, unit_name from PRODUCT as p " +
                    "inner join CATEGORY as c on p.category_id = c.category_id " +
                    "inner join UNIT as u on p.default_unit_id = u.unit_id " +
                    $"where product_id = '{productID}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    return new ProductDTO(reader.GetString(0), reader.GetString(1), new CategoryDTO(reader.GetInt32(2), reader.GetString(3)), new UnitDTO(reader.GetInt32(4), reader.GetString(5)));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return null;
        }
    }
}
