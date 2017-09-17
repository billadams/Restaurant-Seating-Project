using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject {
    public class BarObject {

        public int TableNumber { get; set; }

        public virtual int NumberOfSeats { get; set; }

        public int TablePositionX { get; set; }

        public int TablePositionY { get; set; }

        //protected static int totalTables = 1;

        public BarObject() { }

        public BarObject(int numberOfSeats, int tableNumber, int tablePositionX, int tablePositionY) {

            this.NumberOfSeats = numberOfSeats;
            this.TableNumber = tableNumber;
            this.TablePositionX = tablePositionX;
            this.TablePositionY = tablePositionY;
            
        }

        public BarObject(int tableNumber, int tablePositionX, int tablePositionY) {

            this.TableNumber = tableNumber;
            this.TablePositionX = tablePositionX;
            this.TablePositionY = tablePositionY;

        }

    }
}
