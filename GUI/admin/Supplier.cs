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
        private int pageNumber = 0;
        private int limit = 10;
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadSupplierTable();
        }

        private void LoadSupplierTable()
        {
            List<SupplierDTO> list;
            if (txtSearch.Text == "") list = supplierBUS.GetSuppliersWithPaging(pageNumber, limit);
            else list = supplierBUS.GetSuppliersBySupplierName(pageNumber, limit, txtSearch.Text);
            if (list.Count == 0)
            {
                if (pageNumber > 0) pageNumber--;
                return;
            }
            viewSupplier.Rows.Clear();
            suppliers = list;
            lbPageNumber.Text = (pageNumber + 1).ToString();
            foreach (SupplierDTO s in suppliers) viewSupplier.Rows.Add(s.SupplierID, s.SupplierName, s.Phone, s.Address);
        }

        private void ClearTextBox()
        {
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
            pageNumber++;
            LoadSupplierTable();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pageNumber != 0)
            {
                pageNumber--;
                LoadSupplierTable();
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
            LoadSupplierTable();
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
                LoadSupplierTable();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

            // update in database
            string message = supplierBUS.UpdateSupplier(new SupplierDTO(int.Parse(txtSupplierID.Text), txtSupplierName.Text, txtPhone.Text, txtAddress.Text));
            if (message == "")
            {
                ClearTextBox();
                LoadSupplierTable();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
            // show confirmation message before deleting
            DialogResult dialog = MessageBox.Show($"Bạn có chắc chắn muốn xóa danh mục [{txtSupplierID.Text}] không?", "Xác nhận xóa danh mục", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog != DialogResult.Yes) return;
            // delete from database
            string message = supplierBUS.DeleteSupplier(txtSupplierID.Text);
            if (message == "")
            {
                pageNumber = 0;
                ClearTextBox();
                LoadSupplierTable();
            }
            else
            {
                MessageBox.Show(message);
            }
        }
    }
}
