using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InventoryDAL: DBConnection
    {
        public int FindTotalQuantity()
        {
            try
            {
                OpenConnection();
                string query = $"select sum(quantity) from INVENTORY";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                if (result != null) return (int)result;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return 0;
        }
        public List<InventoryDTO> FindAllInventoriesWithPaging(int pageNumber, int limit)
        {
            List<InventoryDTO> inventories = new List<InventoryDTO>();
            try
            {
                OpenConnection();
                string query = "select inventory_id, product_name, quantity from INVENTORY " +
                    "inner join PRODUCT on INVENTORY.product_id = PRODUCT.product_id " +
                    $"order by inventory_id offset {pageNumber * limit} rows fetch next {limit} rows only";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int inventoryID, quantity;
                string productName;
                while (reader.Read())
                {
                    inventoryID = reader.GetInt32(0);
                    productName = reader.GetString(1);
                    quantity = reader.GetInt32(2);
                    inventories.Add(new InventoryDTO(inventoryID, new ProductDTO("", productName, null, null), quantity));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return inventories;
        }
        public List<InventoryDTO> FindAllInventoriesByProductName(int pageNumber, int limit, string txtSearch)
        {
            List<InventoryDTO> inventories = new List<InventoryDTO>();
            try
            {
                OpenConnection();
                string query = "select inventory_id, product_name, quantity from INVENTORY " +
                    "inner join PRODUCT on INVENTORY.product_id = PRODUCT.product_id " +
                    $"where product_name like '%{txtSearch}%'" +
                    $"order by inventory_id offset {pageNumber * limit} rows fetch next {limit} rows only";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int inventoryID, quantity;
                string productName;
                while (reader.Read())
                {
                    inventoryID = reader.GetInt32(0);
                    productName = reader.GetString(1);
                    quantity = reader.GetInt32(2);
                    inventories.Add(new InventoryDTO(inventoryID, new ProductDTO("", productName, null, null), quantity));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return inventories;
        }
    }
}
