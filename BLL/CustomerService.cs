using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManagementSystem.DAL;
using TicketManagementSystem.Entities;

namespace TicketManagementSystem.BLL
{
    class CustomerService
    {
        CustomerDAL customer ;
        public CustomerService()
        {
            customer = new CustomerDAL();
        }

        public DataTable GetCustomer()
        {
            if (customer.GetCustomer().Columns.Count > 0)
            {
                return customer.GetCustomer();
            }
            else
            {
                throw new Exception("Table does not contain any data!!");             
            }
        }
        public DataTable GetCustomer(int rowsFetch)
        {
            if (customer.GetCustomer(rowsFetch).Columns.Count > 0)
            {
                return customer.GetCustomer(rowsFetch);
            }
            else
            {
                throw new Exception("Table does not contain any data!!");
            }
        }

        public int InsertCustomer(string firstName, string lastName, int movieId, int theatreId)
        {
            if (!(string.IsNullOrEmpty(firstName)) && !(string.IsNullOrEmpty(lastName)) &&
                movieId > 0 && theatreId > 0)
            {
                return customer.InsertCustomer(new Customer
                {
                    FirstName = firstName,
                    LastName = lastName,
                    MovieId = movieId,
                    TheatreId = theatreId
                });
            }
            return 0;
        }

        public int UpdateCustomer(int id, string firstName, string lastName, int movieId, int theatreId)
        {
            if (id > 0 && !(string.IsNullOrEmpty(firstName)) && !(string.IsNullOrEmpty(lastName)) && movieId > 0 && theatreId > 0)
            {
                return customer.UpdateCustomer( new Customer 
                {LastName = lastName,
                    FirstName = firstName,
                    MovieId = movieId,
                    TheatreId = theatreId },id );
            }
            return 0;
        }

        public int DeleteCustomer(int id)
        {
            if (id > 0)
            {
                return customer.DeleteCustomer(id);
            }
            return 0;
        }
    }
}
