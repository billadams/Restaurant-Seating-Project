using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
  public class Restaurant
  {
    public int RestaurantID { get; set; }
    public string RestaurantName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
        
    public Restaurant()
    {
      RestaurantID = 0;
      RestaurantName = "";
      Address = "";
      City = "";
      State = "";
      Zip = "";
    }

    public Restaurant(int restaurantID, string restaurantName, string address, string city, string state, string zip)
    {
      RestaurantID = restaurantID;
      RestaurantName = restaurantName;
      Address = address;
      City = city;
      State = state;
      Zip = zip;
    }
  }
}
