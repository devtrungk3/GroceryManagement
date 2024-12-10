using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class UnitConversionBUS
    {
        private ProductDAL productDAL = new ProductDAL();
        private UnitConversionDAL unitConversionDAL = new UnitConversionDAL();
        public List<UnitConversionDTO> GetUnitConversionWithPaging(int pageNumber, int limit)
        {
            return unitConversionDAL.FindAllUnitConversionWithPaging(pageNumber, limit);
        }
        public List<UnitConversionDTO> GetUnitConversionByProductNameWithPaging(int pageNumber, int limit, string txtSearch)
        {
            return unitConversionDAL.FindAllUnitConversionByProductNameWithPaging(pageNumber, limit, txtSearch);
        }
        public string InsertUnitConversion(UnitConversionDTO uc)
        {
            if (!productDAL.IsProductIDExist(uc.ProductDTO.ProductID)) return "Mã sản phẩm không tồn tại";
            if (unitConversionDAL.InsertUnitConversion(uc)) return "";
            return "Thêm quy đổi thất bại";
        }
        public string UpdateUnitConversion(UnitConversionDTO uc)
        {
            if (!productDAL.IsProductIDExist(uc.ProductDTO.ProductID)) return "Mã sản phẩm không tồn tại";
            if (unitConversionDAL.UpdateUnitConversion(uc)) return "";
            return "Cập nhật quy đổi thất bại";
        }
        public string DeleteUnitConversion(string conversionID)
        {
            if (unitConversionDAL.DeleteUnitConversion(conversionID)) return "";
            return "Xóa quy đổi thất bại";
        }
    }
}
