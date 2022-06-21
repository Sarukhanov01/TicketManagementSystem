using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagementSystem.Entities
{
    class Customer
    {
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public int MovieId { get; set; }
        public int TheatreId { get; set; }
    }
}
