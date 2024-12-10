using BUS;
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
    public partial class Adjustment : Form
    {
        private ProductBUS productBUS = new ProductBUS();
        private AdjustmentBUS adBUS = new AdjustmentBUS();
        private List<AdjustmentDTO> adjustments;
        public Adjustment()
        {
            InitializeComponent();
            this.Activated += MainForm_Activated;
        }
        private void MainForm_Activated(object sender, EventArgs e)
        {
            LoadAdjustmentTable();
        }
        private void LoadAdjustmentTable()
        {
            adjustments = adBUS.GetAdjustmentsByAdjustmentDate(dtpCreateAdjustment.Value.ToString("yyyy-MM-dd"));
            viewAdjustment.Items.Clear();
            ListViewItem item;
            foreach (AdjustmentDTO a in adjustments)
            {
                item = new ListViewItem(a.AdjustmentID.ToString());
                item.SubItems.Add(a.ProductDTO.ProductName);
                item.SubItems.Add(a.Quantity.ToString());
                item.SubItems.Add(a.Reason);
                item.SubItems.Add(a.AdjustmentDate.ToString("yyyy-MM-dd HH:mm:ss"));
                viewAdjustment.Items.Add(item);
            }
        }

        private void Adjustment_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtProductID.Text == "" || txtQuantity.Text == "" || txtReason.Text == "")
            {
                MessageBox.Show("Không được bỏ trống các thông tin cần thiết");
                return;
            }
            // check format
            if (!Regex.IsMatch(txtQuantity.Text, @"^[-+]?\d+$"))
            {
                MessageBox.Show("Số lượng không hợp lệ");
                return;
            }
            // check product id exists
            ProductDTO? product = productBUS.GetProductByProductID(txtProductID.Text);
            if (product == null)
            {
                MessageBox.Show("Mã sản phẩm không tồn tại");
                return;
            }
            // insert into database
            string message = adBUS.InsertAdjustment(new AdjustmentDTO(0, product, int.Parse(txtQuantity.Text), txtReason.Text, DateTime.Now));
            if (message != "")
            {
                MessageBox.Show(message);
                return;
            }
            LoadAdjustmentTable();
            ClearTextBox();
        }
        private void ClearTextBox()
        {
            txtAdjustmentID.Text = "";
            txtProductID.Text = "";
            txtQuantity.Text = "";
            txtReason.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // check select
            if (txtAdjustmentID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn điều chỉnh muốn cập nhật");
                return;
            }
            // check empty
            if (txtProductID.Text == "" || txtQuantity.Text == "" || txtReason.Text == "")
            {
                MessageBox.Show("Không được bỏ trống các thông tin cần thiết");
                return;
            }
            // check format
            if (!Regex.IsMatch(txtQuantity.Text, @"^[-+]?\d+$"))
            {
                MessageBox.Show("Số lượng không hợp lệ");
                return;
            }
            // check product id exists
            ProductDTO? product = productBUS.GetProductByProductID(txtProductID.Text);
            if (product == null)
            {
                MessageBox.Show("Mã sản phẩm không tồn tại");
                return;
            }
            // update in database
            string message = adBUS.UpdateAdjustment(new AdjustmentDTO(int.Parse(txtAdjustmentID.Text), product, int.Parse(txtQuantity.Text), txtReason.Text, DateTime.Now));
            if (message != "")
            {
                MessageBox.Show(message);
                return;
            }
            LoadAdjustmentTable();
            ClearTextBox();
        }

        private void viewAdjustment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewAdjustment.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = viewAdjustment.SelectedItems[0];
                txtAdjustmentID.Text = selectedItem.SubItems[0].Text;
                txtProductID.Text = adjustments[selectedItem.Index].ProductDTO.ProductID;
                txtQuantity.Text = selectedItem.SubItems[2].Text;
                txtReason.Text = selectedItem.SubItems[3].Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // check select
            if (txtAdjustmentID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn điều chỉnh muốn xóa");
                return;
            }
            // show confirmation message before deleting
            DialogResult dialog = MessageBox.Show($"Bạn có chắc chắn muốn xóa điều chỉnh [{txtAdjustmentID.Text}] không?", "Xác nhận xóa điều chỉnh", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog != DialogResult.Yes) return;
            // delete from database
            string message = adBUS.DeleteAdjustment(txtAdjustmentID.Text);
            if (message != "")
            {
                MessageBox.Show("Xóa điều chỉnh thất bại");
                return;
            }
            LoadAdjustmentTable();
            ClearTextBox();
        }

        private void dtpCreateAdjustment_ValueChanged(object sender, EventArgs e)
        {
            LoadAdjustmentTable();
        }
    }
}
