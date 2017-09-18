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

            Restaurant oRestaurant = RestaurantDA.GetRestaurantInfo();
            lblCompanyName.Text = oRestaurant.RestaurantName;
            lblAddress.Text = oRestaurant.Address;
            lblCity.Text = oRestaurant.City;
            lblState.Text = oRestaurant.State;
            lblZip.Text = oRestaurant.Zip;
        }

        private void btnUnregister_Click(object sender, EventArgs e) {

            ReservationDA.DeleteAllReservations();
            TableDA.DeleteAllTables();
            BarSeatDA.DeleteAllBarSeats();
            BarTableDA.DeleteBarTable();
            ServerDA.DeleteAllServers();
            RestaurantDA.DeleteRestaurant();

        }
    }
}
