using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    public class AssignSection
    {
        public int sectionNum { get; set; }
        public string tableNum { get; set; }
        public AssignSection()
        {

        }

        public AssignSection(string SectionNum, string tableNum)
        {
            this.sectionNum = SectionNum;
            this.tableNum = TableNum;
        }

    }
}
