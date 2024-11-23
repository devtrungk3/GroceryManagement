using DTO;
using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Text.RegularExpressions;

namespace GUI.admin
{
    public partial class Account : Form
    {
        private AccountDTO accountDTO;
        private AccountBUS accountBUS = new AccountBUS();
        private RoleBUS roleBUS = new RoleBUS();
        private List<AccountDTO> accounts;
        public Account(AccountDTO account)
        {
            accountDTO = account;
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadRoleTable();
            LoadAccountTable();
        }

        private void LoadRoleTable()
        {
            viewRole.Rows.Clear();
            List<RoleDTO> roles = roleBUS.GetRoles();
            foreach (RoleDTO r in roles) viewRole.Rows.Add(r.RoleID, r.RoleName);
        }

        private void LoadAccountTable()
        {
            viewAccount.Rows.Clear();
            if (txtSearch.Text == "") accounts = accountBUS.GetAccounts();
            else accounts = accountBUS.SearchAccount(txtSearch.Text);
            foreach (AccountDTO a in accounts)
            {
                viewAccount.Rows.Add(a.Username, a.Fullname, a.Phone, a.RoleDTO.RoleName);
            }
        }

        private void ClearTextBox()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtFullname.Text = "";
            txtPhone.Text = "";
            txtAccountRoleID.Text = "";
        }

        private bool Validate(string username, string fullname, string phone, string roleID)
        {
            if (!Regex.IsMatch(username, @"^[a-zA-Z][a-zA-Z0-9_]{5,}$"))
            {
                MessageBox.Show("Tên đăng nhập không đúng định dạng");
                return false;
            }
            if (!Regex.IsMatch(fullname, @"^[a-zA-ZÀ-ỹà-ỹ ]+$"))
            {
                MessageBox.Show("Họ tên không đúng định dạng");
                return false;
            }
            if (!Regex.IsMatch(phone, @"^[0-9]{10,15}$"))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng");
                return false;
            }
            if (!Regex.IsMatch(roleID, @"^-?\d+$"))
            {
                MessageBox.Show("Mã vai trò không đúng định dạng");
                return false;
            }
            return true;
        }
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtFullname.Text == "" || txtPhone.Text == "" || txtAccountRoleID.Text == "")
            {
                MessageBox.Show("Không được để trống các thông tin cần thiết");
                return;
            }
            // check format
            if (!Validate(txtUsername.Text, txtFullname.Text, txtPhone.Text, txtAccountRoleID.Text)) return;

            // insert into database
            string message = accountBUS.InsertAccount(new AccountDTO(txtUsername.Text, txtPassword.Text, txtFullname.Text, txtPhone.Text, new RoleDTO(int.Parse(txtAccountRoleID.Text), "")));
            if (message == "")
            {
                ClearTextBox();
                LoadAccountTable();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtUsername.Text == "" || txtFullname.Text == "" || txtPhone.Text == "" || txtAccountRoleID.Text == "")
            {
                MessageBox.Show("Không được để trống các thông tin cần thiết");
                return;
            }
            // check format
            if (!Validate(txtUsername.Text, txtFullname.Text, txtPhone.Text, txtAccountRoleID.Text)) return;

            //update in database
            string message = accountBUS.UpdateAccount(new AccountDTO(txtUsername.Text, txtPassword.Text, txtFullname.Text, txtPhone.Text, new RoleDTO(int.Parse(txtAccountRoleID.Text), "")));
            if (message == "")
            {
                ClearTextBox();
                LoadAccountTable();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void viewAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int position = e.RowIndex;
            if (position < 0) return;
            txtUsername.Text = accounts[position].Username;
            txtFullname.Text = accounts[position].Fullname;
            txtPhone.Text = accounts[position].Phone;
            txtAccountRoleID.Text = accounts[position].RoleDTO.RoleID.ToString();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            // check empty
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản muốn xóa");
                return;
            }
            // show confirmation message before deleting
            DialogResult dialog = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản [{txtUsername.Text}] không?", "Xác nhận xóa tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog != DialogResult.Yes) return;
            // delete from database
            string message = accountBUS.DeleteAccount(txtUsername.Text);
            if (message == "")
            {
                ClearTextBox();
                LoadAccountTable();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadAccountTable();
        }
    }
}
