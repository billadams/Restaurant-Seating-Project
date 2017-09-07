using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
  public class Person
  {
    private int    id;
    private string firstName;
    private string lastName;

    public Person()
    {
      Id =         0;
      FirstName = "";
      LastName =  "";
    }

    public Person(int id, string firstName, string lastName)
    {
       this.Id =        id;
       this.FirstName = firstName;
       this.LastName =  lastName;
    }

    public int Id
    {
      get
      {
        return id;
      }

      set
      {
        id = value;
      }
    }

    public string FirstName
    {
      get
      {
        return firstName;
      }

      set
      {
        firstName = value;
      }
    }

    public string LastName
    {
      get
      {
        return lastName;
      }

      set
      {
        lastName = value;
      }
    }
  }
}
