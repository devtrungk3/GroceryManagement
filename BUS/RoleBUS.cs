using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class RoleBUS
    {
        RoleDAL roleDAL = new RoleDAL();
        public List<RoleDTO> GetRoles()
        {
            return roleDAL.FindAllRoles();
        }
    }
}
