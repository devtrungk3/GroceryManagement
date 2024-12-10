using DTO;
using GUI.admin;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GUI.inventory
{
    public partial class Main : Form
    {
        private Dashboard? dashboard;
        private Import? import;
        private Purchase? purchase;
        private Adjustment? adjustment;
        private Profile? profile;
        private AccountDTO account;
        public Main(AccountDTO account)
        {
            this.account = account;
            InitializeComponent();
        }

        private void openDashboardBtn_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new Dashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dashboard = new Dashboard();
            dashboard.FormClosed += Dashboard_FormClosed;
            dashboard.MdiParent = this;
            dashboard.Dock = DockStyle.Fill;
            dashboard.Show();
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

        private void openProfileBtn_Click(object sender, EventArgs e)
        {
            if (profile == null)
            {
                profile = new Profile(account.Username);
                profile.FormClosed += Profile_FormClosed;
                profile.MdiParent = this;
                profile.Dock = DockStyle.Fill;
                profile.Show();
            }
            else
            {
                profile.Activate();
            }
        }
        private void Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            profile = null;
        }

        private void openPurchaseBtn_Click(object sender, EventArgs e)
        {
            if (purchase == null)
            {
                purchase = new Purchase();
                purchase.FormClosed += Purchase_FormClosed;
                purchase.MdiParent = this;
                purchase.Dock = DockStyle.Fill;
                purchase.Show();
            }
            else
            {
                purchase.Activate();
            }
        }
        private void Purchase_FormClosed(object sender, FormClosedEventArgs e)
        {
            purchase = null;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
