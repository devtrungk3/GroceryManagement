using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InventoryDTO
    {
        public int InventoryID {  get; set; }
        public ProductDTO ProductDTO { get; set; }
        public int Quantity { get; set; }
        public InventoryDTO(int inventoryID, ProductDTO productDTO, int quantity) 
        {
            InventoryID = inventoryID;
            ProductDTO = productDTO;
            Quantity = quantity;
        }
    }
}
