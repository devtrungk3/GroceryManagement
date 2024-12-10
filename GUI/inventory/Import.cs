using BUS;
using DAL;
using DTO;
using GUI.admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.inventory
{
    public partial class Import : Form
    {
        private SupplierBUS supplierBUS = new SupplierBUS();
        private List<SupplierDTO> suppliers;
        private UnitBUS unitBUS = new UnitBUS();
        private List<UnitDTO> units;
        private ProductBUS productBUS = new ProductBUS();
        private List<PurchaseDetailDTO> purchaseDetails = new List<PurchaseDetailDTO>();
        private PurchaseBUS purchaseBUS = new PurchaseBUS();
        private PurchaseDetailBUS purchaseDetailBUS = new PurchaseDetailBUS();
        private int index = -1;
        public Import()
        {
            InitializeComponent();
            this.Activated += MainForm_Activated;
        }
        private void MainForm_Activated(object sender, EventArgs e)
        {
            LoadSupplierComboBox();
            LoadUnitComboBox();
        }
        private void LoadSupplierComboBox()
        {
            suppliers = supplierBUS.GetSuppliers();
            cbSuppiler.DataSource = suppliers;
            cbSuppiler.DisplayMember = "SupplierName";
            cbSuppiler.ValueMember = "SupplierID";

            cbSuppiler.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSuppiler.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        private void LoadUnitComboBox()
        {
            units = unitBUS.GetUnits();
            cbUnit.DataSource = units;
            cbUnit.DisplayMember = "UnitName";
            cbUnit.ValueMember = "UnitID";

            cbUnit.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbUnit.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        private void Import_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // checkempty
            if (txtProductID.Text == "" || txtQuantity.Text == "" || txtUnitPrice.Text == "")
            {
                MessageBox.Show("Các thông tin cần thiết không được để trống");
                return;
            }
            if (cbUnit.SelectedValue == null)
            {
                MessageBox.Show("Đơn vị không hợp lệ");
                return;
            }
            // check format
            if (!Regex.IsMatch(txtQuantity.Text, @"^[1-9]\d*$"))
            {
                MessageBox.Show("Số lượng không hợp lệ");
                return;
            }
            if (!Regex.IsMatch(txtUnitPrice.Text, @"^[1-9]\d*$"))
            {
                MessageBox.Show("Đơn giá không hợp lệ");
                return;
            }
            // check productID exists
            ProductDTO? product = productBUS.GetProductByProductID(txtProductID.Text);
            if (product == null)
            {
                MessageBox.Show("Mã sản phẩm không tồn tại");
                return;
            }
            // insert into table
            PurchaseDetailDTO purchaseDetail = new PurchaseDetailDTO(0, null, new ProductDTO(product.ProductID, product.ProductName, null, null), int.Parse(txtQuantity.Text), new UnitDTO((int)cbUnit.SelectedValue, cbUnit.Text), int.Parse(txtUnitPrice.Text));
            purchaseDetails.Add(purchaseDetail);
            LoadImportTable();
            ClearTextBox();
        }
        private void ClearTextBox()
        {
            txtProductID.Text = "";
            txtQuantity.Text = "";
            txtUnitPrice.Text = "";
            cbUnit.SelectedIndex = 0;
        }

        private void LoadImportTable()
        {
            viewImport.Items.Clear();
            int amount = 0;
            if (purchaseDetails.Count > 0)
            {
                ListViewItem item;
                foreach (PurchaseDetailDTO p in purchaseDetails)
                {
                    item = item = new ListViewItem(p.ProductDTO.ProductName);
                    item.SubItems.Add(p.Quantity.ToString());
                    item.SubItems.Add(p.UnitDTO.UnitName.ToString());
                    item.SubItems.Add(p.UnitPrice.ToString());
                    viewImport.Items.Add(item);
                    amount += p.Quantity * p.UnitPrice;
                }
            }
            lbTotalAmount.Text = amount.ToString();
        }

        private void viewImport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewImport.SelectedItems.Count > 0 && purchaseDetails.Count > 0)
            {
                ListViewItem selectedItem = viewImport.SelectedItems[0];
                index = selectedItem.Index;
                txtProductID.Text = purchaseDetails[index].ProductDTO.ProductID;
                txtQuantity.Text = selectedItem.SubItems[1].Text;
                cbUnit.SelectedValue = purchaseDetails[index].UnitDTO.UnitID;
                txtUnitPrice.Text = selectedItem.SubItems[3].Text;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (viewImport.Items.Count == 0) return;
            if (viewImport.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hàng muốn cập nhật");
                return;
            }
            // checkempty
            if (txtProductID.Text == "" || txtQuantity.Text == "" || txtUnitPrice.Text == "")
            {
                MessageBox.Show("Các thông tin cần thiết không được để trống");
                return;
            }
            if (cbUnit.SelectedValue == null)
            {
                MessageBox.Show("Đơn vị không hợp lệ");
                return;
            }
            // check format
            if (!Regex.IsMatch(txtQuantity.Text, @"^[1-9]\d*$"))
            {
                MessageBox.Show("Số lượng không hợp lệ");
                return;
            }
            if (!Regex.IsMatch(txtUnitPrice.Text, @"^[1-9]\d*$"))
            {
                MessageBox.Show("Đơn giá không hợp lệ");
                return;
            }
            // check productID exists
            ProductDTO? product = productBUS.GetProductByProductID(txtProductID.Text);
            if (product == null)
            {
                MessageBox.Show("Mã sản phẩm không tồn tại");
                return;
            }
            // update in table
            PurchaseDetailDTO purchaseDetail = new PurchaseDetailDTO(0, null, new ProductDTO(product.ProductID, product.ProductName, null, null), int.Parse(txtQuantity.Text), new UnitDTO((int)cbUnit.SelectedValue, cbUnit.Text), int.Parse(txtUnitPrice.Text));
            purchaseDetails[index] = purchaseDetail;
            LoadImportTable();
            ClearTextBox();
            index = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (viewImport.Items.Count == 0) return;
            if (viewImport.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hàng muốn xóa");
                return;
            }
            purchaseDetails.RemoveAt(viewImport.SelectedItems[0].Index);
            LoadImportTable();
            ClearTextBox();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            // check empty
            if (purchaseDetails.Count == 0) return;
            if (cbSuppiler.SelectedValue == null)
            {
                MessageBox.Show("Nhà cung cấp không hợp lệ");
                return;
            }
            // insert purchase into database
            PurchaseDTO purchase = new PurchaseDTO(0, new SupplierDTO((int)cbSuppiler.SelectedValue, "","",""), int.Parse(lbTotalAmount.Text), DateTime.Now);
            string message = purchaseBUS.InsertPurchase(purchase);
            if (message != "")
            {
                MessageBox.Show(message);
                return;
            }
            // get purchaseID
            int purchaseID = purchaseBUS.GetLastPurchaseID();
            if (purchaseID < 0) return;
            // insert purchase detail into database
            message = purchaseDetailBUS.InsertPurchaseDetail(purchaseID, purchaseDetails);
            if (message != "")
            {
                MessageBox.Show(message);
                return;
            }
            // clear data
            ClearTextBox();
            cbSuppiler.SelectedIndex = 0;
            purchaseDetails.Clear();
            LoadImportTable();
        }
    }
}
