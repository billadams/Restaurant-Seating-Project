using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject {
    public class Table {

        public int NumberOfSeats { get; set; }
        public int TableNumber { get; set; }
        public int TablePositionX { get; set; }
        public int TablePositionY { get; set; }

        public Table() {

        }

        public Table(int numberOfSeats, int tableNumber, int tablePositionX, int tablePositionY ) {
            this.NumberOfSeats = numberOfSeats;
            this.TableNumber = tableNumber;
            this.TablePositionX = tablePositionX;
            this.TablePositionY = tablePositionY;
        }
    }
}
