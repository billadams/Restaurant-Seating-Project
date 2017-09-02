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
    public partial class frmReservationList : Form
    {
        public frmReservationList()
        {
            InitializeComponent();
            DisplayListBoxData();
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            string sErrorMess = "";
            string sLastName = txtLastName.Text;
            string sReservationDate = dtpReservation.Value.ToString();
            bool bIsValid = true;

            if (String.IsNullOrEmpty(sLastName))
            {
                bIsValid = false;
                sErrorMess = "Last Name is Required for Reservation";
            }
            if(String.IsNullOrEmpty(sReservationDate))
            {
                bIsValid = false;
                sErrorMess = "\nReservation Date is Required for Reservation";
            }
            if (bIsValid)
            {
                //add reservation
                Customer oCustomer = new Customer();
                oCustomer.LastName = sLastName;
                oCustomer.ReservationTime = sReservationDate;
                ReservationDA.AddReservation(oCustomer);
                MessageBox.Show(oCustomer.LastName + " Has been Added to the Wait List!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayListBoxData();
            }
            else
            {
                MessageBox.Show(sErrorMess, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }

        private void DisplayListBoxData()
        {
            List<Customer> oReservationList = ReservationDA.GetReservationList();


            List<DisplayData> oDataDisplay = new List<DisplayData>();

            foreach (Customer oCustomer in oReservationList)
            {
                oDataDisplay.Add(new DisplayData() { Value = oCustomer.Id.ToString(), Text = oCustomer.LastName + " " + oCustomer.ReservationTime });
            }
            lstReservationList.DisplayMember = "Text";
            lstReservationList.DataSource = oDataDisplay;

        }
    }
}
