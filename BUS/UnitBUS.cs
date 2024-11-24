using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class UnitBUS
    {
        private UnitDAL unitDAL = new UnitDAL();
        public List<UnitDTO> GetUnits(int pageNumber, int limit)
        {
            return unitDAL.FindAllUnits();
        }

        public List<UnitDTO> GetUnitsWithPaging(int pageNumber, int limit)
        {
            return unitDAL.FindAllUnitsWithPaging(pageNumber, limit);
        }

        public List<UnitDTO> GetUnitsByUnitName(int pageNumber, int limit, string txtSearch)
        {
            return unitDAL.FindAllUnitsByUnitNameWithPaging(pageNumber, limit, txtSearch);
        }

        public string InsertUnit(UnitDTO unit)
        {
            if (unitDAL.InsertUnit(unit)) return "";
            else return "Thêm đơn vị thất bại";
        }

        public string UpdateUnit(UnitDTO unit)
        {
            if (unitDAL.UpdateUnit(unit)) return "";
            else return "Cập nhật đơn vị thất bại";
        }

        public string DeleteUnit(string unitID)
        {
            if (unitDAL.DeleteUnit(unitID)) return "";
            else return "Xóa đơn vị thất bại";
        }
    }
}
