using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PurchaseDAL: DBConnection
    {
        public bool InsertPurchase(PurchaseDTO purchase)
        {
            try
            {
                OpenConnection();
                string query = $"insert into PURCHASE (supplier_id, total_amount) values ({purchase.SupplierDTO.SupplierID}, {purchase.TotalAmount})";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { CloseConnection(); }
            return false;
        }
        public int FindLastPurchaseID()
        {
            try
            {
                OpenConnection();
                string query = "select top 1 purchase_id from PURCHASE order by purchase_id desc";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                if (result != null) return (int)result;
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { CloseConnection(); }
            return -1;
        }
        public List<PurchaseDTO> FindAllPurchasesByPurchaseDate(string date)
        {
            List<PurchaseDTO> purchases = new List<PurchaseDTO>();
            try
            {
                OpenConnection();
                string query = "select purchase_id, p.supplier_id, supplier_name, total_amount, purchase_date from PURCHASE as p " +
                    "inner join SUPPLIER as s on p.supplier_id = s.supplier_id " +
                    $"where format(purchase_date, 'yyyy-MM') = '{date}'";
                SqlCommand cmd = new SqlCommand (query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int purchaseID, supplierID, totalAmount;
                string supplierName;
                DateTime purchaseDate;
                while (reader.Read())
                {
                    purchaseID = reader.GetInt32(0);
                    supplierID = reader.GetInt32(1);
                    supplierName = reader.GetString(2);
                    totalAmount = reader.GetInt32(3);
                    purchaseDate = reader.GetDateTime(4);
                    purchases.Add(new PurchaseDTO(purchaseID, new SupplierDTO(supplierID, supplierName, "", ""), totalAmount, purchaseDate));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return purchases;
        }
    }
}
