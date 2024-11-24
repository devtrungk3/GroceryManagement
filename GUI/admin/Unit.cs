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
        private int pageNumber = 0;
        private int limit = 10;
        public Unit()
        {
            InitializeComponent();
        }

        private void Unit_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadUnitTable();
        }

        private void LoadUnitTable()
        {
            List<UnitDTO> list;
            if (txtSearch.Text == "") list = unitBUS.GetUnitsWithPaging(pageNumber, limit);
            else list = unitBUS.GetUnitsByUnitName(pageNumber, limit, txtSearch.Text);
            if (list.Count == 0)
            {
                if (pageNumber > 0) pageNumber--;
                return;
            }
            viewUnit.Rows.Clear();
            units = list;
            lbPageNumber.Text = (pageNumber + 1).ToString();
            foreach (UnitDTO u in units) viewUnit.Rows.Add(u.UnitID, u.UnitName);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pageNumber++;
            LoadUnitTable();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pageNumber != 0)
            {
                pageNumber--;
                LoadUnitTable();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadUnitTable();
        }

        private void ClearTextBox()
        {
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
                LoadUnitTable();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // check empty
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
                LoadUnitTable();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void viewUnit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int position = e.RowIndex;
            if (position < 0) return;
            txtUnitID.Text = units[position].UnitID.ToString();
            txtUnitName.Text = units[position].UnitName;
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
            DialogResult dialog = MessageBox.Show($"Bạn có chắc chắn muốn xóa danh mục [{txtUnitID.Text}] không?", "Xác nhận xóa danh mục", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog != DialogResult.Yes) return;
            // delete from database
            string message = unitBUS.DeleteUnit(txtUnitID.Text);
            if (message == "")
            {
                pageNumber = 0;
                ClearTextBox();
                LoadUnitTable();
            }
            else
            {
                MessageBox.Show(message);
            }
        }
    }
}
