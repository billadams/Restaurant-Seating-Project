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
            DisplayListBoxData();
            DisplayReservationList();
            DisplayAssignments();
            lstReservations.ClearSelected();
            lstAssignments.ClearSelected();
        }
        private enum TableState { Empty, Occupied, Bussable };
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    if (oSpecificTable.NumberOfSeats >= Convert.ToInt16(txtNumCustomers.Text))
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
                    
                    if (!(lstReservations.SelectedIndex == -1))
                    {
                        bReservationSelected = true;
                    }
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
                DisplayReservationList();
                DisplayAssignments();
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
                    Button button = new Button();
                    button.Height = 50;
                    //int nServerCheck = ServerDA.GetTableAssignment(oTable.TableNumber.ToString());
                    //if (nServerCheck == 0)
                    //{
                        //if no server is assigned
                        button.Text = "Table " + Convert.ToString(oTable.TableNumber) + " " + oTable.TableState
                            + "\n" + Convert.ToString(oTable.NumberOfSeats) + " seats";
                    //}
                    //else
                    //{
                    //    //if server is assigned
                    //    Server oServer = ServerDA.GetServerbyID(nServerCheck.ToString());
                    //    button.Text = "Table " + Convert.ToString(oTable.TableNumber) + " " + oTable.TableState
                    //         + "\nServer: " + oServer.FirstName;
                    //}


                    button.Location = new Point(oTable.TablePositionX, oTable.TablePositionY);
                    button.Click += new EventHandler(btnSeatClick);
                    button.Tag = oTable.TableNumber;
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
                oDataDisplay.Add(new DisplayData() { Value = oCustomer.Id.ToString(), Text = oCustomer.LastName + " " + oCustomer.ReservationTime });
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


        private void rdoAssignTable_CheckedChanged(object sender, EventArgs e)
        {
            txtNumCustomers.Visible = true;
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
            txtNumCustomers.Visible = false;
            lblNumCustomers.Visible = false;
            txtNumCustomers.Text = "1";
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
            ServerDA.FreeTable((lstAssignments.SelectedItem as DisplayData).Value);
            TableDA.UpdateTableState((lstAssignments.SelectedItem as DisplayData).Value, TableState.Bussable.ToString());            
            pnlRoom.Controls.Clear();
            DisplayAssignments();
            LoadTables();
            btnClearTable.Visible = false;
            lstAssignments.ClearSelected();
        }

    }
}
