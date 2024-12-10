using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PurchaseDetailDTO
    {
        public int PurchaseDetailID { get; set; }
        public PurchaseDTO PurchaseDTO { get; set; }
        public ProductDTO ProductDTO { get; set; }
        public int Quantity { get; set; }
        public UnitDTO UnitDTO { get; set; }
        public int UnitPrice { get; set; }
        public PurchaseDetailDTO(int purchaseDetailID, PurchaseDTO purchaseDTO, ProductDTO productDTO, int quantity, UnitDTO unitDTO, int unitPrice)
        {
            PurchaseDetailID = purchaseDetailID;
            PurchaseDTO = purchaseDTO;
            ProductDTO = productDTO;
            Quantity = quantity;
            UnitDTO = unitDTO;
            UnitPrice = unitPrice;
        }
    }
}
