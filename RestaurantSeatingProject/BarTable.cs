using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject {
    class BarTable : BarObject {

        public BarTable() { }

        public BarTable(int tableNumber, int tablePositionX, int tablePositionY) 
            : base(tableNumber, tablePositionX, tablePositionY) {

            this.TableNumber = tableNumber;
            this.TablePositionX = tablePositionX;
            this.TablePositionY = tablePositionY;

        }
    }
}
