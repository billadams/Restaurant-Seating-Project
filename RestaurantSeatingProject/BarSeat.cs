using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject {

    public class BarSeat : BarObject {

        public string TableState { get; set; }

        private static int totalTables = 1;

        public override int NumberOfSeats {

            get { return 1; }

        }

        public BarSeat() {

            this.TableNumber = 0;
            this.TablePositionX = 0;
            this.TablePositionY = 0;
            this.TableState = "Empty";
            TotalTables++;

        }

        public BarSeat(int tableNumber, int tablePositionX, int tablePositionY, string tableState)
            : base(tableNumber, tablePositionX, tablePositionY) {

            this.TableNumber = tableNumber;
            this.TablePositionX = tablePositionX;
            this.TablePositionY = tablePositionY;
            this.TableState = tableState;
            TotalTables++;

        }

        public static int TotalTables {

            get { return totalTables; }
            set { totalTables = value; }

        }
    }
}
