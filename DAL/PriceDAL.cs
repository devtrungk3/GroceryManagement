using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PriceDAL: DBConnection
    {
        public int FindPriceByProductIDAndUnitID(string productID, string unitID)
        {
            try
            {
                OpenConnection();
                string query = $"select top 1 price from PRICE where product_id = '{productID}' and unit_id = {unitID}";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                if (result != null) return (int)result;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return 0;
        }
        public List<PriceDTO> FindAllPrices()
        {
            List<PriceDTO> prices = new List<PriceDTO>();
            try
            {
                OpenConnection();
                string query = "select price_id, price, pr.product_id, product_name, pr.unit_id, unit_name from PRICE as pr " +
                    "inner join PRODUCT as p on pr.product_id = p.product_id " +
                    "inner join UNIT as u on pr.unit_id = u.unit_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int priceID, price, unitID;
                string productID, productName, unitName;
                while (reader.Read())
                {
                    priceID = reader.GetInt32(0);
                    price = reader.GetInt32(1);
                    productID = reader.GetString(2);
                    productName = reader.GetString(3);
                    unitID = reader.GetInt32(4);
                    unitName = reader.GetString(5);
                    prices.Add(new PriceDTO(priceID, price, new ProductDTO(productID, productName, null, null), new UnitDTO(unitID, unitName)));
                }
            } catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return prices;
        }
        public List<PriceDTO> FindAllPricesWithPaging(int pageNumber, int limit)
        {
            List<PriceDTO> prices = new List<PriceDTO>();
            try
            {
                OpenConnection();
                string query = "select price_id, price, pr.product_id, product_name, pr.unit_id, unit_name from PRICE as pr " +
                    "inner join PRODUCT as p on pr.product_id = p.product_id " +
                    "inner join UNIT as u on pr.unit_id = u.unit_id " +
                    $"order by price_id offset {pageNumber * limit} rows fetch next {limit} rows only";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int priceID, price, unitID;
                string productID, productName, unitName;
                while (reader.Read())
                {
                    priceID = reader.GetInt32(0);
                    price = reader.GetInt32(1);
                    productID = reader.GetString(2);
                    productName = reader.GetString(3);
                    unitID = reader.GetInt32(4);
                    unitName = reader.GetString(5);
                    prices.Add(new PriceDTO(priceID, price, new ProductDTO(productID, productName, null, null), new UnitDTO(unitID, unitName)));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return prices;
        }
        public List<PriceDTO> FindAllPricesByProductNameWithPaging(int pageNumber, int limit, string txtSearch)
        {
            List<PriceDTO> prices = new List<PriceDTO>();
            try
            {
                OpenConnection();
                string query = "select price_id, price, pr.product_id, product_name, pr.unit_id, unit_name from PRICE as pr " +
                    "inner join PRODUCT as p on pr.product_id = p.product_id " +
                    "inner join UNIT as u on pr.unit_id = u.unit_id " +
                    $"where product_name like N'%{txtSearch}%' " +
                    $"order by product_id offset {pageNumber * limit} rows fetch next {limit} rows only";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int priceID, price, unitID;
                string productID, productName, unitName;
                while (reader.Read())
                {
                    priceID = reader.GetInt32(0);
                    price = reader.GetInt32(1);
                    productID = reader.GetString(2);
                    productName = reader.GetString(3);
                    unitID = reader.GetInt32(4);
                    unitName = reader.GetString(5);
                    prices.Add(new PriceDTO(priceID, price, new ProductDTO(productID, productName, null, null), new UnitDTO(unitID, unitName)));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return prices;
        }
        public bool InsertPrice(PriceDTO price)
        {
            try
            {
                OpenConnection();
                string query = $"insert into PRICE(product_id, unit_id, price) values ('{price.ProductDTO.ProductID}', {price.UnitDTO.UnitID}, {price.Price})";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
        public bool UpdatePrice(PriceDTO price)
        {
            try
            {
                OpenConnection();
                string query = $"update PRICE set price={price.Price}, product_id='{price.ProductDTO.ProductID}', unit_id={price.UnitDTO.UnitID} where price_id={price.PriceID}";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
        public bool DeletePrice(string priceID)
        {
            try
            {
                OpenConnection();
                string query = $"delete from PRICE where price_id={priceID}";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
    }
}
