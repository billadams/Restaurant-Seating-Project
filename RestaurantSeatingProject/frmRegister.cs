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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string sRestaurantName = txtRName.Text.Trim();
            string sAddress = txtAddress.Text.Trim();
            string sCity = txtCity.Text.Trim();
            string sState = txtState.Text.Trim();
            string sZip = txtZip.Text.Trim();
            string sErrorMess = "";
            Restaurant oRestaurant = new Restaurant();
            bool bIsValid = true;


            if (String.IsNullOrEmpty(sRestaurantName))
            {
                bIsValid = false;
                sErrorMess += "Please enter a Restaurant Name";
            }
            if (String.IsNullOrEmpty(sAddress))
            {
                bIsValid = false;
                sErrorMess += "\nPlease enter an address";
            }
            if (String.IsNullOrEmpty(sCity))
            {
                bIsValid = false;
                sErrorMess += "\nPlease enter a city";
            }
            if (String.IsNullOrEmpty(sState))
            {
                bIsValid = false;
                sErrorMess += "\nPlease enter a state";
            }
            if (String.IsNullOrEmpty(sZip))
            {
                bIsValid = false;
                sErrorMess += "\nPlease enter a zip code";
            }
           
            //valid input
            if (bIsValid)
            {
                //add Restaurant to database
                oRestaurant.RestaurantName = sRestaurantName;
                oRestaurant.Address = sAddress;
                oRestaurant.City = sCity;
                oRestaurant.State = sState;
                oRestaurant.Zip = sZip;

                //db logic here to insert into database
                RestaurantDA.AddRestaurant(oRestaurant);
                //Success                             
                MessageBox.Show(oRestaurant.RestaurantName + " Has been Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Deletes Table Layout because new restaurant
                TableDA.DeleteAllTables();
                //Possibly try to find another way to refresh the main form to re run the code to check if restraunt is initialized
                Application.Restart();
                
                
            }
            else
            {
                MessageBox.Show(sErrorMess, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            txtRName.Focus();
        }
    }
}
