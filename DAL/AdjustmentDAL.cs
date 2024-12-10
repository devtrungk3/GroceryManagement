using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdjustmentDAL: DBConnection
    {
        public List<AdjustmentDTO> FindAllAdjustmentsByAdjustmentDate(string date)
        {
            List<AdjustmentDTO> adjustments = new List<AdjustmentDTO>();
            try
            {
                OpenConnection();
                string query = "select adjustment_id, ADJUSTMENT.product_id, product_name, quantity, reason, adjustment_date from ADJUSTMENT " +
                    "inner join PRODUCT on PRODUCT.product_id = ADJUSTMENT.product_id " +
                    $"where format(adjustment_date, 'yyyy-MM-dd') = '{date}';";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int adjustmentID, quantity;
                string productID, productName, reason;
                DateTime adjustmentDate;
                while (reader.Read())
                {
                    adjustmentID = reader.GetInt32(0);
                    productID = reader.GetString(1);
                    productName = reader.GetString(2);
                    quantity = reader.GetInt32(3);
                    reason = reader.GetString(4);
                    adjustmentDate = reader.GetDateTime(5);
                    adjustments.Add(new AdjustmentDTO(adjustmentID, new ProductDTO(productID, productName, null, null), quantity, reason, adjustmentDate));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return adjustments;
        }
        public bool InsertAdjustment(AdjustmentDTO adjustment)
        {
            try
            {
                OpenConnection();
                string query = $"insert into ADJUSTMENT (product_id, quantity, reason) values ('{adjustment.ProductDTO.ProductID}', {adjustment.Quantity}, N'{adjustment.Reason}')";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
        public bool UpdateAdjustment(AdjustmentDTO adjustment)
        {
            try
            {
                OpenConnection();
                string query = $"update ADJUSTMENT set product_id = '{adjustment.ProductDTO.ProductID}', quantity = {adjustment.Quantity}, reason=N'{adjustment.Reason}' where adjustment_id = {adjustment.AdjustmentID}";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
        public bool DeleteAdjustment(string adjustmentID)
        {
            try
            {
                OpenConnection();
                string query = $"delete from ADJUSTMENT where adjustment_id = {adjustmentID}";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
    }
}
