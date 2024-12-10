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
    public partial class Product : Form
    {
        public bool reset = false;
        private List<ProductDTO> products;
        private ProductBUS productBUS = new ProductBUS();
        private CategoryBUS categoryBUS = new CategoryBUS();
        private UnitBUS unitBUS = new UnitBUS();
        private int limit = 10;
        private List<CategoryDTO> categories;
        private List<UnitDTO> units;
        public Product()
        {
            InitializeComponent();
            this.Activated += MainForm_Activated;
        }
        private void MainForm_Activated(object sender, EventArgs e)
        {
            LoadProductTable(0);
            LoadCategoryComboBox();
            LoadUnitComboBox();
        }
        private void Product_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadProductTable(0);
            LoadCategoryComboBox();
        }
        private void LoadProductTable(int change)
        {
            List<ProductDTO> list;
            int currentPage = int.Parse(lbPageNumber.Text) + change;
            if (currentPage < 1) return;
            if (txtSearch.Text == "") list = productBUS.GetProductsWithPaging(currentPage - 1, limit);
            else list = productBUS.GetProductsByProductName(currentPage - 1, limit, txtSearch.Text);
            if (change != 0 && list.Count == 0) return;
            viewProduct.Items.Clear();
            products = list;
            lbPageNumber.Text = currentPage.ToString();
            ListViewItem item;
            foreach (ProductDTO p in products)
            {
                item = new ListViewItem(p.ProductID);
                item.SubItems.Add(p.ProductName);
                item.SubItems.Add(p.CategoryDTO.CategoryName);
                item.SubItems.Add(p.UnitDTO.UnitName);
                viewProduct.Items.Add(item);
            }
        }
        private void LoadCategoryComboBox()
        {
            categories = categoryBUS.GetCategories();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";

            cbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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
            if (txtProductID.Text == "" || txtProductName.Text == "")
            {
                MessageBox.Show("Không được để trống các thông tin cần thiết");
                return;
            }
            if (cbCategory.SelectedValue == null)
            {
                MessageBox.Show("Danh mục không hợp lệ");
                return;
            }
            if (cbUnit.SelectedValue == null)
            {
                MessageBox.Show("Đơn vị không hợp lệ");
                return;
            }
            // insert into database
            string message = productBUS.InsertProduct(new ProductDTO(txtProductID.Text, txtProductName.Text, new CategoryDTO((int)cbCategory.SelectedValue, ""), new UnitDTO((int)cbUnit.SelectedValue, "")));
            if (message == "")
            {
                ClearTextBox();
                LoadProductTable(0);
            }
            else
            {
                MessageBox.Show(message);
            }
        }
        private void ClearTextBox()
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtSearch.Text = "";
            lbPageNumber.Text = "1";
            cbCategory.SelectedIndex = 0;
            cbUnit.SelectedIndex = 0;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtProductID.Text == "" || txtProductName.Text == "")
            {
                MessageBox.Show("Không được để trống các thông tin cần thiết");
                return;
            }
            if (cbCategory.SelectedValue == null)
            {
                MessageBox.Show("Danh mục không hợp lệ");
                return;
            }
            if (cbUnit.SelectedValue == null)
            {
                MessageBox.Show("Đơn vị không hợp lệ");
                return;
            }
            // update in database
            string message = productBUS.UpdateProduct(new ProductDTO(txtProductID.Text, txtProductName.Text, new CategoryDTO((int)cbCategory.SelectedValue, ""), new UnitDTO((int)cbUnit.SelectedValue, "")));
            if (message == "")
            {
                ClearTextBox();
                LoadProductTable(0);
            }
            else
            {
                MessageBox.Show(message);
            }
        }
        private void viewProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewProduct.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = viewProduct.SelectedItems[0];
                txtProductID.Text = selectedItem.SubItems[0].Text;
                txtProductName.Text = selectedItem.SubItems[1].Text;
                cbCategory.SelectedValue = products[selectedItem.Index].CategoryDTO.CategoryID;
                cbUnit.SelectedValue = products[selectedItem.Index].UnitDTO.UnitID;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtProductID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn xóa");
                return;
            }
            // show confirmation message before deleting
            DialogResult dialog = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm [{txtProductID.Text}] không?", "Xác nhận xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog != DialogResult.Yes) return;
            // delete from database
            string message = productBUS.DeleteProduct(txtProductID.Text);
            if (message == "")
            {
                ClearTextBox();
                LoadProductTable(0);
            }
            else
            {
                MessageBox.Show(message);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            LoadProductTable(1);
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            LoadProductTable(-1);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProductTable(0);
        }
    }
}
