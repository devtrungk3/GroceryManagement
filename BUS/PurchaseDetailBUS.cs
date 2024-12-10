using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PurchaseDetailBUS
    {
        private PurchaseDetailDAL pdDAL = new PurchaseDetailDAL();
        public string InsertPurchaseDetail(int purchaseID, List<PurchaseDetailDTO> pd)
        {
            if (pdDAL.InsertPurchaseDetail(purchaseID, pd)) return "";
            return "Thêm chi tiết hóa đơn nhập kho thất bại";
        }
        public List<PurchaseDetailDTO> GetPurchaseDetailsByPurchaseID(string purchaseID)
        {
            return pdDAL.FindAllPurchaseDetailsByPurchaseID(purchaseID);
        }
    }
}
