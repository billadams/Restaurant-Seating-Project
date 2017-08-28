using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    class Server
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Server()
        {

        }

        public Server(string sFirstName, string sLastName)
        {
            this.FirstName = sFirstName;
            this.LastName = sLastName;
        }
    }
}
