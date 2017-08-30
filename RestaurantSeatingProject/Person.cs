using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
  class Person
  {
    private int    id;
    private string firstName;
    private string lastName;

    public Person()
    {
      id =         0;
      firstName = "";
      lastName =  "";
    }

    public Person(int id, string firstName, string lastName)
    {
       this.id =        id;
       this.firstName = firstName;
       this.lastName =  lastName;
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
