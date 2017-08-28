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
    public partial class frmAddServer : Form
    {
        public frmAddServer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {
            string sFirstName = txtFirstName.Text.Trim();
            string sLastName = txtLastName.Text.Trim();
            string sErrorMess = "";
            Server oServer = new Server();
            bool bIsValid = true;


            if (String.IsNullOrEmpty(sFirstName))
            {
                bIsValid = false;
                sErrorMess += "Please enter a First Name";
            }
            if (String.IsNullOrEmpty(sLastName))
            {
                bIsValid = false;
                sErrorMess += "\nPlease enter a Last Name";
            }



            //valid input
            if(bIsValid)
            {
                //add server to database
                oServer.FirstName = sFirstName;
                oServer.LastName = sLastName;

                //Might need to come back and add a try catch here
                ServerDA.AddServer(oServer);
                
            }
            else
            {
                MessageBox.Show(sErrorMess, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
