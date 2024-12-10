using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UnitConversionDTO
    {
        public int ConversionID { get; set; }
        public ProductDTO ProductDTO { get; set; }
        public UnitDTO FromUnit { get; set; }
        public UnitDTO ToUnit { get; set; }
        public int Factor { get; set; }
        public UnitConversionDTO(int conversionID, ProductDTO productDTO, UnitDTO fromUnit, UnitDTO toUnit, int factor)
        {
            ConversionID = conversionID;
            ProductDTO = productDTO;
            FromUnit = fromUnit;
            ToUnit = toUnit;
            Factor = factor;
        }
    }
}
