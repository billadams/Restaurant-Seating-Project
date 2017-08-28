using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    class Restaurant
    {
        //COULD add password if we need to later so people can't mess with other people's stuff
        public string RestaurantName { get; set; }
        public string UserName { get; set; }
        public Restaurant()
        {

        }

        public Restaurant(string sRestaurantName, string sUserName)
        {
            this.RestaurantName = sRestaurantName;
            this.UserName = sUserName;
        }
    }
}
