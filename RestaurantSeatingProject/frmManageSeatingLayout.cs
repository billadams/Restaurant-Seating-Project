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
    public partial class frmManageSeatingLayout : Form {

        private List<Table> tables = new List<Table>();
        private List<AssignedTable> oAssignedList = new List<AssignedTable>();
        AssignedTable oAssigned = null;
        Table table;
        private int xPos;
        private int yPos;
        private enum AvailableSections { Section1 = 1, Section2 = 2, Section3 = 3 };

        public frmManageSeatingLayout() {

            InitializeComponent();
            LoadTables();

        }

        private void btnCancelLayout_Click(object sender, EventArgs e) {

            Table.TotalTables = 1;
            this.Close();

        }

        private void btnAddTable_Click(object sender, EventArgs e) {

            table = new Table();
            oAssigned = new AssignedTable();
            int startLeft = pnlRoom.Left;
            int startTop = pnlRoom.Top; 

            string sErrorMess = "";
            bool bIsValid = true;

            try {
                
                table.TableNumber = Convert.ToInt32(txtTableNumber.Text);
                oAssigned.TableNumber = table.TableNumber;

                if (rdoSection1.Checked) {

                    oAssigned.SectionNum = (int)AvailableSections.Section1;

                }
                else if (rdoSection2.Checked) {

                    oAssigned.SectionNum = (int)AvailableSections.Section2;

                }
                else if (rdoSection3.Checked) {

                    oAssigned.SectionNum = (int)AvailableSections.Section3;

                }
            }
            catch (Exception)  {

                bIsValid = false;
                sErrorMess += "TableNumber is required and must be a number";
              
            }

            try {

                table.NumberOfSeats = Convert.ToInt32(txtNumberOfSeats.Text);

            }
            catch (Exception) {

                bIsValid = false;
                sErrorMess += "\nNumber of Seats is required and must be a number";
             
            }

            if (bIsValid) {

                table.TablePositionX = startLeft;
                table.TablePositionY = startTop;
                tables.Add(table);
                oAssignedList.Add(oAssigned);
                Button button = new Button();
                button.Height = 50;
                button.Text = "Table " + Convert.ToString(table.TableNumber)
                    + "\n" + Convert.ToString(table.NumberOfSeats) + " seats";
                button.Location = new Point(startLeft, startTop);
                pnlRoom.Controls.Add(button);

                button.MouseDown += button_MouseDown;
                button.MouseUp += button_MouseUp;
                button.MouseMove += button_MouseMove;

                txtTableNumber.Text = Convert.ToString(Table.TotalTables);

            }
            else {

                MessageBox.Show(sErrorMess, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        public void button_MouseDown(object sender, MouseEventArgs e) {
        
            if (e.Button == MouseButtons.Left) {
                xPos = e.X;
                yPos = e.Y;

            }
        }

        public void button_MouseMove(object sender, MouseEventArgs e) {

            Button button = (Button)sender;

            if (button != null) {

                if (e.Button == MouseButtons.Left) {
                    button.Top += (e.Y - yPos);
                    button.Left += (e.X - xPos);

                }
            }
        }

        public void button_MouseUp(object sender, MouseEventArgs e) {

            Button button = (Button)sender;
            table.TablePositionX = button.Left;
            table.TablePositionY = button.Top;

        }

        private void btnSaveLayout_Click(object sender, EventArgs e) {

            TableDA.AddTableLayout(tables);
            SectionDA.AssignTableToSection(oAssignedList);
            lblMessage.Text = "Table layout saved.";
            btnSaveLayout.Enabled = false;

        }

        private void btnDeleteLayout_Click(object sender, EventArgs e) {

            List<Table> tables = TableDA.GetTableLayout();

            if (Utility.IsNullOrEmpty(tables)) {

                MessageBox.Show("Error: Layout was not Successfully Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else {

                TableDA.DeleteLayout();
                MessageBox.Show("Table Layout was Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }

            ResetLayout();
            btnSaveLayout.Enabled = true;
        }

        private void ResetLayout() {

            //Resets the table layout as if none was created
            Table.TotalTables = 1;
            tables = new List<Table>();
            txtTableNumber.Text = "1";

            pnlRoom.Controls.Clear();

        }

        public void LoadTables() {

            List<Table> oTables = TableDA.GetTableLayout();

            if (!(Utility.IsNullOrEmpty(oTables))) {

                foreach (Table oTable in oTables) {

                    Button button = new Button();
                    button.Height = 50;
                    button.Text = "Table " + Convert.ToString(oTable.TableNumber)
                        + "\n" + Convert.ToString(oTable.NumberOfSeats) + " seats";
                    button.Location = new Point(oTable.TablePositionX, oTable.TablePositionY);
                    pnlRoom.Controls.Add(button);
                    btnSaveLayout.Enabled = false;

                }
            }
            else {

                btnSaveLayout.Enabled = true;

            }
        }  
    }
}
