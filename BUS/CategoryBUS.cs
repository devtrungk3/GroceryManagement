using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CategoryBUS
    {
        private CategoryDAL categoryDAL = new CategoryDAL();
        public List<CategoryDTO> GetCategories(int pageNumber, int limit)
        {
            return categoryDAL.FindAllCategoriesWithPaging(pageNumber, limit);
        }
        public string InsertCategory(CategoryDTO category)
        {
            if (categoryDAL.InsertCategory(category)) return "";
            else return "Thêm danh mục thất bại";
        }
        public string UpdateCategory(CategoryDTO category)
        {
            if (categoryDAL.UpdateCategory(category)) return "";
            else return "Cập nhật danh mục thất bại";
        }
        public string DeleteCategory(string categoryID)
        {
            if (categoryDAL.DeleteCategory(categoryID)) return "";
            else return "Xóa danh mục thất bại";
        }
        public List<CategoryDTO> GetCategoriesByCategoryName(int pageNumber, int limit, string txtSearch)
        {
            return categoryDAL.FindAllCategoriesByCategoryNameWithPaging(pageNumber, limit, txtSearch);
        }
    }
}
