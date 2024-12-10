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

namespace GUI.inventory
{
    public partial class Dashboard : Form
    {
        private int limit = 10;
        private InventoryBUS inventoryBUS = new InventoryBUS();
        private List<InventoryDTO> inventories;
        public Dashboard()
        {
            InitializeComponent();
            this.Activated += MainForm_Activated;
        }
        private void MainForm_Activated(object sender, EventArgs e)
        {
            lbTotalQuantity.Text = inventoryBUS.GetTotalQuantity().ToString();
            LoadInventoryTable(0);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void LoadInventoryTable(int change)
        {
            List<InventoryDTO> list;
            int currentPage = int.Parse(lbPageNumber.Text) + change;
            if (currentPage < 1) return;
            if (txtSearch.Text == "") list = inventoryBUS.GetInventoriesWithPaging(currentPage - 1, limit);
            else list = inventoryBUS.GetInventoriesByProductNameWithPaging(currentPage - 1, limit, txtSearch.Text);
            if (change != 0 && list.Count == 0) return;
            viewInventory.Items.Clear();
            inventories = list;
            lbPageNumber.Text = currentPage.ToString();
            ListViewItem item;
            foreach (InventoryDTO i in inventories)
            {
                item = new ListViewItem(i.InventoryID.ToString());
                item.SubItems.Add(i.ProductDTO.ProductName);
                item.SubItems.Add(i.Quantity.ToString());
                viewInventory.Items.Add(item);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            LoadInventoryTable(-1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            LoadInventoryTable(1);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadInventoryTable(0);
        }
    }
}
