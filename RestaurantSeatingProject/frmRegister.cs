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
            string sUserName = txtUserName.Text.Trim();
            string sErrorMess = "";
            Restaurant oRestaurant = new Restaurant();
            bool bIsValid = true;


            if (String.IsNullOrEmpty(sRestaurantName))
            {
                bIsValid = false;
                sErrorMess += "Please enter a Restaurant Name";
            }
            if (String.IsNullOrEmpty(sUserName))
            {
                bIsValid = false;
                sErrorMess += "\nPlease enter a Username to reference this restaurant";
            }

            //DB call to check if username is taken
            //if taken bIsValid = false and append to errormessage \nThat UserName is taken Please pick another one
           
            //valid input
            if (bIsValid)
            {
                //add Restaurant to database
                oRestaurant.RestaurantName = sRestaurantName;
                oRestaurant.UserName = sUserName;

                //db logic here to insert into database

                //Success
                MessageBox.Show(oRestaurant.RestaurantName + "Has been Added!" + "\nYour username is : " + oRestaurant.UserName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(sErrorMess, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
