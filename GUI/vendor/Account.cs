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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI.vendor
{
    public partial class Account : Form
    {
        private string username;
        private AccountBUS accBUS = new AccountBUS();
        private UserBUS userBUS = new UserBUS();
        public Account(string username)
        {
            this.username = username;
            InitializeComponent();
            this.Activated += MainForm_Activated;
        }
        private void MainForm_Activated(object sender, EventArgs e)
        {
            AccountDTO? account = accBUS.GetAccountByUsername(username);
            if (account == null) return;
            txtUsername.Text = username;
            txtFullname.Text = account.Fullname;
            txtPhone.Text = account.Phone;
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtPassword.Text == "" || txtNewPassword.Text == "" || txtReNewPass.Text == "")
            {
                MessageBox.Show("Không được bỏ trống các thông tin cần thiết");
                return;
            }
            // check new password
            if (txtReNewPass.Text != txtNewPassword.Text)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp");
                return;
            }
            // check password
            if (userBUS.Login(new UserDTO(username, txtPassword.Text)) == null)
            {
                MessageBox.Show("Mật khẩu không chính xác");
                return;
            }
            // update password in database
            string message = accBUS.ChangePassword(username, txtNewPassword.Text);
            if (message != "")
            {
                MessageBox.Show(message);
                return;
            }
            txtPassword.Text = "";
            txtNewPassword.Text = "";
            txtReNewPass.Text = "";
            MessageBox.Show("Đổi mật khẩu thành công");
        }
    }
}
