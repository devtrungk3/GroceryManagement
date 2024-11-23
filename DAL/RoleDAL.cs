using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoleDAL: DBConnection
    {
        public List<RoleDTO> FindAllRoles()
        {
            List<RoleDTO> roles = new List<RoleDTO>();
            try
            {
                OpenConnection();
                string query = "select role_id, role_name from ROLE";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int roleId;
                string roleName;
                while (reader.Read())
                {
                    roleId = reader.GetInt32(0);
                    roleName = reader.GetString(1);
                    roles.Add(new RoleDTO(roleId, roleName));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return roles;
        }
        public bool IsRoleIDExist(int roleID)
        {
            try
            {
                OpenConnection();
                string query = $"select count(role_id) from ROLE where role_id={roleID}";
                SqlCommand cmd = new SqlCommand(query, conn);
                return (int)cmd.ExecuteScalar() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return true;
        }
    }
}
