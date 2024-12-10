using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PriceBUS
    {
        private PriceDAL priceDAL = new PriceDAL();
        private ProductDAL productDAL = new ProductDAL();
        public List<PriceDTO> GetPricesWithPaging(int pageNumber, int limit)
        {
            return priceDAL.FindAllPricesWithPaging(pageNumber, limit);
        } 
        public List<PriceDTO> GetPricesByProductNameWithPaging(int pageNumber, int limit, string txtSearch)
        {
            return priceDAL.FindAllPricesByProductNameWithPaging(pageNumber, limit, txtSearch);
        }
        public string InsertPrice(PriceDTO price)
        {
            if (!productDAL.IsProductIDExist(price.ProductDTO.ProductID)) return "Mã sản phẩm không tồn tại";
            if (priceDAL.InsertPrice(price)) return "";
            else return "Thêm giá bán thất bại";
        }
        public string UpdatePrice(PriceDTO price)
        {
            if (!productDAL.IsProductIDExist(price.ProductDTO.ProductID)) return "Mã sản phẩm không tồn tại";
            if (priceDAL.UpdatePrice(price)) return "";
            else return "Cập nhật giá bán thất bại";
        }
        public string DeletePrice(string priceID)
        {
            if (priceDAL.DeletePrice(priceID)) return "";
            else return "Xóa giá bán thất bại";
        }
        public int GetPriceByProductIDAndUnitID(string productID, string unitID)
        {
            return priceDAL.FindPriceByProductIDAndUnitID(productID, unitID);
        }
    }
}
