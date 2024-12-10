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
    public partial class Price : Form
    {
        private int limit = 10;
        private PriceBUS priceBUS = new PriceBUS();
        private UnitBUS unitBUS = new UnitBUS();
        private List<PriceDTO> prices;
        private List<UnitDTO> units;
        public Price()
        {
            InitializeComponent();
            this.Activated += MainForm_Activated;
        }
        private void MainForm_Activated(object sender, EventArgs e)
        {
            LoadPriceTable(0);
            LoadUnitComboBox();
        }
        private void Price_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        private void LoadPriceTable(int change)
        {
            List<PriceDTO> list;
            int currentPage = int.Parse(lbPageNumber.Text) + change;
            if (currentPage < 1) return;
            if (txtSearch.Text == "") list = priceBUS.GetPricesWithPaging(currentPage - 1, limit);
            else list = priceBUS.GetPricesByProductNameWithPaging(currentPage - 1, limit, txtSearch.Text);
            if (change != 0 && list.Count == 0) return;
            viewPrice.Items.Clear();
            prices = list;
            lbPageNumber.Text = currentPage.ToString();
            ListViewItem item;
            foreach (PriceDTO p in prices)
            {
                item = new ListViewItem(p.PriceID.ToString());
                item.SubItems.Add(p.ProductDTO.ProductName);
                item.SubItems.Add(p.UnitDTO.UnitName);
                item.SubItems.Add(p.Price.ToString());
                viewPrice.Items.Add(item);
            }
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtProductID.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Không được để trống các thông tin cần thiết");
                return;
            }
            if (cbUnit.SelectedValue == null)
            {
                MessageBox.Show("Đơn vị không hợp lệ");
                return;
            }
            // check format
            if (!Regex.IsMatch(txtPrice.Text, @"^[0-9]\d*$"))
            {
                MessageBox.Show("Giá bán không đúng định dạng");
                return;
            }
            // insert into database
            string message = priceBUS.InsertPrice(new PriceDTO(0, int.Parse(txtPrice.Text), new ProductDTO(txtProductID.Text, "", null, null), new UnitDTO((int)cbUnit.SelectedValue, "")));
            if (message == "")
            {
                ClearTextBox();
                LoadPriceTable(0);
            }
            else
            {
                MessageBox.Show(message);
            }
        }
        private void ClearTextBox()
        {
            txtPriceID.Text = "";
            txtPrice.Text = "";
            txtProductID.Text = "";
            lbPageNumber.Text = "1";
            cbUnit.SelectedIndex = 0;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtPriceID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã giá bán muốn cập nhật");
                return;
            }
            if (txtProductID.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Không được để trống các thông tin cần thiết");
                return;
            }
            if (cbUnit.SelectedValue == null)
            {
                MessageBox.Show("Đơn vị không hợp lệ");
                return;
            }
            // check format
            if (!Regex.IsMatch(txtPrice.Text, @"^[0-9]\d*$"))
            {
                MessageBox.Show("Giá bán không đúng định dạng");
                return;
            }
            // udpate in database
            string message = priceBUS.UpdatePrice(new PriceDTO(int.Parse(txtPriceID.Text), int.Parse(txtPrice.Text), new ProductDTO(txtProductID.Text, "", null, null), new UnitDTO((int)cbUnit.SelectedValue, "")));
            if (message == "")
            {
                ClearTextBox();
                LoadPriceTable(0);
            }
            else
            {
                MessageBox.Show(message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtPriceID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn giá bán muốn xóa");
                return;
            }
            // show confirmation message before deleting
            DialogResult dialog = MessageBox.Show($"Bạn có chắc chắn muốn xóa giá bán [{txtPriceID.Text}] không?", "Xác nhận xóa giá bán", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog != DialogResult.Yes) return;
            // delete from database
            string message = priceBUS.DeletePrice(txtPriceID.Text);
            if (message == "")
            {
                ClearTextBox();
                LoadPriceTable(0);
            }
            else
            {
                MessageBox.Show(message);
            }
        }
        private void viewPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewPrice.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = viewPrice.SelectedItems[0];
                txtPriceID.Text = selectedItem.SubItems[0].Text;
                txtProductID.Text = prices[selectedItem.Index].ProductDTO.ProductID;
                cbUnit.SelectedValue = prices[selectedItem.Index].UnitDTO.UnitID;
                txtPrice.Text = selectedItem.SubItems[3].Text;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadPriceTable(0);
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            LoadPriceTable(-1);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            LoadPriceTable(1);
        }
    }
}
