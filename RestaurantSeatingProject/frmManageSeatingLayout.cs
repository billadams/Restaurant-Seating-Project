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
using System.IO;

namespace RestaurantSeatingProject {
    public partial class frmManageSeatingLayout : Form {
 
        private List<Table> tables = new List<Table>();
        private List<BarSeat> barSeats = new List<BarSeat>();
        private List<AssignedTable> assignedList = new List<AssignedTable>();
        AssignedTable assigned = null;
        Table table;
        BarTable barTable;
        BarSeat barSeat;
        private enum AvailableSections { Section1 = 1, Section2 = 2, Section3 = 3 };
        // Flag for deleting a table
        bool deleteTable = false;
        bool deleteBarSeat = false;
        bool deleteBar = false;
        Point mouseDnPt;


        public frmManageSeatingLayout() {

            InitializeComponent();
            lblMessage.Text = "";
            LoadTables();
            btnSaveLayout.Enabled = false;
            cboSeats.SelectedIndex = 0;
            StayInsideButton.SetPanelSize(pnlRoom.Size);
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

                //xPos = e.X;
                //yPos = e.Y;

                mouseDnPt = pnlRoom.PointToClient(button.PointToScreen(e.Location));
 
                if (btnSaveLayout.Enabled == false) {

                    btnSaveLayout.Enabled = true;

                }

            }
        }

        public void button_MouseMove(object sender, MouseEventArgs e) {

            StayInsideButton button = (StayInsideButton)sender;

            if (button != null) {

                if (e.Button == MouseButtons.Left) {

                    BarObject barObject = (BarObject)button.Tag;

                    if (barObject != null)
                    {
                      Point mouseMovePt = pnlRoom.PointToClient(button.PointToScreen(e.Location));

                      button.CheckSetLocation(barObject.TablePositionX + (mouseMovePt.X - mouseDnPt.X),
                          barObject.TablePositionY + (mouseMovePt.Y - mouseDnPt.Y));
                    }
                }
            }
        }

        public void button_MouseUp(object sender, MouseEventArgs e)
        {

            Button button = (Button)sender;

            BarObject barObject = (BarObject) button.Tag;

            // The following code down to, but not including the uncommented  if(barObject != null)
            // was the original code before it was modified to implement collision protection.

            //if (barObject != null && barObject is BarTable) {

            //    // Get positioning.
            //    BarTable barTable = (BarTable)button.Tag;
            //    barTable.TablePositionX = button.Left;
            //    barTable.TablePositionY = button.Top;

            //}
            //else if (barObject != null && barObject is Table) {

            //    // Get positioning.
            //    Table table = (Table)button.Tag;
            //    int tableNumber = table.TableNumber;
            //    table = tables[tableNumber - 1];

            //    //int tableIndex = (Int32)button.Tag - 1;
            //    //Table table = tables[tableIndex];

            //    table.TablePositionX = button.Left;
            //    table.TablePositionY = button.Top;

            //}
            //else if (barObject != null && barObject is BarSeat) {

            //    // Get positioning.
            //    BarSeat barSeat = (BarSeat)button.Tag;
            //    int barSeatNumber = barSeat.TableNumber;
            //    barSeat = barSeats[barSeatNumber - 1];

            //}

            if (barObject != null)
            {
                // Get positioning.

                if (IsCollision(button))
                {
                  // If the table, barseat, or bar has been dropped on top of another
                  // table, barseat, or bar, set its position back to the position it was being dragged from

                  button.Left = barObject.TablePositionX;
                  button.Top = barObject.TablePositionY;
                }
                else
                {
                  // If the table, barseat, or bar has been dropped on an empty area of the panel,
                  // set the record of its position that will be saved to the database to the position where it was dropped.

                  barObject.TablePositionX = button.Left;
                  barObject.TablePositionY = button.Top;
                }
            }
        }


        // IsCollision() will return true if its argument has been dropped on another table, barseat, or bar
        //
        bool IsCollision(Button button)
        {
            bool bCollision = false;
            Rectangle rctButton = button.Bounds;

            foreach (Control control in pnlRoom.Controls)
            {
              // We are going to look at each control on the panel.  They should all be derived from StayInsideButton.

              if(control != null && control is StayInsideButton)
              {
                  // button is the control we just dropped and which we are checking if we dropped it on another control.
                  // It would always appear to intersect with itself so we must not check it.

                  if (control != button) 
                  {
                      Button chkButton = (Button)control;                  
                      Rectangle rctChkButton = chkButton.Bounds;

                      if(rctButton.IntersectsWith(rctChkButton))
                      {
                        bCollision = true;
                        break;
                      }
                  }
              }
            }

            return bCollision;
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

                }

                txtTableNumber.Text = Convert.ToString(Table.TotalTables);

            }

            // Load BarSeats - uncomment when BarSeatDA complete.
            //barSeats = BarSeatDA.GetBarSeatLayout();

            //if (!(Utility.IsNullOrEmpty(barSeats))) {

            //    foreach (BarSeat eachBarSeat in barSeats) {

            //        barSeat = eachBarSeat;

            //        RoundButton button = new RoundButton();
            //        button.Cursor = Cursors.Hand;
            //        button.Height = 30;
            //        button.Width = 30;
            //        button.FlatStyle = FlatStyle.Flat;
            //        button.FlatAppearance.BorderSize = 0;
            //        button.BackColor = Color.Cyan;
            //        button.Tag = barSeat;
            //        button.Text = "B" + Convert.ToString(barSeat.TableNumber);
            //        button.Location = new Point(table.TablePositionX, table.TablePositionY);
            //        pnlRoom.Controls.Add(button);

            //        button.MouseDown += button_MouseDown;
            //        button.MouseUp += button_MouseUp;
            //        button.MouseMove += button_MouseMove;

            //    }

            //    txtBearSeatNumber.Text = Convert.ToString(BarSeat.TotalTables);

            //}

            // Load BarTable - uncomment when BarTableDA complete.
            //barTable = BarTable.GetBarTableLayout();

            //if (!(Utility.IsNullOrEmpty(barTable))) {

            //    Button button = new Button();
            //    button.Cursor = Cursors.Hand;
            //    button.Height = 30;
            //    button.Width = 200;
            //    button.FlatStyle = FlatStyle.Flat;
            //    button.FlatAppearance.BorderSize = 0;
            //    button.BackColor = Color.Cyan;
            //    button.Tag = barTable;
            //    button.Text = "Bar";
            //    button.Location = new Point(barTable.TablePositionX, barTable.TablePositionY);
            //    pnlRoom.Controls.Add(button);

            //    button.MouseDown += button_MouseDown;
            //    button.MouseUp += button_MouseUp;
            //    button.MouseMove += button_MouseMove;

            //}

            lblMessage.Text = "Seating layout successfully loaded!";

        }

        private void btnDeleteTable_Click(object sender, EventArgs e) {

            deleteTable = true;

        }

        private void btnCreateBar_Click(object sender, EventArgs e) {

            barTable = new BarTable();
            int startLeft = pnlRoom.Left;
            int startTop = pnlRoom.Top;

            barTable.TablePositionX = startLeft;
            barTable.TablePositionY = startTop;

            Button button = new StayInsideButton();  
            button.Cursor = Cursors.Hand;
            button.Height = 30;
            button.Width = 200;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Color.Cyan;
            button.Tag = barTable;
            button.Text = "Bar";
            button.Location = new Point(startLeft, startTop);
            pnlRoom.Controls.Add(button);

            button.MouseDown += button_MouseDown;
            button.MouseUp += button_MouseUp;
            button.MouseMove += button_MouseMove;

            btnSaveLayout.Enabled = true;
            lblMessage.Text = "Bar was successfully added.";

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
                RoundButton button = new RoundButton();
                button.Cursor = Cursors.Hand;
                button.Height = 30;
                button.Width = 30;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.BackColor = Color.Cyan;
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
