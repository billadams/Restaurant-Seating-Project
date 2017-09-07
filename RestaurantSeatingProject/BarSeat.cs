using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
  public class BarSeat : Table
  {
    public override int NumberOfSeats
    {
      get
      {
        return 1;
      }
    }

    public BarSeat(int numberOfSeats, int tableNumber, int tablePositionX, int tablePositionY, string tableState) 
      : base(numberOfSeats, tableNumber, tablePositionX, tablePositionY, tableState)
    {
    }
  }
}
