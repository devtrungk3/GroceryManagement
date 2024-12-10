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
    public partial class Unit : Form
    {
        private List<UnitDTO> units;
        private UnitBUS unitBUS = new UnitBUS();
        private int limit = 10;
        public Unit()
        {
            InitializeComponent();
        }
        private void Unit_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadUnitTable(0);
        }
        private void LoadUnitTable(int change)
        {
            List<UnitDTO> list;
            int currentPage = int.Parse(lbPageNumber.Text) + change;
            if (currentPage < 1) return;
            if (txtSearch.Text == "") list = unitBUS.GetUnitsWithPaging(currentPage-1, limit);
            else list = unitBUS.GetUnitsByUnitName(currentPage - 1, limit, txtSearch.Text);
            if (change != 0 && list.Count == 0) return;
            viewUnit.Items.Clear();
            units = list;
            lbPageNumber.Text = currentPage.ToString();
            ListViewItem item;
            foreach (UnitDTO u in units)
            {
                item = new ListViewItem(u.UnitID.ToString());
                item.SubItems.Add(u.UnitName);
                viewUnit.Items.Add(item);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            LoadUnitTable(1);
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            LoadUnitTable(-1);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadUnitTable(0);
        }
        private void ClearTextBox()
        {
            lbPageNumber.Text = "1";
            txtSearch.Text = "";
            txtUnitID.Text = "";
            txtUnitName.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtUnitName.Text == "")
            {
                MessageBox.Show("Không được để trống tên đơn vị");
                return;
            }
            // insert into database
            string message = unitBUS.InsertUnit(new UnitDTO(0, txtUnitName.Text));
            if (message == "")
            {
                ClearTextBox();
                LoadUnitTable(0);
            }
            else
            {
                MessageBox.Show(message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtUnitID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn vị muốn cập nhật");
                return;
            }
            if (txtUnitName.Text == "")
            {
                MessageBox.Show("Không được để trống tên đơn vị");
                return;
            }
            // update in database
            string message = unitBUS.UpdateUnit(new UnitDTO(int.Parse(txtUnitID.Text), txtUnitName.Text));
            if (message == "")
            {
                ClearTextBox();
                LoadUnitTable(0);
            }
            else
            {
                MessageBox.Show(message);
            }
        }
        private void viewUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewUnit.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = viewUnit.SelectedItems[0];
                txtUnitID.Text = selectedItem.SubItems[0].Text;
                txtUnitName.Text = selectedItem.SubItems[1].Text;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtUnitID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn vị muốn xóa");
                return;
            }
            // show confirmation message before deleting
            DialogResult dialog = MessageBox.Show($"Bạn có chắc chắn muốn xóa đơn vị [{txtUnitID.Text}] không?", "Xác nhận xóa đơn vị", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog != DialogResult.Yes) return;
            // delete from database
            string message = unitBUS.DeleteUnit(txtUnitID.Text);
            if (message == "")
            {
                ClearTextBox();
                LoadUnitTable(0);
            }
            else
            {
                MessageBox.Show(message);
            }
        }
    }
}
