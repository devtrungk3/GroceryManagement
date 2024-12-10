using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PurchaseDTO
    {
        public int PurchaseID { get; set; }
        public SupplierDTO SupplierDTO { get; set; }
        public int TotalAmount { get; set; }
        public DateTime PurchaseDate { get; set; }
        public PurchaseDTO(int purchaseID, SupplierDTO supplierDTO, int totalAmount, DateTime purchaseDate)
        {
            PurchaseID = purchaseID;
            SupplierDTO = supplierDTO;
            TotalAmount = totalAmount;
            PurchaseDate = purchaseDate;
        }
    }
}
