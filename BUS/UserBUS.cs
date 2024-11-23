using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class UserBUS
    {
        private AccountDAL accountDAL = new AccountDAL();
        public AccountDTO? Login(UserDTO user)
        {
            return accountDAL.ValidateLogin(user);
        }
    }
}
