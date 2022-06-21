using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManagementSystem.Entities;

namespace TicketManagementSystem.DAL
{
    class UserDal
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        public UserDal()
        {
            connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;database= DB_Employee;trusted_connection=true;");
        }

        public int CheckUser(UserLoginModel model)
        {
            //Checks the existence of user
            command = new SqlCommand("SP_CHECK_USER_EXISTS", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@UName", model.UserName);
            command.Parameters.AddWithValue("@Psw", model.Password);
            connection.Open();
            int count = (int)command.ExecuteScalar();
            connection.Close();
            return count;

        }
    }
}
