using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ProductBUS
    {
        private ProductDAL productDAL = new ProductDAL();
        public List<ProductDTO> GetProductsWithPaging(int pageNumber, int limit)
        {
            return productDAL.FindAllProductsWithPaging(pageNumber, limit);
        } 
        public List<ProductDTO> GetProducts()
        {
            return productDAL.FindAllProducts();
        }
        public string InsertProduct(ProductDTO product)
        {
            if (productDAL.IsProductIDExist(product.ProductID)) return "Mã sản phẩm đã tồn tại";
            if (productDAL.InsertProduct(product)) return "";
            else return "Thêm sản phẩm thất bại";
        }
        public string UpdateProduct(ProductDTO product) 
        {
            if (!productDAL.IsProductIDExist(product.ProductID)) return "Mã sản phẩm không tồn tại";
            if (productDAL.UpdateProduct(product)) return "";
            else return "Cập nhật sản phẩm thất bại";
        }
        public string DeleteProduct(string productID) 
        {
            if (!productDAL.IsProductIDExist(productID)) return "Mã sản phẩm không tồn tại";
            if (productDAL.DeleteProduct(productID)) return "";
            else return "Xóa sản phẩm thất bại";
        }
        public List<ProductDTO> GetProductsByProductName(int pageNumber, int limit, string txtSearch)
        {
            return productDAL.FindAllProductsByProductNameWithPaging(pageNumber, limit, txtSearch);
        }
        public ProductDTO? GetProductByProductID(string productID)
        {
            return productDAL.FindProductByProductID(productID);
        }
    }
}
