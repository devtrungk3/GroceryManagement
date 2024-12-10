using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PurchaseBUS
    {
        private PurchaseDAL purchaseDAL = new PurchaseDAL();
        public string InsertPurchase(PurchaseDTO purchase)
        {
            if (purchaseDAL.InsertPurchase(purchase)) return "";
            return "Thêm hóa đơn nhập kho thất bại";
        }
        public int GetLastPurchaseID()
        {
            return purchaseDAL.FindLastPurchaseID();
        }
        public List<PurchaseDTO> GetPurchasesByPurchaseDate(string date)
        {
            return purchaseDAL.FindAllPurchasesByPurchaseDate(date);
        }
    }
}
