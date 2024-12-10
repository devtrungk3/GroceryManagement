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

namespace GUI.authentication
{
    public partial class Login : Form
    {
        private UserBUS userBUS = new UserBUS();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserDTO userDTO = new UserDTO(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            AccountDTO? accountDTO = userBUS.Login(userDTO);
            if (accountDTO == null) MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!");
            else
            {
                switch (accountDTO.RoleDTO.RoleName)
                {
                    case "ADMIN":
                        GUI.admin.Main aMain = new GUI.admin.Main(accountDTO);
                        aMain.Show();
                        this.Hide();
                        break;
                    case "INVENTORY":
                        GUI.inventory.Main iMain = new GUI.inventory.Main(accountDTO);
                        iMain.Show();
                        this.Hide();
                        break;
                    case "VENDOR":
                        GUI.vendor.Main vMain = new GUI.vendor.Main(accountDTO);
                        vMain.Show();
                        this.Hide();
                        break;
                }
            }
        }
    }
}
