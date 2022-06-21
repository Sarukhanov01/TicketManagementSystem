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
    class CustomerDAL
    {
        public static string conString = @"Server=(localdb)\MSSQLLocalDB;Database=DB_TicketSales;trusted_connection=true;";
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader reader;
            public DataTable GetCustomer()
            {
                DataTable dt = new DataTable();
                 sqlConnection = new SqlConnection(conString);
                 sqlCommand = new SqlCommand("SP_GET_Customer", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                 reader = sqlCommand.ExecuteReader();
                dt.Load(reader);
                sqlConnection.Close();
                return dt;
            }
            public DataTable GetCustomer(int rows)
            {
            DataTable dt = new DataTable();
            sqlConnection = new SqlConnection(conString);
            sqlCommand = new SqlCommand("SP_GET_CUSTOMER_FETCH_ROWS", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@rowCount", rows);
            sqlConnection.Open();
            reader = sqlCommand.ExecuteReader();
            dt.Load(reader);
            sqlConnection.Close();
            return dt;

            }

             public int InsertCustomer(Customer customer)
             {
            sqlConnection = new SqlConnection(conString);
            sqlCommand = new SqlCommand("SP_INSERT_UPDATE_CUSTOMER", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", 0);
            sqlCommand.Parameters.AddWithValue("@FName",customer.FirstName);
            sqlCommand.Parameters.AddWithValue("@Lname", customer.LastName);
            sqlCommand.Parameters.AddWithValue("@MovieId", customer.MovieId);
            sqlCommand.Parameters.AddWithValue("@TheatreId", customer.TheatreId);
            sqlConnection.Open();
            int count = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return count;
        }
        public int UpdateCustomer(Customer customer , int id)
        {
            sqlConnection = new SqlConnection(conString);
            sqlCommand = new SqlCommand("SP_INSERT_UPDATE_CUSTOMER", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", id);
            sqlCommand.Parameters.AddWithValue("@FName", customer.FirstName);
            sqlCommand.Parameters.AddWithValue("@Lname", customer.LastName);
            sqlCommand.Parameters.AddWithValue("@MovieId", customer.MovieId);
            sqlCommand.Parameters.AddWithValue("@TheatreId", customer.TheatreId);
            sqlConnection.Open();
            int count = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return count;
        }
        public int DeleteCustomer(int id)
        {
            sqlConnection = new SqlConnection(conString);
            sqlCommand = new SqlCommand("DELETE FROM tbl_Customer WHERE Customerid = @id", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlConnection.Open();
            int result =  sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return result;
        }
    }
}
