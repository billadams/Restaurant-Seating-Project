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
            LoadBarTable();
            LoadBarSeats();
            DisplayListBoxData();
            DisplayReservationList();
            DisplayAssignments();
            DisplayAvailableTables();
            lstReservations.ClearSelected();
            lstAssignments.ClearSelected();
        }
        private enum TableState { Empty, Occupied, Bussable };
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBarSeatClick(object sender, EventArgs e)
        {
            Button oButton = sender as Button;
            string sTableNumber = oButton.Tag.ToString();
            string sErrorMess = "";
            bool bIsValid = true;
            bool bReservationSelected = false;
        }
        private void btnSeatClick(object sender, EventArgs e)
        {
            Button oButton = sender as Button;
            string sTableNumber = oButton.Tag.ToString();
            string sErrorMess = "";
            bool bIsValid = true;
            bool bReservationSelected = false;
            //get table by id to check/update state
            Table oSpecificTable = TableDA.GetTableByID(sTableNumber);
            int nSectionNumber = SectionDA.GetAssignedSection(sTableNumber);
            
            if (rdoAssignTable.Checked)
            {                
                //makes sure a server is selected in the list box
                if (!(lstServers.SelectedIndex == -1))
                {
                    
                    try
                    {
                        Convert.ToInt32(cboSeats.SelectedItem);                       
                    }
                    catch (Exception)
                    {

                        bIsValid = false;
                        sErrorMess += "\nNumber of Seats is required and must be a number";
                    }

                    if(bIsValid){
                        if (!(lstReservations.SelectedIndex == -1))
                        {
                            bReservationSelected = true;
                            int groupSize = ReservationDA.GetGroupSize((lstReservations.SelectedItem as DisplayData).Value);
                            cboSeats.SelectedItem = groupSize.ToString();
                        }
                        if (cboSeats.SelectedItem == null)
                        {
                            bIsValid = false;
                            sErrorMess += "Number of seats must be provided";
                        }
                    if (oSpecificTable.NumberOfSeats >= Convert.ToInt16(cboSeats.SelectedItem) && bIsValid)
                    {
                        //Number of seats fit the amount to be seated
                        if (oSpecificTable.TableState.ToLower() == TableState.Occupied.ToString().ToLower())
                        {
                            bIsValid = false;
                            sErrorMess = "Error: Table is currently busy";
                        }
                        else if (oSpecificTable.TableState.ToLower() == TableState.Bussable.ToString().ToLower())
                        {
                            bIsValid = false;
                            sErrorMess = "Error: Table is not clean";
                        }

                    }
                    else
                    {
                        bIsValid = false;
                        sErrorMess = "Error: That table cannot seat that many customers";
                    }
                }
                   
                }
                else
                {
                    bIsValid = false;
                    sErrorMess = "Error: You have to select a server";
                }
            }
            else if (rdoClearTable.Checked)
            {
                if (oSpecificTable.TableState.ToLower() == TableState.Empty.ToString().ToLower())
                {
                    bIsValid = false;
                    sErrorMess = "Error: Table has nothing to clear";
                }
                else if (oSpecificTable.TableState.ToLower() == TableState.Bussable.ToString().ToLower())
                {
                    bIsValid = false;
                    sErrorMess = "Error: Table is not clean";
                }
            }
            else if (rdoBusTable.Checked)
            {
                if (oSpecificTable.TableState.ToLower() == TableState.Empty.ToString().ToLower())
                {
                    bIsValid = false;
                    sErrorMess = "Error: Table is already clean";
                }
                else if (oSpecificTable.TableState.ToLower() == TableState.Occupied.ToString().ToLower())
                {
                    bIsValid = false;
                    sErrorMess = "Error: Table is currently busy";
                }
            }

            if (bIsValid)
            {
                string sUpdatedState = oSpecificTable.TableState;
                if (sUpdatedState.ToLower() == TableState.Empty.ToString().ToLower())
                {
                    //assign server here
                    
                    string sServerID = (lstServers.SelectedItem as DisplayData).Value;
                    ServerDA.AssignServerToTable(sTableNumber, sServerID, nSectionNumber.ToString());
                    
                    if (bReservationSelected)
                    {                        
                        ReservationDA.DeleteReservation((lstReservations.SelectedItem as DisplayData).Value);
                        lstReservations.ClearSelected();
                    }
                    sUpdatedState = TableState.Occupied.ToString();
                }
                else if (sUpdatedState.ToLower() == TableState.Occupied.ToString().ToLower())
                {
                    ServerDA.FreeTable(sTableNumber);
                    DisplayAssignments();
                    sUpdatedState = TableState.Bussable.ToString();
                }
                else if (sUpdatedState.ToLower() == TableState.Bussable.ToString().ToLower())
                {
                    sUpdatedState = TableState.Empty.ToString();
                }

                //Updating Table State
                TableDA.UpdateTableState(oSpecificTable.TableNumber.ToString(), sUpdatedState);                
                pnlRoom.Controls.Clear();
                LoadTables();
                LoadBarTable();
                LoadBarSeats();
                DisplayReservationList();
                DisplayAssignments();
                DisplayAvailableTables();
                if (btnUse.Text == "Cancel")
                {
                    lstReservations.Enabled = false;
                    btnUse.Text = "Use Reservation";
                }
            }
            else
            {
                MessageBox.Show(sErrorMess, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void LoadTables()
        {
            List<Table> oTables = TableDA.GetTableLayout();
            if (!(Utility.IsNullOrEmpty(oTables)))
            {
                foreach (Table oTable in oTables)
                {
                    RoundButton button = new RoundButton();
                    button.Cursor = Cursors.Hand;
                    button.Height = 50;
                    button.Width = 50;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    if (oTable.TableState == TableState.Empty.ToString())
                    {
                        button.BackColor = Color.Cyan;
                    }
                    else if (oTable.TableState == TableState.Occupied.ToString())
                    {
                        button.BackColor = Color.Red;
                    }
                    else if (oTable.TableState == TableState.Bussable.ToString())
                    {
                        button.BackColor = Color.Yellow;
                    }                    
                    button.Tag = oTable.TableNumber;
                    button.Text = "#"+Convert.ToString(oTable.TableNumber) +" "+ Convert.ToString(oTable.NumberOfSeats)
                        + "\n" + oTable.TableState;
                    button.Location = new Point(oTable.TablePositionX, oTable.TablePositionY);
                    //pnlRoom.Controls.Add(button);

                    //Button button = new Button();
                    //button.Height = 50;
                    //int nServerCheck = ServerDA.GetTableAssignment(oTable.TableNumber.ToString());
                    //if (nServerCheck == 0)
                    //{
                        //if no server is assigned
                        //button.Text = "Table " + Convert.ToString(oTable.TableNumber) + " " + oTable.TableState
                            //+ "\n" + Convert.ToString(oTable.NumberOfSeats) + " seats";
                    //}
                    //else
                    //{
                    //    //if server is assigned
                    //    Server oServer = ServerDA.GetServerbyID(nServerCheck.ToString());
                    //    button.Text = "Table " + Convert.ToString(oTable.TableNumber) + " " + oTable.TableState
                    //         + "\nServer: " + oServer.FirstName;
                    //}


                    //button.Location = new Point(oTable.TablePositionX, oTable.TablePositionY);
                    button.Click += new EventHandler(btnSeatClick);
                    //button.Tag = oTable.TableNumber;
                    pnlRoom.Controls.Add(button);
                }

            }

        }
        public void LoadBarTable()
        {
            BarTable oBarTable = BarTableDA.GetBarTableLayout();
            if (oBarTable != null)
            {
                Button button = new StayInsideButton();
                button.Cursor = Cursors.Hand;
                button.Height = 30;
                button.Width = 200;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.BackColor = Color.Cyan;
                button.Tag = oBarTable;
                button.Text = "Bar";
                button.Location = new Point(oBarTable.TablePositionX, oBarTable.TablePositionY);
                pnlRoom.Controls.Add(button);
            }
        }
        public void LoadBarSeats()
        {
            List<BarSeat> oBarSeats = BarSeatDA.GetBarSeatLayout();
            if (!(Utility.IsNullOrEmpty(oBarSeats)))
            {
                foreach (BarSeat oBarSeat in oBarSeats)
                {
                    RoundButton button = new RoundButton();
                    button.Cursor = Cursors.Hand;
                    button.Height = 30;
                    button.Width = 30;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    if (oBarSeat.TableState == TableState.Empty.ToString())
                    {
                        button.BackColor = Color.Cyan;
                    }
                    else if (oBarSeat.TableState == TableState.Occupied.ToString())
                    {
                        button.BackColor = Color.Red;
                    }
                    else if (oBarSeat.TableState == TableState.Bussable.ToString())
                    {
                        button.BackColor = Color.Yellow;
                    }    
                    button.Tag = oBarSeat.TableNumber;
                    button.Text = "B" + Convert.ToString(oBarSeat.TableNumber);
                    button.Location = new Point(oBarSeat.TablePositionX, oBarSeat.TablePositionY);
                    button.Click += new EventHandler(btnBarSeatClick);
                    pnlRoom.Controls.Add(button);
                }

            }

        }
        private void DisplayListBoxData()
        {
            List<Server> oServers = ServerDA.GetAllServers();


            List<DisplayData> oDataDisplay = new List<DisplayData>();

            foreach (Server oServer in oServers)
            {
                oDataDisplay.Add(new DisplayData() { Value = oServer.Id.ToString(), Text = oServer.FirstName + " " + oServer.LastName });
            }
            lstServers.DisplayMember = "Text";
            lstServers.DataSource = oDataDisplay;
        }
        private void DisplayReservationList()
        {
            List<Customer> oReservationList = ReservationDA.GetReservationList();


            List<DisplayData> oDataDisplay = new List<DisplayData>();

            foreach (Customer oCustomer in oReservationList)
            {
                oDataDisplay.Add(new DisplayData() { Value = oCustomer.Id.ToString(), Text = oCustomer.LastName + " Group Size:" + oCustomer.GroupSize + " " + oCustomer.ReservationTime });
            }
            lstReservations.DisplayMember = "Text";
            lstReservations.DataSource = oDataDisplay;
            lstReservations.ClearSelected();

        }

        private void DisplayAssignments()
        {
            List<Assignments> oAssignments = ServerDA.GetAllTableAssignments();
                List<DisplayData> oDataDisplay = new List<DisplayData>();
                foreach (Assignments oAssignment in oAssignments)
                {

                    Server oServer = ServerDA.GetServerbyID(oAssignment.ServerID.ToString());
                    oAssignment.ServerName = oServer.FirstName + " " + oServer.LastName;

                    oDataDisplay.Add(new DisplayData() { Value = oAssignment.TableNumber.ToString(), Text = "Section: " + oAssignment.SectionNumber + " Table: " + oAssignment.TableNumber +" Server: " + oAssignment.ServerName });
                }
                lstAssignments.DisplayMember = "Text";
                lstAssignments.DataSource = oDataDisplay;
                lstAssignments.ClearSelected();
                
        }

        private void DisplayAvailableTables()
        {
            List<Table> oTables = TableDA.GetAvailableTables();
            List<DisplayData> oDataDisplay = new List<DisplayData>();
            foreach (Table oTable in oTables)
            {
                oDataDisplay.Add(new DisplayData() { Value = oTable.TableNumber.ToString(), Text = "Table Number: " + oTable.TableNumber + " Seats: "  + oTable.NumberOfSeats});
            }
            lstAvailable.DisplayMember = "Text";
            lstAvailable.DataSource = oDataDisplay;
            lstAvailable.ClearSelected();

        }


        private void rdoAssignTable_CheckedChanged(object sender, EventArgs e)
        {
            cboSeats.Visible = true;
            lblNumCustomers.Visible = true;
        }

        private void rdoClearTable_CheckedChanged(object sender, EventArgs e)
        {
            NotAssigningCustomer();
        }

        private void rdoBusTable_CheckedChanged(object sender, EventArgs e)
        {
            NotAssigningCustomer();
        }

        private void NotAssigningCustomer()
        {
            cboSeats.Visible = false;
            lblNumCustomers.Visible = false;
            //txtNumCustomers.Text = "1";
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            string s = btnUse.Text;
            if (btnUse.Text == "Use Reservation")
            {
                lstReservations.Enabled = true;
                btnUse.Text = "Cancel";
            }
            else
            {
                btnUse.Text = "Use Reservation";
                lstReservations.Enabled = false;
                lstReservations.ClearSelected();
            }

            
        }

        private void lstAssignments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(lstAssignments.SelectedIndex == -1))
            {
                btnClearTable.Visible = true;
            }
            else
            {
                btnClearTable.Visible = false;
            }
        }

        private void btnClearTable_Click(object sender, EventArgs e)
        {
            //clear table from assigned table list
            foreach (var item in lstAssignments.SelectedItems)
            {
                ServerDA.FreeTable(((DisplayData)item).Value);
                TableDA.UpdateTableState(((DisplayData)item).Value, TableState.Bussable.ToString());    
            }
                   
            pnlRoom.Controls.Clear();
            DisplayAssignments();
            DisplayAvailableTables();
            LoadTables();
            LoadBarTable();
            LoadBarSeats();
            btnClearTable.Visible = false;
            lstAssignments.ClearSelected();
        }

        private void lstReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(lstAssignments.SelectedIndex == -1))
            {
                
            }
        }

        private void lstAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(lstAvailable.SelectedIndex == -1))
            {
                btnMerge.Visible = true;
            }
            else
            {
                btnMerge.Visible = false;
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            bool bIsValid = true;
            string sErrorMess = "";
            if (!(lstServers.SelectedIndex == -1))
            {
                if (!(lstAvailable.SelectedIndex == -1))
                {
                    List<Table> oTables = new List<Table>();
                    int seatNum = 0;
                    bool bReservationSelected = false;
                    foreach (var item in lstAvailable.SelectedItems)
                    {
                        Table oTable = new Table();
                        string sAssign = ((DisplayData)item).Value;
                        oTable = TableDA.GetTableByID(sAssign);
                        oTables.Add(oTable);
                    }
                    foreach (Table oTable in oTables)
                    {
                        seatNum += oTable.NumberOfSeats;
                    }
                    if (!(lstReservations.SelectedIndex == -1))
                    {
                        bReservationSelected = true;
                        int groupSize = ReservationDA.GetGroupSize((lstReservations.SelectedItem as DisplayData).Value);
                        cboSeats.SelectedItem = groupSize.ToString();
                    }
                    if (cboSeats.SelectedItem == null)
                    {
                        bIsValid = false;
                        
                    }
                    if (seatNum >= Convert.ToInt16(cboSeats.SelectedItem) && bIsValid)
                    {
                        //assign here
                        foreach (Table oTable in oTables)
                        {
                            string sServerID = (lstServers.SelectedItem as DisplayData).Value;
                            int nSectionNumber = SectionDA.GetAssignedSection(oTable.TableNumber.ToString());
                            ServerDA.AssignServerToTable(oTable.TableNumber.ToString(), sServerID, nSectionNumber.ToString());
                            TableDA.UpdateTableState(oTable.TableNumber.ToString(), TableState.Occupied.ToString());

                        }
                        if (bReservationSelected)
                        {
                            ReservationDA.DeleteReservation((lstReservations.SelectedItem as DisplayData).Value);
                            lstReservations.ClearSelected();
                        }
                        pnlRoom.Controls.Clear();
                        LoadTables();
                        LoadBarTable();
                        LoadBarSeats();
                        DisplayReservationList();
                        DisplayAssignments();
                        DisplayAvailableTables();

                    }
                    else
                    {
                        bIsValid = false;
                        if (cboSeats.SelectedItem == null)
                        {
                            sErrorMess += "Error: Number of seats must be provided";
                        }
                        else
                        {
                            sErrorMess += "Error: Those tables cannot seat that many customers";
                        }
                        
                    }
                }
                else
                {
                    bIsValid = false;
                    sErrorMess = "Error: No tables selected to merge";
                }
            }
            else
            {
                bIsValid = false;
                sErrorMess = "Error: Those tables cannot seat that many customers";
            }

            if (!bIsValid)
            {
                MessageBox.Show(sErrorMess, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
