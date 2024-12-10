using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductDTO
    {
        public string ProductID {  get; set; }
        public string ProductName { get; set; }
        public CategoryDTO CategoryDTO { get; set; }
        public UnitDTO UnitDTO { get; set; }
        public ProductDTO(string productID, string productName, CategoryDTO categoryDTO, UnitDTO unitDTO)
        {
            ProductID = productID;
            ProductName = productName;
            CategoryDTO = categoryDTO;
            UnitDTO = unitDTO;
        }
    }
}
