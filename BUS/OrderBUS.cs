using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class OrderBUS
    {
        private OrderDAL orderDAL = new OrderDAL();
        public string InsertOrder(OrderDTO order)
        {
            if (orderDAL.InsertOrder(order)) return "";
            return "Thêm đơn hàng thất bại";
        }
        public int GetLastOrderID()
        {
            return orderDAL.FindLastOrderID();
        }
        public List<OrderDTO> GetOrdersByCreatedAt(string date)
        {
            return orderDAL.FindAllOrdersByCreatedAt(date);
        }
        public List<OrderDTO> GetOrdersByCreatedAtAndUsername(string date, string username)
        {
            return orderDAL.FindAllOrdersByCreatedAtAndUsername(date, username);
        }
        public List<RevenueDTO> GetRevenueOfUsername()
        {
            return orderDAL.FindRevenueOfUsername();
        }
        public List<RevenueDTO> GetRevenueOfUsernameByMonthYear(string date)
        {
            return orderDAL.FindRevenueOfUsernameByMonthYear(date);
        }
    }
}
