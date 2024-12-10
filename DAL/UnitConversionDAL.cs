using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UnitConversionDAL: DBConnection
    {
        public List<UnitConversionDTO> FindAllUnitConversionWithPaging(int pageNumber, int limit)
        {
            List<UnitConversionDTO> conversions = new List<UnitConversionDTO>();
            try
            {
                OpenConnection();
                string query = "select conversion_id, uc.product_id, product_name, u1.unit_id, u1.unit_name, u2.unit_id, u2.unit_name, factor from UNIT_CONVERSION as uc " +
                    "inner join PRODUCT as p on uc.product_id = p.product_id " +
                    "inner join UNIT as u1 on uc.from_unit_id = u1.unit_id " +
                    "inner join UNIT as u2 on uc.to_unit_id = u2.unit_id " +
                    $"order by conversion_id offset {pageNumber * limit} rows fetch next {limit} rows only";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                string productID, productName, fromUnitName, toUnitName;
                int conversionID, fromUnitID, toUnitID, factor;
                while (reader.Read())
                {
                    conversionID = reader.GetInt32(0);
                    productID = reader.GetString(1);
                    productName = reader.GetString(2);
                    fromUnitID = reader.GetInt32(3);
                    fromUnitName = reader.GetString(4);
                    toUnitID = reader.GetInt32(5);
                    toUnitName = reader.GetString(6);
                    factor = reader.GetInt32(7);
                    conversions.Add(new UnitConversionDTO(conversionID, new ProductDTO(productID, productName, null, null), new UnitDTO(fromUnitID, fromUnitName), new UnitDTO(toUnitID, toUnitName), factor));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return conversions;
        }
        public List<UnitConversionDTO> FindAllUnitConversionByProductNameWithPaging(int pageNumber, int limit, string txtSearch)
        {
            List<UnitConversionDTO> conversions = new List<UnitConversionDTO>();
            try
            {
                OpenConnection();
                string query = "select conversion_id, uc.product_id, product_name, u1.unit_id, u1.unit_name, u2.unit_id, u2.unit_name, factor from UNIT_CONVERSION as uc " +
                    "inner join PRODUCT as p on uc.product_id = p.product_id " +
                    "inner join UNIT as u1 on uc.from_unit_id = u1.unit_id " +
                    "inner join UNIT as u2 on uc.to_unit_id = u2.unit_id " +
                    $"where product_name like N'%{txtSearch}%' " +
                    $"order by conversion_id offset {pageNumber * limit} rows fetch next {limit} rows only";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                string productID, productName, fromUnitName, toUnitName;
                int conversionID, fromUnitID, toUnitID, factor;
                while (reader.Read())
                {
                    conversionID = reader.GetInt32(0);
                    productID = reader.GetString(1);
                    productName = reader.GetString(2);
                    fromUnitID = reader.GetInt32(3);
                    fromUnitName = reader.GetString(4);
                    toUnitID = reader.GetInt32(5);
                    toUnitName = reader.GetString(6);
                    factor = reader.GetInt32(7);
                    conversions.Add(new UnitConversionDTO(conversionID, new ProductDTO(productID, productName, null, null), new UnitDTO(fromUnitID, fromUnitName), new UnitDTO(toUnitID, toUnitName), factor));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return conversions;
        }
        public bool InsertUnitConversion(UnitConversionDTO uc)
        {
            try
            {
                OpenConnection();
                string query = "insert into UNIT_CONVERSION (product_id, from_unit_id, to_unit_id, factor) values " +
                    $"('{uc.ProductDTO.ProductID}', {uc.FromUnit.UnitID}, {uc.ToUnit.UnitID}, {uc.Factor})";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection();  }
            return false;
        }
        public bool UpdateUnitConversion(UnitConversionDTO uc)
        {
            try
            {
                OpenConnection();
                string query = "update UNIT_CONVERSION set " +
                    $"product_id = '{uc.ProductDTO.ProductID}', from_unit_id = {uc.FromUnit.UnitID}, to_unit_id = {uc.ToUnit.UnitID}, factor={uc.Factor} " +
                    $"where conversion_id = {uc.ConversionID}";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
        public bool DeleteUnitConversion(string conversionID)
        {
            try
            {
                OpenConnection();
                string query = $"delete from UNIT_CONVERSION where conversion_id = {conversionID}";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
    }
}
