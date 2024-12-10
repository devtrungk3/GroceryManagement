using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AdjustmentDTO
    {
        public int AdjustmentID { get; set; }
        public ProductDTO ProductDTO { get; set; }
        public int Quantity {  get; set; }
        public string Reason { get; set; }
        public DateTime AdjustmentDate { get; set; }
        public AdjustmentDTO(int adjustmentID, ProductDTO productDTO, int quantity, string reason, DateTime adjustmentDate)
        {
            AdjustmentID = adjustmentID;
            ProductDTO = productDTO;
            Quantity = quantity;
            Reason = reason;
            AdjustmentDate = adjustmentDate;
        }
    }
}
