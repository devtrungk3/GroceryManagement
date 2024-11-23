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
    public partial class Category : Form
    {
        private List<CategoryDTO> categories;
        private CategoryBUS categoryBUS = new CategoryBUS();
        private int pageNumber = 0;
        private int limit = 10;
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadCategoryTable();
        }

        private void LoadCategoryTable()
        {
            List<CategoryDTO> list;
            if (txtSearch.Text == "") list = categoryBUS.GetCategories(pageNumber, limit);
            else list = categoryBUS.GetCategoriesByCategoryName(pageNumber, limit, txtSearch.Text);
            if (list.Count == 0)
            {
                if (pageNumber > 0) pageNumber--;
                return;
            }
            viewCategory.Rows.Clear();
            categories = list;
            lbPageNumber.Text = (pageNumber + 1).ToString();
            foreach (CategoryDTO c in categories) viewCategory.Rows.Add(c.CategoryID, c.CategoryName);
        }

        private void ClearTextBox()
        {
            txtSearch.Text = "";
            txtCategoryID.Text = "";
            txtCategoryName.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Không được để trống tên danh mục");
                return;
            }
            // insert into database
            string message = categoryBUS.InsertCategory(new CategoryDTO(0, txtCategoryName.Text));
            if (message == "")
            {
                ClearTextBox();
                LoadCategoryTable();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Không được để trống tên danh mục");
                return;
            }
            // update in database
            string message = categoryBUS.UpdateCategory(new CategoryDTO(int.Parse(txtCategoryID.Text), txtCategoryName.Text));
            if (message == "")
            {
                ClearTextBox();
                LoadCategoryTable();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pageNumber++;
            LoadCategoryTable();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pageNumber != 0)
            {
                pageNumber--;
                LoadCategoryTable();
            }
        }

        private void viewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int position = e.RowIndex;
            if (position < 0) return;
            txtCategoryID.Text = categories[position].CategoryID.ToString();
            txtCategoryName.Text = categories[position].CategoryName;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtCategoryID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn danh mục muốn xóa");
                return;
            }
            // show confirmation message before deleting
            DialogResult dialog = MessageBox.Show($"Bạn có chắc chắn muốn xóa danh mục [{txtCategoryID.Text}] không?", "Xác nhận xóa danh mục", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog != DialogResult.Yes) return;
            // delete from database
            string message = categoryBUS.DeleteCategory(txtCategoryID.Text);
            if (message == "")
            {
                pageNumber = 0;
                ClearTextBox();
                LoadCategoryTable();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCategoryTable();
        }
    }
}
