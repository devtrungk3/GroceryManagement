using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AccountBUS
    {
        AccountDAL accountDAL = new AccountDAL();
        RoleDAL roleDAL = new RoleDAL();
        public List<AccountDTO> GetAccounts()
        {
            return accountDAL.FindAllAccounts();
        }
        public AccountDTO? GetAccountByUsername(string username)
        {
            return accountDAL.FindAccountByUsername(username);
        }
        public string ChangePassword(string username, string password)
        {
            if (accountDAL.UpdatePassword(username, password)) return "";
            return "Đổi mật khẩu thất bại";
        }
        public string InsertAccount(AccountDTO account)
        {
            if (accountDAL.IsUsernameExist(account.Username)) return "Tên tài khoản đã tồn tại";
            if (!roleDAL.IsRoleIDExist(account.RoleDTO.RoleID)) return "Mã vai trò không tồn tại";
            if (accountDAL.InsertAccount(account)) return "";
            else return "Tạo tài khoản thất bại";
        }

        public string UpdateAccount(AccountDTO account)
        {
            if (!accountDAL.IsUsernameExist(account.Username)) return "Tên tài khoản không tồn tại";
            if (!roleDAL.IsRoleIDExist(account.RoleDTO.RoleID)) return "Mã vai trò không tồn tại";
            if (accountDAL.UpdateAccount(account)) return "";
            else return "Cập nhật tài khoản thất bại";
        }
        public string DeleteAccount(string username)
        {
            if (!accountDAL.IsUsernameExist(username)) return "Tên tài khoản không tồn tại";
            if (accountDAL.DeleteAccount(username)) return "";
            else return "Xóa tài khoản thất bại";
        }
        public List<AccountDTO> SearchAccount(string txtSearch)
        {
            return accountDAL.FindAccountByFullnameOrPhone(txtSearch);
        }
    }
}
