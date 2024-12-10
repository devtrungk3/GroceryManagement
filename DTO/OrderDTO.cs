using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDTO
    {
        public int OrderID { get; set; }
        public DateTime CreatedAt {  get; set; }
        public AccountDTO AccountDTO {  get; set; }
        public int TotalAmount { get; set; }
        public OrderDTO(int orderID, DateTime createdAt, AccountDTO accountDTO, int totalAmount)
        {
            OrderID = orderID;
            CreatedAt = createdAt;
            AccountDTO = accountDTO;
            TotalAmount = totalAmount;
        }
    }
}
