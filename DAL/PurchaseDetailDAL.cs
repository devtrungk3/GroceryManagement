using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PurchaseDetailDAL: DBConnection
    {
        public bool InsertPurchaseDetail(int purchaseID, List<PurchaseDetailDTO> pd)
        {
            try
            {
                OpenConnection();
                string query = "insert into PURCHASE_DETAIL(purchase_id, product_id, quantity, unit_id, unit_price) values ";
                foreach (PurchaseDetailDTO p in pd)
                {
                    query += $"({purchaseID}, '{p.ProductDTO.ProductID}', {p.Quantity}, {p.UnitDTO.UnitID}, {p.UnitPrice}),";
                }
                query = query.Substring(0, query.Length - 1);
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { CloseConnection(); }
            return false;
        }
        public List<PurchaseDetailDTO> FindAllPurchaseDetailsByPurchaseID(string searchPurchaseID)
        {
            List < PurchaseDetailDTO> purchaseDetails = new List < PurchaseDetailDTO>();
            try
            {
                OpenConnection();
                string query = "select PURCHASE_DETAIL.purchase_id, product_name, quantity, unit_name, unit_price from PURCHASE_DETAIL " +
                    "inner join PURCHASE on PURCHASE_DETAIL.purchase_id = PURCHASE.purchase_id " +
                    "inner join PRODUCT on PURCHASE_DETAIL.product_id = PRODUCT.product_id " +
                    "inner join UNIT on PURCHASE_DETAIL.unit_id = UNIT.unit_id " +
                    $"where PURCHASE_DETAIL.purchase_id = {searchPurchaseID}";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int purchaseID, quantity, unitPrice;
                string productName, unitName;
                while (reader.Read())
                {
                    purchaseID = reader.GetInt32(0);
                    productName = reader.GetString(1);
                    quantity = reader.GetInt32(2);
                    unitName = reader.GetString(3);
                    unitPrice = reader.GetInt32(4);
                    purchaseDetails.Add(new PurchaseDetailDTO(0, new PurchaseDTO(purchaseID, null, 0, DateTime.Now), new ProductDTO("", productName, null, null), quantity, new UnitDTO(0, unitName), unitPrice));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection() ; }
            return purchaseDetails;
        }
    }
}
