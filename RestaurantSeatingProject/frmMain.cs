﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSeatingProject {

    public partial class frmMain : Form {

        public frmMain() {

            InitializeComponent();
            //SectionDA.AddStaticSections();            
            //RestaurantDA.DeleteRestaurant();
            //SectionDA.DeleteSectionAssignments();
            //DeleteSectionAssignments();
            Restaurant oRestaurant = RestaurantDA.GetRestaurantInfo();
           if (oRestaurant.RestaurantID != 0) {

               //restaurant has been set
               CurrentRestaurant();
                mnuAbout.Text = "About " + oRestaurant.RestaurantName;

           }
           else {

               //if you want to force a delete of restraunt call RestaurantDA.DeleteRestaurant();
               //restaurant hasnt been set
               NoCurrentRestaurant();
               
           }
        }

        private void mnuCreateSeatingLayout_Click(object sender, EventArgs e) {

            Form createTableLayout = new frmManageSeatingLayout();
            createTableLayout.MdiParent = this;
            createTableLayout.Show();

        }

        private void mnuExit_Click(object sender, EventArgs e) {

            this.Close();

        }

        private void mnuAddServer_Click(object sender, EventArgs e) {

            Form frmAddServer = new frmAddServer();
            frmAddServer.MdiParent = this;
            frmAddServer.Show();

        }

        private void mnuRegisterRestaurant_Click(object sender, EventArgs e) {

            Form frmRegister = new frmRegister();
            frmRegister.MdiParent = this;
            frmRegister.Show();

        }

        private void mnuManageServers_Click(object sender, EventArgs e) {

            Form frmManageServers = new frmManageServers();
            frmManageServers.MdiParent = this;
            frmManageServers.Show();
        }


        private void mnuReservationList_Click(object sender, EventArgs e) {

            Form frmReservationList = new frmReservationList();
            frmReservationList.MdiParent = this;
            frmReservationList.Show();

        }

        private void NoCurrentRestaurant() {
            
            mnuAddServer.Enabled = false;
            mnuAbout.Enabled = false;
            mnuCreateSeatingLayout.Enabled = false;
            mnuManageServers.Enabled = false;
            mnuSeatingLayout.Enabled = false;
            mnuReservationList.Enabled = false;
            mnuUnregisterRestaurant.Enabled = false;

        }

        private void CurrentRestaurant() {

            mnuRegisterRestaurant.Enabled = false;

        }

        private void mnuAbout_Click(object sender, EventArgs e) {

            frmAbout oFrmAbout = new frmAbout();
            oFrmAbout.MdiParent = this;
            oFrmAbout.Show();

        }

        private void mnuSeatingLayout_Click(object sender, EventArgs e) {

            frmSeatingLayout oFrmSeatingLayout = new frmSeatingLayout();
            oFrmSeatingLayout.MdiParent = this;
            oFrmSeatingLayout.Show();

        }

        private void mnuUnregisterRestaurant_Click(object sender, EventArgs e) {

            DialogResult button =
                 MessageBox.Show(
                    "Are you sure you want to delete the entire restaurant layout?",
                    "Confirm Layout Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

            if (button == DialogResult.Yes) {

                ReservationDA.DeleteAllReservations();
                TableDA.DeleteAllTables();
                BarSeatDA.DeleteAllBarSeats();
                BarTableDA.DeleteBarTable();
                ServerDA.DeleteAllServers();
                RestaurantDA.DeleteRestaurant();

                NoCurrentRestaurant();

                if (mnuRegisterRestaurant.Enabled == false) {

                    mnuRegisterRestaurant.Enabled = true;
                }

                MessageBox.Show("Restaurant has been unregistered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }
    }
}
