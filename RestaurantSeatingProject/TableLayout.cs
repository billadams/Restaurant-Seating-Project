using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSeatingProject {
    class TableLayout {
        private Panel roomLayout;
        private List<Table> tables = new List<Table>();
        Table table = new Table();

        public TableLayout() {

        }

        public TableLayout(Panel roomLayout) {
            this.roomLayout = roomLayout;
        }

        public Panel RoomLayout { get; set; }

        public static void Add() {
            //AddTable();
        }

        private void AddTable() {

        }
    }
}
