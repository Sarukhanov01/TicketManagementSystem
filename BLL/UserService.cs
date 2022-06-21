using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManagementSystem.DAL;
using TicketManagementSystem.Entities;

namespace TicketManagementSystem.BLL
{
    class UserService
    {
        UserDal userDal;
        public UserService()
        {
            userDal = new UserDal();
        }
        public int LoginService(string userName, string pass)
        {
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(pass))
            {
                UserLoginModel model = new UserLoginModel();
                model.UserName = userName;
                model.Password = pass;
                return userDal.CheckUser(model);
            }
            return 0;
        }
    }
}
