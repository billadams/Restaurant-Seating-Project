using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
  public class Server : Person
  {
    private string employeeID;

    public Server()
    {
      EmployeeID = "";
    }

    public Server(int id, string firstName, string lastName, string employeeID)
      : base(id, firstName, lastName)
    {                    
      this.EmployeeID = employeeID; 
    }

    public string EmployeeID
    {
      get
      {
        return employeeID;
      }

      set
      {
        employeeID = value;
      }
    }
  }
}
