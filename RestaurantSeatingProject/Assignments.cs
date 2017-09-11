using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    class Assignments
    {
        public string ServerName    { get; set; }
        public int    ServerID      { get; set; }
        public int    TableNumber   { get; set; }
        public int    SectionNumber { get; set; }

        public Assignments()
        {
            ServerName ="";
            ServerID = 0;
            TableNumber = 0;
            SectionNumber = 0;
        }

        public Assignments(string ServerName, int ServerID, int TableNumber, int SectionNumber)
        {
            this.ServerName    = ServerName;
            this.ServerID      = ServerID;
            this.TableNumber   = TableNumber;
            this.SectionNumber = SectionNumber;
        }
    }
}

