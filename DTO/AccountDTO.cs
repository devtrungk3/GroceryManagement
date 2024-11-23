using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountDTO
    {
        public string Username { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public string Phone {  get; set; } 
        public RoleDTO RoleDTO { get; set; }

        public AccountDTO(string username, string password, string fullname, string phone, RoleDTO role)
        {
            Username = username;
            Password = password;
            Fullname = fullname;
            Phone = phone;
            RoleDTO = role;
        }
    }
}
