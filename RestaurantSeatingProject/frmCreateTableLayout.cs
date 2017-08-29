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
        Table table = new Table();
        private Point mouseDownLocation;
        private bool capturingMoves = false;

        public frmCreateTableLayout() {
            InitializeComponent();
        }

        private void btnCancelLayout_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAddTable_Click(object sender, EventArgs e) {
            int startLeft = pnlRoom.Left;
            int startTop = pnlRoom.Top;
            string sErrorMess = "";
            bool bIsValid = true;

            try
            {
                table.TableNumber = Convert.ToInt32(txtTableNumber.Text);
            }
            catch (Exception)
            {

                bIsValid = false;
                sErrorMess += "TableNumber is required and must be a number";
              
            }

            try
            {
                table.NumberOfSeats = Convert.ToInt32(txtNumberOfSeats.Text);
            }
            catch (Exception)
            {
                bIsValid = false;
                sErrorMess += "\nNumber of Seats is required and must be a number";
             
            }

            if (bIsValid)
            {
                table.TablePositionX = startLeft;
                table.TablePositionY = startTop;
                tables.Add(table);

                Button button = new Button();
                button.Height = 50;
                button.Text = "Table " + Convert.ToString(table.TableNumber)
                    + "\n" + Convert.ToString(table.NumberOfSeats) + " seats";
                button.Location = new Point(startLeft, startTop);
                button.Click += new EventHandler(TableHandler);
                button.AllowDrop = true;
                pnlRoom.Controls.Add(button);

                button.MouseDown += button_MouseDown;
                button.MouseUp += button_MouseUp;
                button.MouseMove += button_MouseMove;
                pnlRoom.DragEnter += panel_DragEnter;
                pnlRoom.DragDrop += panel_DragDrop;

            }
            else
            {
                MessageBox.Show(sErrorMess, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TableHandler(object sender, EventArgs e) {

        }

        public void button_MouseDown(object sender, MouseEventArgs e) {

            Button button = (Button)sender;

            if (e.Button != MouseButtons.Left)
                return;

            // Might want to pad these values a bit if the line is only 1px,
            // might be hard for the user to hit directly
            if (e.Y >= button.Top && e.Y <= button.Top + button.Height) {
                if (e.X >= button.Left && e.X <= button.Left + button.Width) {
                    capturingMoves = true;
                    return;
                }
            }

            capturingMoves = false;
        }

        public void button_MouseMove(object sender, MouseEventArgs e) {
            if (!capturingMoves)
                return;

            // Calculate the delta's and move the line here
            Button button = (Button)sender;
            button.Left = Cursor.Position.X;
            button.Top = Cursor.Position.Y;

        }

        public void button_MouseUp(object sender, MouseEventArgs e) {
            if (capturingMoves) {
                capturingMoves = false;
                // Do any final placement
            }
        }

        //public void button_MouseDown(object sender, MouseEventArgs e) {

        //    Button button = (Button)sender;
        //    button.DoDragDrop(button, DragDropEffects.Move);
        //    mouseDownLocation = e.Location;
        //}

        //public void button_MouseUp(object sender, MouseEventArgs e) {
        //    Button button = (Button)sender;
        //    button.Left = e.X + button.Left - mouseDownLocation.X;
        //    button.Top = e.Y + button.Top - mouseDownLocation.Y;
        //}

        //public void button_MouseMove(object sender, MouseEventArgs e) {
        //    Button button = (Button)sender;
            //button.Left += button.Left;
            //button.Top += button.Top;
            //button.Left = e.X + button.Left - mouseDownLocation.X;
            //button.Top = e.Y + button.Top - mouseDownLocation.Y;
        //}

        public void panel_DragEnter(object sender, DragEventArgs e) {

            e.Effect = DragDropEffects.Move;
        }

        public void panel_DragDrop(object sender, DragEventArgs e) {

            ((Button)e.Data.GetData(typeof(Button))).Parent = (Panel)sender;
        }
    }
}
