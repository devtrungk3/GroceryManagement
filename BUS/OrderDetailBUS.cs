using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class OrderDetailBUS
    {
        private OrderDetailDAL odDAL = new OrderDetailDAL();
        public string InsertOrderDetail(int orderID, List<OrderDetailDTO> orderDetails)
        {
            if (odDAL.InsertOrderDetail(orderID, orderDetails)) return "";
            return "Thêm chi tiết đơn hàng thất bại";
        }
        public List<OrderDetailDTO> GetOrderDetailsByOrderID(string orderID)
        {
            return odDAL.FindAllOrderDetailsByOrderID(orderID);
        }
    }
}
