using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountDAL : DBConnection
    {
        public AccountDTO? ValidateLogin(UserDTO user)
        {
            try
            {
                OpenConnection();
                string role = "";
                string query = @"select role_name from ACCOUNT inner join ROLE on ACCOUNT.role_id = ROLE.role_id where username=@username and password=@password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) role = reader.GetString(0);
                if (role == "") return null;
                else
                {
                    RoleDTO r = new RoleDTO(-1, role);
                    return new AccountDTO(user.Username, "", "", "", r);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return null;
        }
        public bool UpdatePassword(string username, string password)
        {
            try
            {
                OpenConnection();
                string query = $"update ACCOUNT set password = '{password}' where username = '{username}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
        public AccountDTO? FindAccountByUsername(string username)
        {
            try
            {
                OpenConnection();
                string query = $"select fullname, phone from ACCOUNT where username = '{username}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                string fullname, phone;
                while (reader.Read())
                {
                    fullname = reader.GetString(0);
                    phone = reader.GetString(1);
                    return new AccountDTO(username, "", fullname, phone, null);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return null;
        }
        public List<AccountDTO> FindAllAccounts()
        {
            List<AccountDTO> accounts = new List<AccountDTO>();
            try
            {
                OpenConnection();
                string query = $"select username, fullname, phone, ACCOUNT.role_id, role_name from ACCOUNT inner join ROLE on ACCOUNT.role_id = ROLE.role_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                string username, fullname, phone, roleName;
                int roleID;
                while (reader.Read())
                {
                    username = reader.GetString(0);
                    fullname = reader.GetString(1);
                    phone = reader.GetString(2);
                    roleID = reader.GetInt32(3);
                    roleName = reader.GetString(4);
                    accounts.Add(new AccountDTO(username, "", fullname, phone, new RoleDTO(roleID, roleName)));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return accounts;
        }
        public bool InsertAccount(AccountDTO account)
        {
            try
            {
                OpenConnection();
                string query = $"insert into ACCOUNT(username, password, fullname, phone, role_id) values ('{account.Username}', '{account.Password}', N'{account.Fullname}', '{account.Phone}', {account.RoleDTO.RoleID})";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
        public bool IsUsernameExist(string username)
        {
            try
            {
                OpenConnection();
                string query = $"select count(username) from ACCOUNT where username='{username}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                return (int)cmd.ExecuteScalar() > 0;
            } catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return true;
        }
        public bool UpdateAccount(AccountDTO account)
        {
            try
            {
                OpenConnection();
                string query = $"update ACCOUNT set fullname=N'{account.Fullname}', phone='{account.Phone}', role_id='{account.RoleDTO.RoleID}'";
                if (account.Password != "") query += $", password='{account.Password}'";
                query += $" where username='{account.Username}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
        public bool DeleteAccount(string username)
        {
            try
            {
                OpenConnection();
                string query = $"delete from ACCOUNT where username <> 'admin' and username='{username}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
        public List<AccountDTO> FindAccountByFullnameOrPhone(string txtSearch)
        {
            List<AccountDTO> accounts = new List<AccountDTO>();
            try
            {
                OpenConnection();
                string query = $"select username, fullname, phone, ACCOUNT.role_id, role_name from ACCOUNT inner join ROLE on ACCOUNT.role_id = ROLE.role_id where fullname like N'%{txtSearch}%' or phone like '%{txtSearch}%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                string username, fullname, phone, roleName;
                int roleID;
                while (reader.Read())
                {
                    username = reader.GetString(0);
                    fullname = reader.GetString(1);
                    phone = reader.GetString(2);
                    roleID = reader.GetInt32(3);
                    roleName = reader.GetString(4);
                    accounts.Add(new AccountDTO(username, "", fullname, phone, new RoleDTO(roleID, roleName)));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return accounts;
        }
    }
}
