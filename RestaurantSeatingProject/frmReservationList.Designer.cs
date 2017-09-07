namespace RestaurantSeatingProject
{
    partial class frmReservationList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstReservationList = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.dtpReservation = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstReservationList
            // 
            this.lstReservationList.FormattingEnabled = true;
            this.lstReservationList.Location = new System.Drawing.Point(15, 146);
            this.lstReservationList.Name = "lstReservationList";
            this.lstReservationList.Size = new System.Drawing.Size(393, 225);
            this.lstReservationList.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 10F);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(228, 16);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Add a New Customer to the Waitlist";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(106, 30);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(205, 20);
            this.txtLastName.TabIndex = 13;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(39, 33);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name:";
            // 
            // dtpReservation
            // 
            this.dtpReservation.CustomFormat = "MM/dd/yyyy hh:mm";
            this.dtpReservation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReservation.Location = new System.Drawing.Point(111, 57);
            this.dtpReservation.Name = "dtpReservation";
            this.dtpReservation.Size = new System.Drawing.Size(200, 20);
            this.dtpReservation.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Reservation Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(151, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Waitlist";
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Location = new System.Drawing.Point(117, 83);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(123, 23);
            this.btnAddReservation.TabIndex = 18;
            this.btnAddReservation.Text = "Add Reservation";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // frmReservationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 395);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpReservation);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstReservationList);
            this.Name = "frmReservationList";
            this.Text = "Reservation List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstReservationList;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.DateTimePicker dtpReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddReservation;
    }
}