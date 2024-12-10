using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAL
{
    public class OrderDetailDAL: DBConnection
    {
        public bool InsertOrderDetail(int orderID, List<OrderDetailDTO> orderDetails)
        {
            try
            {
                OpenConnection();
                string query = "insert into ORDER_DETAIL(order_id, product_id, quantity, unit_id, unit_price) values ";
                foreach (OrderDetailDTO od in orderDetails)
                {
                    query += $"({orderID}, '{od.ProductDTO.ProductID}', {od.Quantity}, {od.UnitDTO.UnitID}, {od.UnitPrice}),";
                }
                query = query.Substring(0, query.Length - 1);
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
        public List<OrderDetailDTO> FindAllOrderDetailsByOrderID(string orderID)
        {
            List<OrderDetailDTO> orderDetails = new List<OrderDetailDTO>();
            try
            {
                OpenConnection();
                string query = "select product_name, unit_name, unit_price, quantity from ORDER_DETAIL as od " +
                    "inner join PRODUCT as p on p.product_id = od.product_id " +
                    "inner join UNIT as u on u.unit_id = od.unit_id " +
                    $"where order_id = {orderID}";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int unitPrice, quantity;
                string productName, unitName;
                while (reader.Read())
                {
                    productName = reader.GetString(0);
                    unitName = reader.GetString(1);
                    unitPrice = reader.GetInt32(2);
                    quantity = reader.GetInt32(3);
                    orderDetails.Add(new OrderDetailDTO(0, new OrderDTO(int.Parse(orderID), DateTime.Now, null, 0), new ProductDTO("", productName, null, null), new UnitDTO(0, unitName), unitPrice, quantity));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return orderDetails;
        }
    }
}
