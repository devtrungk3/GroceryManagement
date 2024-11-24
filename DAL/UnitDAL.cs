using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UnitDAL : DBConnection
    {
        public List<UnitDTO> FindAllUnitsWithPaging(int pageNumber, int limit)
        {
            List<UnitDTO> units = new List<UnitDTO>();
            try
            {
                OpenConnection();
                string query = $"select unit_id, unit_name from UNIT order by unit_id offset {pageNumber * limit} rows fetch next {limit} rows only";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int unitID;
                string unitName;
                while (reader.Read())
                {
                    unitID = reader.GetInt32(0);
                    unitName = reader.GetString(1);
                    units.Add(new UnitDTO(unitID, unitName));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return units;
        }

        public List<UnitDTO> FindAllUnitsByUnitNameWithPaging(int pageNumber, int limit, string txtSearch)
        {
            List<UnitDTO> units = new List<UnitDTO>();
            try
            {
                OpenConnection();
                string query = $"select unit_id, unit_name from UNIT where unit_name like N'%{txtSearch}%' order by unit_id offset {pageNumber * limit} rows fetch next {limit} rows only";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int unitID;
                string unitName;
                while (reader.Read())
                {
                    unitID = reader.GetInt32(0);
                    unitName = reader.GetString(1);
                    units.Add(new UnitDTO(unitID, unitName));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return units;
        }

        public bool InsertUnit(UnitDTO unit)
        {
            try
            {
                OpenConnection();
                string query = $"insert into UNIT(unit_name) values (N'{unit.UnitName}')";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }

        public bool UpdateUnit(UnitDTO unit)
        {
            try
            {
                OpenConnection();
                string query = $"update UNIT set unit_name=N'{unit.UnitName}' where unit_id={unit.UnitID}";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }

        public bool DeleteUnit(string unitID)
        {
            try
            {
                OpenConnection();
                string query = $"delete from UNIT where unit_id={unitID}";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
    }
}
