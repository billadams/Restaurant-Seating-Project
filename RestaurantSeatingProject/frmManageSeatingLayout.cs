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
        private List<AssignedTable> assignedList = new List<AssignedTable>();
        AssignedTable assigned = null;
        Table table;
        private int xPos;
        private int yPos;
        private enum AvailableSections { Section1 = 1, Section2 = 2, Section3 = 3 };
        // Flag for deleting a table
        bool deleteTable = false;

        public frmManageSeatingLayout() {

            InitializeComponent();
            LoadTables();
            lblMessage.Text = "";
            btnSaveLayout.Enabled = false;

        }

        private void btnCancelLayout_Click(object sender, EventArgs e) {

            Table.TotalTables = 1;
            this.Close();

        }

        private void btnAddTable_Click(object sender, EventArgs e) {

            table = new Table();
            assigned = new AssignedTable();
            int startLeft = pnlRoom.Left;
            int startTop = pnlRoom.Top; 

            string sErrorMess = "";
            bool bIsValid = true;

            try {
                
                table.TableNumber = Convert.ToInt32(txtTableNumber.Text);
                assigned.TableNumber = table.TableNumber;

                if (rdoSection1.Checked) {

                    assigned.SectionNum = (int)AvailableSections.Section1;

                }
                else if (rdoSection2.Checked) {

                    assigned.SectionNum = (int)AvailableSections.Section2;

                }
                else if (rdoSection3.Checked) {

                    assigned.SectionNum = (int)AvailableSections.Section3;

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
                assignedList.Add(assigned);
                Button button = new Button();
                button.Height = 50;
                button.Tag = table.TableNumber;
                button.Text = "Table " + Convert.ToString(table.TableNumber)
                    + "\n" + Convert.ToString(table.NumberOfSeats) + " seats";
                button.Location = new Point(startLeft, startTop);
                pnlRoom.Controls.Add(button);

                button.MouseDown += button_MouseDown;
                button.MouseUp += button_MouseUp;
                button.MouseMove += button_MouseMove;

                txtTableNumber.Text = Convert.ToString(Table.TotalTables);
                btnSaveLayout.Enabled = true;
                lblMessage.Text = "Table " + table.TableNumber + " successfully added.";

            }
            else {

                MessageBox.Show(sErrorMess, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        public void button_MouseDown(object sender, MouseEventArgs e) {

            Button button = (Button)sender;

            if (deleteTable == true) {

                string tableID = Convert.ToString(button.Tag);
                table = TableDA.GetTableByID(tableID);

                TableDA.DeleteTable(table);
                UpdateView();
                lblMessage.Text = "Table " + tableID + " successfully deleted.";

                // Set deleteTable back to false so it's ready to be used in another delete.
                deleteTable = false;

            }
            else if (e.Button == MouseButtons.Left) {

                xPos = e.X;
                yPos = e.Y;

                if (btnSaveLayout.Enabled == false) {

                    btnSaveLayout.Enabled = true;

                }

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

            int tableIndex = (Int32)button.Tag - 1;
            Table table = tables[tableIndex];
            //tables[Convert.ToInt16(button.Tag) - 1].TablePositionX = button.Left;
            //tables[Convert.ToInt16(button.Tag) - 1].TablePositionY = button.Top;

            table.TablePositionX = button.Left;
            table.TablePositionY = button.Top;

        }

        private void UpdateView() {

            pnlRoom.Controls.Clear();
            Table.TotalTables = 1;
            LoadTables();

        }

        private void btnSaveLayout_Click(object sender, EventArgs e) {

            TableDA.SaveTableLayout(tables);
            SectionDA.AssignTableToSection(assignedList);
            lblMessage.Text = "Table layout saved.";
            btnSaveLayout.Enabled = false;

        }

        private void btnDeleteLayout_Click(object sender, EventArgs e) {

            tables = TableDA.GetTableLayout();

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

            // Resets the table layout as if none was created
            Table.TotalTables = 1;
            tables = new List<Table>();
            txtTableNumber.Text = "1";

            pnlRoom.Controls.Clear();

        }

        public void LoadTables() {

            tables = TableDA.GetTableLayout();

            if (!(Utility.IsNullOrEmpty(tables))) {

                foreach (Table eachTable in tables) {

                    table = eachTable;

                    Button button = new Button();
                    button.Height = 50;
                    button.Tag = table.TableNumber;
                    button.Text = "Table " + Convert.ToString(table.TableNumber)
                        + "\n" + Convert.ToString(table.NumberOfSeats) + " seats";
                    button.Location = new Point(table.TablePositionX, table.TablePositionY);
                    pnlRoom.Controls.Add(button);

                    button.MouseDown += button_MouseDown;
                    button.MouseUp += button_MouseUp;
                    button.MouseMove += button_MouseMove;

                    btnSaveLayout.Enabled = false;

                }

                txtTableNumber.Text = Convert.ToString(Table.TotalTables);

            }
            else {

                //btnSaveLayout.Enabled = true;

            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e) {

            deleteTable = true;

        }
    }
}
