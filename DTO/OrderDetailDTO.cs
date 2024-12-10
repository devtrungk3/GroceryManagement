using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDetailDTO
    {
        public int OrderDetailID { get; set; }
        public OrderDTO OrderDTO { get; set; }
        public ProductDTO ProductDTO {  get; set; }
        public UnitDTO UnitDTO { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public OrderDetailDTO(int orderDetailID, OrderDTO orderDTO, ProductDTO productDTO, UnitDTO unitDTO, int unitPrice, int quantity)
        {
            OrderDetailID = orderDetailID;
            OrderDTO = orderDTO;
            ProductDTO = productDTO;
            UnitDTO = unitDTO;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }
        public OrderDetailDTO(OrderDetailDTO other)
        {
            OrderDetailID = other.OrderDetailID;
            OrderDTO = other.OrderDTO;
            ProductDTO = other.ProductDTO;
            UnitDTO = other.UnitDTO;
            UnitPrice = other.UnitPrice;
            Quantity = other.Quantity;
        }
    }
}
