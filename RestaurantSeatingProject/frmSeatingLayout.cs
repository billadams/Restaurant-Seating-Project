using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSeatingProject
{
    public partial class frmSeatingLayout : Form
    {
        public frmSeatingLayout()
        {
            InitializeComponent();
            LoadTables();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeatClick(object sender, EventArgs e)
        {
            //add seat click logic
        }

        public void LoadTables()
        {
            List<Table> oTables = TableDA.GetTableLayout();
            if (!(Utility.IsNullOrEmpty(oTables)))
            {
                foreach (Table oTable in oTables)
                {
                    //add logic in here to dynamically create and tie click event to btnseat click
                    Button button = new Button();
                    button.Height = 50;
                    button.Text = "Table " + Convert.ToString(oTable.TableNumber)
                        + "\n" + Convert.ToString(oTable.NumberOfSeats) + " seats";
                    button.Location = new Point(oTable.TablePositionX, oTable.TablePositionY);
                    pnlRoom.Controls.Add(button);
                }

            }

        }
    }
}
