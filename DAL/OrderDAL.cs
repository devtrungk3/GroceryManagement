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
    public class OrderDAL: DBConnection
    {
        public bool InsertOrder(OrderDTO order)
        {
            try
            {
                OpenConnection();
                string query = $"insert into [ORDER] (username, total_amount) values ('{order.AccountDTO.Username}', {order.TotalAmount})";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            } catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
        public int FindLastOrderID()
        {
            try
            {
                OpenConnection();
                string query = "select top 1 order_id from [ORDER] order by order_id desc";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                if (result != null) return (int)result;
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { CloseConnection(); }
            return -1;
        }
        public List<OrderDTO> FindAllOrdersByCreatedAt(string date)
        {
            List<OrderDTO> orders = new List<OrderDTO>();
            try
            {
                OpenConnection();
                string query = "select order_id, username, total_amount, created_at from [ORDER] as o " +
                    $"where format(created_at, 'yyyy-MM-dd') = '{date}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int orderID, totalAmount;
                string username;
                DateTime createdAt;
                while (reader.Read())
                {
                    orderID = reader.GetInt32(0);
                    username = reader.GetString(1);
                    totalAmount = reader.GetInt32(2);
                    createdAt = reader.GetDateTime(3);
                    orders.Add(new OrderDTO(orderID, createdAt, new AccountDTO(username, "", "", "", null), totalAmount));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return orders;
        }
        public List<OrderDTO> FindAllOrdersByCreatedAtAndUsername(string date, string username)
        {
            List<OrderDTO> orders = new List<OrderDTO>();
            try
            {
                OpenConnection();
                string query = "select order_id, total_amount, created_at from [ORDER] as o " +
                    $"where format(created_at, 'yyyy-MM-dd') = '{date}' and username = '{username}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int orderID, totalAmount;
                DateTime createdAt;
                while (reader.Read())
                {
                    orderID = reader.GetInt32(0);
                    totalAmount = reader.GetInt32(1);
                    createdAt = reader.GetDateTime(2);
                    orders.Add(new OrderDTO(orderID, createdAt, new AccountDTO(username, "", "", "", null), totalAmount));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return orders;
        }
        public List<RevenueDTO> FindRevenueOfUsername()
        {
            List<RevenueDTO> revenues = new List<RevenueDTO>();
            try
            {
                OpenConnection();
                string query = "select username, sum(total_amount), count(order_id) from [ORDER] group by username";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                string username;
                int totalAmount, totalOrder;
                while (reader.Read())
                {
                    username = reader.GetString(0);
                    totalAmount = reader.GetInt32(1);
                    totalOrder = reader.GetInt32(2);
                    revenues.Add(new RevenueDTO(username, totalAmount, totalOrder));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return revenues;
        }
        public List<RevenueDTO> FindRevenueOfUsernameByMonthYear(string date)
        {
            List<RevenueDTO> revenues = new List<RevenueDTO>();
            try
            {
                OpenConnection();
                string query = $"select username, sum(total_amount), count(order_id) from [ORDER] where format(created_at, 'yyyy-MM') = '{date}' group by username";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                string username;
                int totalAmount, totalOrder;
                while (reader.Read())
                {
                    username = reader.GetString(0);
                    totalAmount = reader.GetInt32(1);
                    totalOrder = reader.GetInt32(2);
                    revenues.Add(new RevenueDTO(username, totalAmount, totalOrder));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return revenues;
        }
    }
}
