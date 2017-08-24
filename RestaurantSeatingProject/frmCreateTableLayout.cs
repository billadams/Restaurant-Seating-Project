using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSeatingProject {
    public partial class frmCreateTableLayout : Form {

        private ArrayList tables = new ArrayList();

        public frmCreateTableLayout() {
            InitializeComponent();
        }

        private void btnCancelLayout_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
