using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSeatingProject {
    public partial class frmCreateTableLayout : Form {

        private ArrayList tables = new ArrayList();
        Table table = new Table();

        public frmCreateTableLayout() {
            InitializeComponent();
        }

        private void btnCancelLayout_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAddTable_Click(object sender, EventArgs e) {
            int startLeft = pnlTableLayout.Left;
            int startTop = pnlTableLayout.Top;
            string sErrorMess = "";
            bool bIsValid = true;

            try
            {
                table.TableNumber = Convert.ToInt32(txtTableNumber.Text);
            }
            catch (Exception)
            {

                bIsValid = false;
                sErrorMess += "TableNumber is required and must be a number";
              
            }

            try
            {
                table.NumberOfSeats = Convert.ToInt32(txtNumberOfSeats.Text);
            }
            catch (Exception)
            {
                bIsValid = false;
                sErrorMess += "\nNumber of Seats is required and must be a number";
             
            }

            if (bIsValid)
            {
                table.TablePositionX = startLeft;
                table.TablePositionY = startTop;
                tables.Add(table);

                Button button = new Button();
                button.Height = 50;
                button.Text = "Table " + Convert.ToString(table.TableNumber)
                    + "\n" + Convert.ToString(table.NumberOfSeats) + " seats";
                button.Location = new Point(startLeft, startTop);
                button.Click += new EventHandler(TableHandler);
                pnlTableLayout.Controls.Add(button);
            }
            else
            {
                MessageBox.Show(sErrorMess, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TableHandler(object sender, EventArgs e) {

        }

        private void frmCreateTableLayout_Load(object sender, EventArgs e)
        {

        }

        private void pnlTableLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
