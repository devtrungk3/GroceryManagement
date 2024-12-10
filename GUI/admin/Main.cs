using DTO;
using GUI.authentication;
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
    public partial class Main : Form
    {
        private Category? category;
        private Supplier? supplier;
        private Product? product;
        private Unit? unit;
        private Price? price;
        private Inventory? inventory;
        private Revenue? revenue;
        private Account? account;
        private Order? order;
        private Import? import;
        private Adjustment? adjustment;
        private Conversion? conversion;
        private AccountDTO accountDTO;
        public Main(AccountDTO account)
        {
            accountDTO = account;
            InitializeComponent();
        }

        private void openCategoryBtn_Click(object sender, EventArgs e)
        {
            if (category == null)
            {
                category = new Category();
                category.FormClosed += Category_FormClosed;
                category.MdiParent = this;
                category.Dock = DockStyle.Fill;
                category.Show();
            }
            else
            {
                category.Activate();
            }
        }
        private void Category_FormClosed(object sender, FormClosedEventArgs e)
        {
            category = null;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            revenue = new Revenue();
            revenue.FormClosed += Revenue_FormClosed;
            revenue.MdiParent = this;
            revenue.Dock = DockStyle.Fill;
            revenue.Show();
        }

        private void openSupplierBtn_Click(object sender, EventArgs e)
        {
            if (supplier == null)
            {
                supplier = new Supplier();
                supplier.FormClosed += Supplier_FormClosed;
                supplier.MdiParent = this;
                supplier.Dock = DockStyle.Fill;
                supplier.Show();
            }
            else
            {
                supplier.Activate();
            }
        }
        private void Supplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            supplier = null;
        }

        private void openProductBtn_Click(object sender, EventArgs e)
        {
            if (product == null)
            {
                product = new Product();
                product.FormClosed += Product_FormClosed;
                product.MdiParent = this;
                product.Dock = DockStyle.Fill;
                product.Show();
            }
            else
            {
                product.reset = true;
                product.Activate();
            }
        }
        private void Product_FormClosed(object sender, FormClosedEventArgs e)
        {
            product = null;
        }

        private void openOrderBtn_Click(object sender, EventArgs e)
        {
            if (order == null)
            {
                order = new Order();
                order.FormClosed += Order_FormClosed;
                order.MdiParent = this;
                order.Dock = DockStyle.Fill;
                order.Show();
            }
            else
            {
                order.Activate();
            }
        }
        private void Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            order = null;
        }

        private void openUnitBtn_Click(object sender, EventArgs e)
        {
            if (unit == null)
            {
                unit = new Unit();
                unit.FormClosed += Unit_FormClosed;
                unit.MdiParent = this;
                unit.Dock = DockStyle.Fill;
                unit.Show();
            }
            else
            {
                unit.Activate();
            }
        }
        private void Unit_FormClosed(object sender, FormClosedEventArgs e)
        {
            unit = null;
        }

        private void openPriceBtn_Click(object sender, EventArgs e)
        {
            if (price == null)
            {
                price = new Price();
                price.FormClosed += Price_FormClosed;
                price.MdiParent = this;
                price.Dock = DockStyle.Fill;
                price.Show();
            }
            else
            {
                price.Activate();
            }
        }
        private void Price_FormClosed(object sender, FormClosedEventArgs e)
        {
            price = null;
        }

        private void openInventoryBtn_Click(object sender, EventArgs e)
        {
            if (inventory == null)
            {
                inventory = new Inventory();
                inventory.FormClosed += Inventory_FormClosed;
                inventory.MdiParent = this;
                inventory.Dock = DockStyle.Fill;
                inventory.Show();
            }
            else
            {
                inventory.Activate();
            }
        }
        private void Inventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            inventory = null;
        }

        private void openRevenueBtn_Click(object sender, EventArgs e)
        {
            if (revenue == null)
            {
                revenue = new Revenue();
                revenue.FormClosed += Revenue_FormClosed;
                revenue.MdiParent = this;
                revenue.Dock = DockStyle.Fill;
                revenue.Show();
            }
            else
            {
                revenue.Activate();
            }
        }
        private void Revenue_FormClosed(object sender, FormClosedEventArgs e)
        {
            revenue = null;
        }

        private void openAccountBtn_Click(object sender, EventArgs e)
        {
            if (account == null)
            {
                account = new Account(accountDTO);
                account.FormClosed += Account_FormClosed;
                account.MdiParent = this;
                account.Dock = DockStyle.Fill;
                account.Show();
            }
            else
            {
                account.Activate();
            }
        }
        private void Account_FormClosed(object sender, FormClosedEventArgs e)
        {
            account = null;
        }

        private void openImportBtn_Click(object sender, EventArgs e)
        {
            if (import == null)
            {
                import = new Import();
                import.FormClosed += Import_FormClosed;
                import.MdiParent = this;
                import.Dock = DockStyle.Fill;
                import.Show();
            }
            else
            {
                import.Activate();
            }
        }
        private void Import_FormClosed(object sender, FormClosedEventArgs e)
        {
            import = null;
        }

        private void openAdjustmentBtn_Click(object sender, EventArgs e)
        {
            if (adjustment == null)
            {
                adjustment = new Adjustment();
                adjustment.FormClosed += Adjustment_FormClosed;
                adjustment.MdiParent = this;
                adjustment.Dock = DockStyle.Fill;
                adjustment.Show();
            }
            else
            {
                adjustment.Activate();
            }
        }
        private void Adjustment_FormClosed(object sender, FormClosedEventArgs e)
        {
            adjustment = null;
        }
        private void openConversionBtn_Click(object sender, EventArgs e)
        {
            if (conversion == null)
            {
                conversion = new Conversion();
                conversion.FormClosed += Conversion_FormClosed;
                conversion.MdiParent = this;
                conversion.Dock = DockStyle.Fill;
                conversion.Show();
            }
            else
            {
                conversion.Activate();
            }
        }
        private void Conversion_FormClosed(object sender, FormClosedEventArgs e)
        {
            conversion = null;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
