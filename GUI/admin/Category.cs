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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.admin
{
    public partial class Category : Form
    {
        private List<CategoryDTO> categories;
        private CategoryBUS categoryBUS = new CategoryBUS();
        private int limit = 10;
        public Category()
        {
            InitializeComponent();
        }
        private void Category_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadCategoryTable(0);
        }
        private void LoadCategoryTable(int change)
        {
            List<CategoryDTO> list;
            int currentPage = int.Parse(lbPageNumber.Text) + change;
            if (currentPage < 1) return;
            if (txtSearch.Text == "") list = categoryBUS.GetCategoriesWithPaging(currentPage - 1, limit);
            else list = categoryBUS.GetCategoriesByCategoryName(currentPage - 1, limit, txtSearch.Text);
            if (change != 0 && list.Count == 0) return;
            viewCategory.Items.Clear();
            categories = list;
            lbPageNumber.Text = currentPage.ToString();
            ListViewItem item;
            foreach (CategoryDTO c in categories)
            {
                item = new ListViewItem(c.CategoryID.ToString());
                item.SubItems.Add(c.CategoryName);
                viewCategory.Items.Add(item);
            }
        }
        private void ClearTextBox()
        {
            lbPageNumber.Text = "1";
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
                LoadCategoryTable(0);
            }
            else
            {
                MessageBox.Show(message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtCategoryID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn danh mục muốn cập nhật");
                return;
            }
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
                LoadCategoryTable(0);
            }
            else
            {
                MessageBox.Show(message);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            LoadCategoryTable(1);
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            LoadCategoryTable(-1);
        }
        private void viewCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewCategory.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = viewCategory.SelectedItems[0];
                txtCategoryID.Text = selectedItem.SubItems[0].Text;
                txtCategoryName.Text = selectedItem.SubItems[1].Text;
            }
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
                ClearTextBox();
                LoadCategoryTable(0);
            }
            else
            {
                MessageBox.Show(message);
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCategoryTable(0);
        }
    }
}
