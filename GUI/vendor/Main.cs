using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.vendor
{
    public partial class Main : Form
    {
        private Seller? seller;
        private Order? order;
        private Account? account;

        public Main()
        {
            InitializeComponent();
        }

        private void openSellerBtn_Click(object sender, EventArgs e)
        {
            if (seller == null)
            {
                seller = new Seller();
                seller.FormClosed += Seller_FormClosed;
                seller.MdiParent = this;
                seller.Dock = DockStyle.Fill;
                seller.Show();
            }
            else
            {
                seller.Activate();
            }
        }

        private void Seller_FormClosed(object? sender, FormClosedEventArgs e)
        {
            seller = null;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            seller = new Seller();
            seller.FormClosed += Seller_FormClosed;
            seller.MdiParent = this;
            seller.Dock = DockStyle.Fill;
            seller.Show();
        }

        private void openOrderBtn_Click(object sender, EventArgs e)
        {
            if (order == null)
            {
                order = new Order();
                order.FormClosed += Order_FormClosed;
                order.MdiParent = this;
                order.Dock = DockStyle.Fill;
                order.Show();
            }
            else
            {
                order.Activate();
            }
        }

        private void Order_FormClosed(object? sender, FormClosedEventArgs e)
        {
            seller = null;
        }

        private void openAccountBtn_Click(object sender, EventArgs e)
        {
            if (account == null)
            {
                account = new Account();
                account.FormClosed += Account_FormClosed;
                account.MdiParent = this;
                account.Dock = DockStyle.Fill;
                account.Show();
            }
            else
            {
                account.Activate();
            }
        }

        private void Account_FormClosed(object? sender, FormClosedEventArgs e)
        {
            account = null;
        }
    }
}
