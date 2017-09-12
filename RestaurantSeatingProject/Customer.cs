using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    class Customer : Person
    {
        public string ReservationTime { get; set; }
        public int GroupSize { get; set; }
        public Customer()
        {
            FirstName = "";

        }
        public Customer(string sReservationTime, int sGroupsize)
        {            
            this.ReservationTime = sReservationTime;
            this.GroupSize = sGroupsize;
        }
    }
}
