using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    class AssignedTable
    {
        public int TableNumber { get; set; }

        public int SectionNum { get; set; }

        public AssignedTable() { }

        public AssignedTable(int tableNumber, int sectionNum) {

            this.TableNumber = tableNumber;
            this.SectionNum = sectionNum;

        }
    }
}
