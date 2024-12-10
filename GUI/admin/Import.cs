using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.admin
{
    public partial class Import : Form
    {
        private PurchaseBUS purchaseBUS = new PurchaseBUS();
        private PurchaseDetailBUS pdBUS = new PurchaseDetailBUS();
        private List<PurchaseDTO> purchases;
        private List<PurchaseDetailDTO> purchaseDetails;
        public Import()
        {
            InitializeComponent();
            this.Activated += MainForm_Activated;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            LoadPurchaseTable();
        }

        public void LoadPurchaseTable()
        {
            viewPurchase.Items.Clear();
            purchases = purchaseBUS.GetPurchasesByPurchaseDate(dtpPurchaseDate.Value.ToString("yyyy-MM"));
            ListViewItem item;
            foreach (PurchaseDTO p in purchases)
            {
                item = new ListViewItem(p.PurchaseID.ToString());
                item.SubItems.Add(p.SupplierDTO.SupplierName);
                item.SubItems.Add(p.TotalAmount.ToString());
                item.SubItems.Add(p.PurchaseDate.ToString("yyyy-MM-dd HH:mm:ss"));
                viewPurchase.Items.Add(item);
            }
            viewPurchaseDetail.Items.Clear();
        }

        private void Import_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void viewPurchase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewPurchase.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = viewPurchase.SelectedItems[0];
                LoadPurchaseDetailTable(selectedItem.SubItems[0].Text);
            }
        }
        private void LoadPurchaseDetailTable(string purchaseID)
        {
            viewPurchaseDetail.Items.Clear();
            purchaseDetails = pdBUS.GetPurchaseDetailsByPurchaseID(purchaseID);
            ListViewItem item;
            foreach (PurchaseDetailDTO pd in purchaseDetails)
            {
                item = new ListViewItem(pd.PurchaseDTO.PurchaseID.ToString());
                item.SubItems.Add(pd.ProductDTO.ProductName);
                item.SubItems.Add(pd.Quantity.ToString());
                item.SubItems.Add(pd.UnitDTO.UnitName);
                item.SubItems.Add(pd.UnitPrice.ToString());
                viewPurchaseDetail.Items.Add(item);
            }
        }
        private void dtpPurchaseDate_ValueChanged(object sender, EventArgs e)
        {
            LoadPurchaseTable();
        }
    }
}
