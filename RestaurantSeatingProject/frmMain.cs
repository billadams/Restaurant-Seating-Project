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
        }

        private void mnuCreateSeatingLayout_Click(object sender, EventArgs e) {
            Form createTableLayout = new frmCreateTableLayout();
            createTableLayout.MdiParent = this;
            createTableLayout.Show();
        }
    }
}
