using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RevenueDTO
    {
        public string Username { get; set; }
        public int TotalAmount { get; set; }
        public int TotalOrder {  get; set; }
        public RevenueDTO(string username, int totalAmount, int totalOrder)
        {
            Username = username;
            TotalAmount = totalAmount;
            TotalOrder = totalOrder;
        }
    }
}
