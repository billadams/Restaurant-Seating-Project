using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject {
    public class Table {

        public int TableNumber { get; set; }

        public int NumberOfSeats { get; set; }

        public int TablePositionX { get; set; }

        public int TablePositionY { get; set; }
        public string TableState { get; set; }
        private static int totalTables = 1;

        public Table() {

            this.NumberOfSeats = 0;
            this.TableNumber = 0;
            this.TablePositionX = 0;
            this.TablePositionY = 0;
            this.TableState = "Empty";
            TotalTables++;

        }

        public Table(int numberOfSeats, int tableNumber, int tablePositionX, int tablePositionY, string tableState) {

            this.NumberOfSeats = numberOfSeats;
            this.TableNumber = tableNumber;
            this.TablePositionX = tablePositionX;
            this.TablePositionY = tablePositionY;
            this.TableState = tableState;
            TotalTables++;

        }

        public static int TotalTables {

            get { return totalTables; }
            set { totalTables = value;  }
        }
    }
}
