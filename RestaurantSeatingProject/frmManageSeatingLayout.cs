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
        private List<BarSeat> barSeats = new List<BarSeat>();
        private List<AssignedTable> assignedList = new List<AssignedTable>();
        AssignedTable assigned = null;
        Table table;
        BarTable barTable;
        BarSeat barSeat;
        private int xPos;
        private int yPos;
        private enum AvailableSections { Section1 = 1, Section2 = 2, Section3 = 3 };
        // Flag for deleting a table
        bool deleteTable = false;
        bool deleteBarSeat = false;
        bool deleteBar = false;

        public frmManageSeatingLayout() {

            InitializeComponent();
            LoadTables();
            lblMessage.Text = "";
            btnSaveLayout.Enabled = false;
            cboSeats.SelectedIndex = 0;
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

                table.NumberOfSeats = Convert.ToInt32(cboSeats.SelectedItem);
                //table.NumberOfSeats = Convert.ToInt32(txtNumberOfSeats.Text);

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
                RoundButton button = new RoundButton();
                button.Cursor = Cursors.Hand;
                button.Height = 50;
                button.Width = 50;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.BackColor = Color.Cyan;
                button.Tag = table;
                button.Text = Convert.ToString(table.TableNumber)
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

                table = (Table) button.Tag;
                string tableNumber = Convert.ToString(table.TableNumber);
                table = TableDA.GetTableByID(tableNumber);

                TableDA.DeleteTable(table);
                UpdateView();
                lblMessage.Text = "Table " + tableNumber + " successfully deleted.";

                // Set deleteTable back to false so it's ready to be used in another delete.
                deleteTable = false;

            }
            else if (deleteBarSeat == true) {

                barSeat = (BarSeat) button.Tag;
                string barSeatNumber = Convert.ToString(barSeat.TableNumber);
                //barSeat = BarSeatDA.GetBarSeatByID(barSeatNumber);

                //BarSeatDA.DeleteBarSeata(barSeat);
                UpdateView();
                lblMessage.Text = "BarSeat " + barSeatNumber + " successfully deleted.";

                // Set deleteBarSeat back to false so it's ready to be used in another delete.
                deleteBarSeat = false;

            }
            else if (deleteBar == true) {

                barTable = (BarTable)button.Tag;

                //BarTableDA.DeleteBarTable(barTable);
                UpdateView();
                lblMessage.Text = "Bar successfully deleted.";

                // Set deleteBar back to false so it's ready to be used in another delete.
                deleteBar = false;

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

            BarObject barObject = (BarObject) button.Tag;

            if (barObject != null && barObject is BarTable) {

                // Get positioning.
                BarTable barTable = (BarTable)button.Tag;
                barTable.TablePositionX = button.Left;
                barTable.TablePositionY = button.Top;

            }
            else if (barObject != null && barObject is Table) {

                // Get positioning.
                Table table = (Table)button.Tag;
                int tableNumber = table.TableNumber;
                table = tables[tableNumber - 1];

                //int tableIndex = (Int32)button.Tag - 1;
                //Table table = tables[tableIndex];

                table.TablePositionX = button.Left;
                table.TablePositionY = button.Top;

            }
            else if (barObject != null && barObject is BarSeat) {

                // Get positioning.
                BarSeat barSeat = (BarSeat)button.Tag;
                int barSeatNumber = barSeat.TableNumber;
                barSeat = barSeats[barSeatNumber - 1];

            }
        }

        private void UpdateView() {

            pnlRoom.Controls.Clear();
            Table.TotalTables = 1;
            LoadTables();

        }

        private void btnSaveLayout_Click(object sender, EventArgs e) {

            TableDA.SaveTableLayout(tables);
            SectionDA.AssignTableToSection(assignedList);
            lblMessage.Text = "Restaurant layout saved.";
            btnSaveLayout.Enabled = false;

        }

        private void btnDeleteLayout_Click(object sender, EventArgs e) {

            DialogResult button =
                MessageBox.Show(
                    "Are you sure you want to delete the entire restaurant layout?",
                    "Confirm Layout Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

            if (button == DialogResult.Yes) {

                DeleteLayout();

            }
        }

        public void DeleteLayout() {

            tables = TableDA.GetTableLayout();

            if (Utility.IsNullOrEmpty(tables)) {

                MessageBox.Show("Error: Layout was not Successfully Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else {

                TableDA.DeleteLayout();
                lblMessage.Text = "Restaurant layout was successfully deleted.";

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

            // Load Tables
            tables = TableDA.GetTableLayout();

            if (!(Utility.IsNullOrEmpty(tables))) {

                foreach (Table eachTable in tables) {

                    table = eachTable;

                    RoundButton button = new RoundButton();
                    button.Cursor = Cursors.Hand;
                    button.Height = 50;
                    button.Width = 50;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = Color.Cyan;
                    button.Tag = table;
                    button.Text = Convert.ToString(table.TableNumber)
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

            // Load BarSeats



            // Load BarTable


        }

        private void btnDeleteTable_Click(object sender, EventArgs e) {

            deleteTable = true;

        }

        private void btnCreateBar_Click(object sender, EventArgs e) {

            barTable = new BarTable();
            //assigned = new AssignedTable();
            int startLeft = pnlRoom.Left;
            int startTop = pnlRoom.Top;

            barTable.TablePositionX = startLeft;
            barTable.TablePositionY = startTop;
            //tables.Add(table);
            //assignedList.Add(assigned);
            Button button = new Button();
            button.Height = 30;
            button.Width = 200;
            button.Tag = barTable;
            button.Text = "Bar";
            //button.Text = "Table " + Convert.ToString(table.TableNumber)
            //    + "\n" + Convert.ToString(table.NumberOfSeats) + " seats";
            button.Location = new Point(startLeft, startTop);
            pnlRoom.Controls.Add(button);

            button.MouseDown += button_MouseDown;
            button.MouseUp += button_MouseUp;
            button.MouseMove += button_MouseMove;

            //txtTableNumber.Text = Convert.ToString(Table.TotalTables);
            btnSaveLayout.Enabled = true;
            lblMessage.Text = "Bar was successfully added.";

            //string sErrorMess = "";
            //bool bIsValid = true;

            //try {

                //barTable.TableNumber = Convert.ToInt32(txtTableNumber.Text);E
                //assigned.TableNumber = table.TableNumber;

                //if (rdoSection1.Checked) {

                //    assigned.SectionNum = (int)AvailableSections.Section1;

                //}
                //else if (rdoSection2.Checked) {

                //    assigned.SectionNum = (int)AvailableSections.Section2;

                //}
                //else if (rdoSection3.Checked) {

                //    assigned.SectionNum = (int)AvailableSections.Section3;

                //}
            //}
            //catch (Exception) {

            //    bIsValid = false;
            //    sErrorMess += "TableNumber is required and must be a number";

            //}

            //try {

            //    table.NumberOfSeats = Convert.ToInt32(txtNumberOfSeats.Text);

            //}
            //catch (Exception) {

            //    bIsValid = false;
            //    sErrorMess += "\nNumber of Seats is required and must be a number";

            //}

            //if (bIsValid) {

                //barTable.TablePositionX = startLeft;
                //barTable.TablePositionY = startTop;
                ////tables.Add(table);
                ////assignedList.Add(assigned);
                //Button button = new Button();
                //button.Height = 20;
                //button.Width = 150;
                //button.Tag = table;
                //button.Text = "Table " + Convert.ToString(table.TableNumber)
                //    + "\n" + Convert.ToString(table.NumberOfSeats) + " seats";
                //button.Location = new Point(startLeft, startTop);
                //pnlRoom.Controls.Add(button);

                //button.MouseDown += button_MouseDown;
                //button.MouseUp += button_MouseUp;
                //button.MouseMove += button_MouseMove;

                //txtTableNumber.Text = Convert.ToString(Table.TotalTables);
                //btnSaveLayout.Enabled = true;
                //lblMessage.Text = "Table " + table.TableNumber + " successfully added.";

            //}
            //else {

            //    MessageBox.Show(sErrorMess, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //}
        }

        private void btnAddBarSeat_Click(object sender, EventArgs e) {

            barSeat = new BarSeat();
            assigned = new AssignedTable();
            int startLeft = pnlRoom.Left;
            int startTop = pnlRoom.Top;

            string sErrorMess = "";
            bool bIsValid = true;

            try {

                barSeat.TableNumber = Convert.ToInt32(txtBearSeatNumber.Text);
                assigned.TableNumber = barSeat.TableNumber;

            }
            catch (Exception) {

                bIsValid = false;
                sErrorMess += "TableNumber is required and must be a number";

            }

            try {

                barSeat.NumberOfSeats = Convert.ToInt32(txtNumberOfSeats.Text);

            }
            catch (Exception) {

                bIsValid = false;
                sErrorMess += "\nNumber of Seats is required and must be a number";

            }

            if (bIsValid) {

                barSeat.TablePositionX = startLeft;
                barSeat.TablePositionY = startTop;
                barSeats.Add(barSeat);
                assignedList.Add(assigned);
                Button button = new Button();
                button.Height = 30;
                button.Width = 30;
                button.Tag = barSeat;
                button.Text = "B" + Convert.ToString(barSeat.TableNumber);
                button.Location = new Point(startLeft, startTop);
                pnlRoom.Controls.Add(button);

                button.MouseDown += button_MouseDown;
                button.MouseUp += button_MouseUp;
                button.MouseMove += button_MouseMove;

                txtBearSeatNumber.Text = Convert.ToString(BarSeat.TotalTables);
                btnSaveLayout.Enabled = true;
                lblMessage.Text = "BarSeat " + barSeat.TableNumber + " successfully added.";

            }
            else {

                MessageBox.Show(sErrorMess, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void btnDeleteBarseat_Click(object sender, EventArgs e) {

            deleteBarSeat = true;

        }

        private void btnDeleteBar_Click(object sender, EventArgs e) {

            deleteBar = true;

        }
    }
}
