using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSeatingProject {
    public partial class frmEditTableLayout : Form {
        public frmEditTableLayout() {
            InitializeComponent();
            LoadTables();
        }


        public void LoadTables()
        {
            List<Table> oTables = TableDA.GetTableLayout();

            foreach (Table oTable in oTables)
            {
                Button button = new Button();
                button.Height = 50;
                button.Text = "Table " + Convert.ToString(oTable.TableNumber)
                    + "\n" + Convert.ToString(oTable.NumberOfSeats) + " seats";
                button.Location = new Point(oTable.TablePositionX, oTable.TablePositionY);
                pnlRoom.Controls.Add(button);
            }

        }

        private void btnCancelLayout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
