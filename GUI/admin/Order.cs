using BUS;
using DTO;
using GUI.inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.admin
{
    public partial class Order : Form
    {
        private OrderBUS orderBUS = new OrderBUS();
        private OrderDetailBUS odBUS = new OrderDetailBUS();
        private List<OrderDTO> orders;
        private List<OrderDetailDTO> orderDetails;
        public Order()
        {
            InitializeComponent();
            this.Activated += MainForm_Activated;
        }
        private void MainForm_Activated(object sender, EventArgs e)
        {
            LoadOrderTable();
        }
        public void LoadOrderTable()
        {
            viewOrder.Items.Clear();
            orders = orderBUS.GetOrdersByCreatedAt(dtpCreatedAt.Value.ToString("yyyy-MM-dd"));
            ListViewItem item;
            foreach (OrderDTO o in orders)
            {
                item = new ListViewItem(o.OrderID.ToString());
                item.SubItems.Add(o.AccountDTO.Username);
                item.SubItems.Add(o.TotalAmount.ToString());
                item.SubItems.Add(o.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss"));
                viewOrder.Items.Add(item);
            }
            viewOrderDetail.Items.Clear();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void viewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewOrder.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = viewOrder.SelectedItems[0];
                LoadOrderDetailTable(selectedItem.SubItems[0].Text);
            }
        }
        private void LoadOrderDetailTable(string orderID)
        {
            viewOrderDetail.Items.Clear();
            orderDetails = odBUS.GetOrderDetailsByOrderID(orderID);
            ListViewItem item;
            foreach (OrderDetailDTO od in orderDetails)
            {
                item = new ListViewItem(od.OrderDTO.OrderID.ToString());
                item.SubItems.Add(od.ProductDTO.ProductName);
                item.SubItems.Add(od.UnitDTO.UnitName);
                item.SubItems.Add(od.UnitPrice.ToString());
                item.SubItems.Add(od.Quantity.ToString());
                item.SubItems.Add((od.Quantity * od.UnitPrice).ToString());
                viewOrderDetail.Items.Add(item);
            }
        }

        private void dtpCreatedAt_ValueChanged(object sender, EventArgs e)
        {
            LoadOrderTable();
        }
    }
}
