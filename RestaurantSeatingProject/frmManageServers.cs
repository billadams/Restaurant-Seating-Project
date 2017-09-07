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
    public partial class frmManageServers : Form
    {
       

        public frmManageServers()
        {
            InitializeComponent();
            DisplayListBoxData();
        }

        private void lstServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(lstServers.SelectedIndex == -1))
            {
                btnDeleteServer.Enabled = true;
            }
            else
            {
                btnDeleteServer.Enabled = false;
            }
        }

        private void btnDeleteServer_Click(object sender, EventArgs e)
        {
            string sID = (lstServers.SelectedItem as DisplayData).Value;
            int nSuccess = ServerDA.DeleteServer(sID);
            if (nSuccess == 1)
            {
                MessageBox.Show("Server Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //1 row deleted
                DisplayListBoxData();
            }
            else
            {
                //no row deleted
                MessageBox.Show("Error: Server was not deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
