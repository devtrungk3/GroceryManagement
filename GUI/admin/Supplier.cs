using BUS;
using DTO;
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

namespace GUI.admin
{
    public partial class Supplier : Form
    {
        private List<SupplierDTO> suppliers;
        private SupplierBUS supplierBUS = new SupplierBUS();
        private int limit = 10;
        public Supplier()
        {
            InitializeComponent();
        }
        private void Supplier_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadSupplierTable(0);
        }
        private void LoadSupplierTable(int change)
        {
            List<SupplierDTO> list;
            int currentPage = int.Parse(lbPageNumber.Text) + change;
            if (currentPage < 1) return;
            if (txtSearch.Text == "") list = supplierBUS.GetSuppliersWithPaging(currentPage - 1, limit);
            else list = supplierBUS.GetSuppliersBySupplierName(currentPage - 1, limit, txtSearch.Text);
            if (change != 0 && list.Count == 0) return;
            viewSupplier.Items.Clear();
            suppliers = list;
            lbPageNumber.Text = currentPage.ToString();
            ListViewItem item;
            foreach (SupplierDTO s in suppliers)
            {
                item = new ListViewItem(s.SupplierID.ToString());
                item.SubItems.Add(s.SupplierName);
                item.SubItems.Add(s.Phone);
                item.SubItems.Add(s.Address);
                viewSupplier.Items.Add(item);
            }
        }
        private void ClearTextBox()
        {
            lbPageNumber.Text = "1";
            txtSearch.Text = "";
            txtSupplierID.Text = "";
            txtSupplierName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }
        private bool Validate(string phone)
        {
            if (!Regex.IsMatch(phone, @"^[0-9]{10,15}$"))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng");
                return false;
            }
            return true;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            LoadSupplierTable(1);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            LoadSupplierTable(-1);
        }

        private void viewSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewSupplier.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = viewSupplier.SelectedItems[0];
                txtSupplierID.Text = selectedItem.SubItems[0].Text;
                txtSupplierName.Text = selectedItem.SubItems[1].Text;
                txtPhone.Text = selectedItem.SubItems[2].Text;
                txtAddress.Text = selectedItem.SubItems[3].Text;
            }
        }

        private void viewSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int position = e.RowIndex;
            if (position < 0) return;
            txtSupplierID.Text = suppliers[position].SupplierID.ToString();
            txtSupplierName.Text = suppliers[position].SupplierName;
            txtPhone.Text = suppliers[position].Phone;
            txtAddress.Text = suppliers[position].Address;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSupplierTable(0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtSupplierName.Text == "")
            {
                MessageBox.Show("Không được để trống tên nhà cung cấp");
                return;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Không được để trống số điện thoại");
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Không được để trống địa chỉ");
                return;
            }

            // check format
            if (!Validate(txtPhone.Text)) return;

            // insert into database
            string message = supplierBUS.InsertSupplier(new SupplierDTO(0, txtSupplierName.Text, txtPhone.Text, txtAddress.Text));
            if (message == "")
            {
                ClearTextBox();
                LoadSupplierTable(0);
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtSupplierID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp muốn cập nhật");
                return;
            }
            if (txtSupplierName.Text == "")
            {
                MessageBox.Show("Không được để trống tên nhà cung cấp");
                return;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Không được để trống số điện thoại");
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Không được để trống địa chỉ");
                return;
            }

            // check format
            if (!Validate(txtPhone.Text)) return;

            // update in database
            string message = supplierBUS.UpdateSupplier(new SupplierDTO(int.Parse(txtSupplierID.Text), txtSupplierName.Text, txtPhone.Text, txtAddress.Text));
            if (message == "")
            {
                ClearTextBox();
                LoadSupplierTable(0);
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtSupplierID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp muốn xóa");
                return;
            }
            // show confirmation message before deleting
            DialogResult dialog = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhà cung cấp [{txtSupplierID.Text}] không?", "Xác nhận xóa nhà cung cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog != DialogResult.Yes) return;
            // delete from database
            string message = supplierBUS.DeleteSupplier(txtSupplierID.Text);
            if (message == "")
            {
                ClearTextBox();
                LoadSupplierTable(0);
            }
            else
            {
                MessageBox.Show(message);
            }
        }
    }
}
