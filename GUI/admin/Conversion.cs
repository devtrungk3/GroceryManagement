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
    public partial class Conversion : Form
    {
        private int limit = 10;
        private List<UnitDTO> fromUnits;
        private List<UnitDTO> toUnits;
        private List<UnitConversionDTO> conversions;
        private UnitBUS unitBUS = new UnitBUS();
        private UnitConversionBUS unitConversionBUS = new UnitConversionBUS();
        public Conversion()
        {
            InitializeComponent();
            this.Activated += MainForm_Activated;
        }
        private void MainForm_Activated(object sender, EventArgs e)
        {
            LoadConversionTable(0);
            LoadUnitComboBox();
        }
        private void LoadUnitComboBox()
        {
            fromUnits = unitBUS.GetUnits();
            toUnits = new List<UnitDTO>(fromUnits);

            cbFromUnit.DataSource = fromUnits;
            cbFromUnit.DisplayMember = "UnitName";
            cbFromUnit.ValueMember = "UnitID";
            cbFromUnit.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbFromUnit.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            cbToUnit.DataSource = toUnits;
            cbToUnit.DisplayMember = "UnitName";
            cbToUnit.ValueMember = "UnitID";
            cbToUnit.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbToUnit.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void LoadConversionTable(int change)
        {
            List<UnitConversionDTO> list;
            int currentPage = int.Parse(lbPageNumber.Text) + change;
            if (currentPage < 1) return;
            if (txtSearch.Text == "") list = unitConversionBUS.GetUnitConversionWithPaging(currentPage - 1, limit);
            else list = unitConversionBUS.GetUnitConversionByProductNameWithPaging(currentPage - 1, limit, txtSearch.Text);
            if (change != 0 && list.Count == 0) return;
            viewConversion.Items.Clear();
            conversions = list;
            lbPageNumber.Text = currentPage.ToString();
            ListViewItem item;
            foreach (UnitConversionDTO c in conversions)
            {
                item = new ListViewItem(c.ConversionID.ToString());
                item.SubItems.Add(c.ProductDTO.ProductName);
                item.SubItems.Add(c.FromUnit.UnitName);
                item.SubItems.Add(c.ToUnit.UnitName);
                item.SubItems.Add(c.Factor.ToString());
                viewConversion.Items.Add(item);
            }
        }

        private void Conversion_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadConversionTable(0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtProductID.Text == "" || txtFactor.Text == "")
            {
                MessageBox.Show("Không được để trống các thông tin cần thiết");
                return;
            }
            if (cbFromUnit.SelectedValue == null || cbToUnit.SelectedValue == null)
            {
                MessageBox.Show("Đơn vị không hợp lệ");
                return;
            }
            // check format
            if (!Regex.IsMatch(txtFactor.Text, @"^[1-9]\d*$"))
            {
                MessageBox.Show("Hệ số không hợp lệ");
                return;
            }
            // insert into database
            string message = unitConversionBUS.InsertUnitConversion(new UnitConversionDTO(0, new ProductDTO(txtProductID.Text, "", null, null), new UnitDTO((int)cbFromUnit.SelectedValue, ""), new UnitDTO((int)cbToUnit.SelectedValue, ""), int.Parse(txtFactor.Text)));
            if (message == "")
            {
                ClearTextBox();
                LoadConversionTable(0);
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void ClearTextBox()
        {
            txtConversionID.Text = "";
            txtProductID.Text = "";
            txtFactor.Text = "";
            lbPageNumber.Text = "1";
            cbFromUnit.SelectedIndex = 0;
            cbToUnit.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtConversionID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn quy đổi muốn cập nhật");
                return;
            }
            if (txtProductID.Text == "" || txtFactor.Text == "")
            {
                MessageBox.Show("Không được để trống các thông tin cần thiết");
                return;
            }
            if (cbFromUnit.SelectedValue == null || cbToUnit.SelectedValue == null)
            {
                MessageBox.Show("Đơn vị không hợp lệ");
                return;
            }
            // check format
            if (!Regex.IsMatch(txtFactor.Text, @"^[1-9]\d*$"))
            {
                MessageBox.Show("Hệ số không hợp lệ");
                return;
            }
            // update in database
            string message = unitConversionBUS.UpdateUnitConversion(new UnitConversionDTO(int.Parse(txtConversionID.Text), new ProductDTO(txtProductID.Text, "", null, null), new UnitDTO((int)cbFromUnit.SelectedValue, ""), new UnitDTO((int)cbToUnit.SelectedValue, ""), int.Parse(txtFactor.Text)));
            if (message == "")
            {
                ClearTextBox();
                LoadConversionTable(0);
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void viewConversion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewConversion.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = viewConversion.SelectedItems[0];
                txtConversionID.Text = conversions[selectedItem.Index].ConversionID.ToString();
                txtProductID.Text = conversions[selectedItem.Index].ProductDTO.ProductID.ToString();
                txtFactor.Text = selectedItem.SubItems[4].Text;
                cbFromUnit.SelectedValue = conversions[selectedItem.Index].FromUnit.UnitID;
                cbToUnit.SelectedValue = conversions[selectedItem.Index].ToUnit.UnitID;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtConversionID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn quy đổi muốn xóa");
                return;
            }
            // show confirmation message before deleting
            DialogResult dialog = MessageBox.Show($"Bạn có chắc chắn muốn xóa quy đổi [{txtConversionID.Text}] không?", "Xác nhận xóa quy đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog != DialogResult.Yes) return;
            // delete from database
            string message = unitConversionBUS.DeleteUnitConversion(txtConversionID.Text);
            if (message == "")
            {
                ClearTextBox();
                LoadConversionTable(0);
            }
            else
            {
                MessageBox.Show(message);
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            LoadConversionTable(-1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            LoadConversionTable(1);
        }
    }
}
