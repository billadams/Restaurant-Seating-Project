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
           // List<AssignedTable> oAssigned = SectionDA.GetAssignedTables();
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
            //get table by id to check/update state
            Table oSpecificTable = TableDA.GetTableByID(sTableNumber);
            int nSectionNumber = SectionDA.GetAssignedSection(sTableNumber);
            if (!(lstServers.SelectedIndex == -1))
            {
                //makes sure a server is selected in the list box
                if (rdoAssignTable.Checked)
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
                            sErrorMess = "Error: Table is clean";
                        }
                    }
                    else
                    {
                        bIsValid = false;
                        sErrorMess = "Error: That table cannot seat that many customers";
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
            }
            else
            {
                bIsValid = false;
                sErrorMess = "Error: You have to select a server";
            }

            if (bIsValid)
            {
                string sUpdatedState = oSpecificTable.TableState;
                if (sUpdatedState.ToLower() == TableState.Empty.ToString().ToLower())
                {
                    //assign server here
                    string sServerID = (lstServers.SelectedItem as DisplayData).Value;
                    ServerDA.AssignServerToTable(sTableNumber,sServerID,nSectionNumber.ToString());
                    

                    sUpdatedState = TableState.Occupied.ToString();
                }
                else if (sUpdatedState.ToLower() == TableState.Occupied.ToString().ToLower())
                {
                    ServerDA.FreeTable(sTableNumber);
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
                    int nServerCheck = ServerDA.GetTableAssignment(oTable.TableNumber.ToString());
                    if (nServerCheck == 0)
                    {
                        //if no server is assigned
                        button.Text = "Table " + Convert.ToString(oTable.TableNumber) + " " + oTable.TableState
                            + "\n" + Convert.ToString(oTable.NumberOfSeats) + " seats";
                    }
                    else{
                        //if server is assigned
                        Server oServer = ServerDA.GetServerbyID(nServerCheck.ToString());
                        button.Text = "Table " + Convert.ToString(oTable.TableNumber) + " " + oTable.TableState
                             + "\nServer: " +oServer.FirstName;
                    }


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
    }
}
