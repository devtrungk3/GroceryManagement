using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UnitDTO
    {
        public int UnitID { get; set; }
        public string UnitName { get; set; }

        public UnitDTO(int unitID, string unitName)
        {
            UnitID = unitID;
            UnitName = unitName;
        }
    }
}
