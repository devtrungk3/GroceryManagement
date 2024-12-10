using BUS;
using DTO;
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
    public partial class Revenue : Form
    {
        private List<RevenueDTO> revenues;
        private OrderBUS orderBUS = new OrderBUS();
        public Revenue()
        {
            InitializeComponent();
            this.Activated += MainForm_Activated;
        }
        private void MainForm_Activated(object sender, EventArgs e)
        {
            LoadRevenueTable("MONTH");
        }
        private void LoadRevenueTable(string command)
        {
            switch (command)
            {
                case "TOTAL":
                    revenues = orderBUS.GetRevenueOfUsername();
                    break;
                case "MONTH":
                    revenues = orderBUS.GetRevenueOfUsernameByMonthYear(datePicker.Value.ToString("yyyy-MM"));

                    break;
            }
            ListViewItem item;
            int totalOrder = 0;
            int totalAmount = 0;
            viewRevenue.Items.Clear();
            foreach (RevenueDTO r in revenues)
            {
                item = new ListViewItem(r.Username);
                item.SubItems.Add(r.TotalAmount.ToString());
                item.SubItems.Add(r.TotalOrder.ToString());
                viewRevenue.Items.Add(item);
                totalAmount += r.TotalAmount;
                totalOrder += r.TotalOrder;
            }
            txtTotalAmount.Text = totalAmount.ToString();
            txtTotalOrder.Text = totalOrder.ToString();
        }

        private void Revenue_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            LoadRevenueTable("TOTAL");
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadRevenueTable("MONTH");
        }
    }
}
