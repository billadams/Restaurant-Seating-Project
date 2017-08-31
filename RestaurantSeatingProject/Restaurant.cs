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
    public string zip { get; set; }
        
    public Restaurant()
    {
    }
  }
}
