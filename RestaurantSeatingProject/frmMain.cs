using System;
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
        }

        private void mnuCreateSeatingLayout_Click(object sender, EventArgs e) {
            Form createTableLayout = new frmCreateTableLayout();
            createTableLayout.MdiParent = this;
            createTableLayout.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void mnuAddServer_Click(object sender, EventArgs e)
        {
            Form frmAddServer = new frmAddServer();
            frmAddServer.MdiParent = this;
            frmAddServer.Show();
        }

        private void mnuRegisterRestaurant_Click(object sender, EventArgs e)
        {
            Form frmRegister = new frmRegister();
            frmRegister.MdiParent = this;
            frmRegister.Show();
        }
    }
}
