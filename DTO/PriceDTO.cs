using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PriceDTO
    {
        public int PriceID { get; set; }
        public ProductDTO ProductDTO { get; set; }
        public UnitDTO UnitDTO { get; set; }
        public int Price {  get; set; }
        public PriceDTO(int priceID, int price, ProductDTO productDTO, UnitDTO unitDTO) 
        {
            PriceID = priceID;
            Price = price;
            ProductDTO = productDTO;
            UnitDTO = unitDTO;
        }
    }
}
