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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            ViewCompanyInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewCompanyInfo()
        {
            List<Restaurant> restaurantList = new List<Restaurant>();
            restaurantList = RestaurantDA.GetRestaurantInfo();
            Restaurant oRestaurant = restaurantList[0];
            lblCompanyName.Text = oRestaurant.RestaurantName;
            lblAddress.Text = oRestaurant.Address;
            lblCity.Text = oRestaurant.City;
            lblState.Text = oRestaurant.State;
            lblZip.Text = oRestaurant.Zip;
        }
    }
}
