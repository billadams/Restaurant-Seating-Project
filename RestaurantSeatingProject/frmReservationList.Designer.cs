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
            this.txtGroupSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstReservationList
            // 
            this.lstReservationList.FormattingEnabled = true;
            this.lstReservationList.ItemHeight = 16;
            this.lstReservationList.Location = new System.Drawing.Point(13, 256);
            this.lstReservationList.Margin = new System.Windows.Forms.Padding(4);
            this.lstReservationList.Name = "lstReservationList";
            this.lstReservationList.Size = new System.Drawing.Size(523, 276);
            this.lstReservationList.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 10F);
            this.lblTitle.Location = new System.Drawing.Point(16, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(265, 19);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Add a New Customer to the Waitlist";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(141, 37);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(272, 22);
            this.txtLastName.TabIndex = 13;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(52, 41);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 17);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // dtpReservation
            // 
            this.dtpReservation.CustomFormat = "MM/dd/yyyy hh:mm";
            this.dtpReservation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReservation.Location = new System.Drawing.Point(141, 97);
            this.dtpReservation.Margin = new System.Windows.Forms.Padding(4);
            this.dtpReservation.Name = "dtpReservation";
            this.dtpReservation.Size = new System.Drawing.Size(265, 22);
            this.dtpReservation.TabIndex = 15;
            this.dtpReservation.ValueChanged += new System.EventHandler(this.dtpReservation_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Reservation Time:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(205, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Waitlist";
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReservation.Location = new System.Drawing.Point(160, 145);
            this.btnAddReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(164, 28);
            this.btnAddReservation.TabIndex = 18;
            this.btnAddReservation.Text = "Add Reservation";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // txtGroupSize
            // 
            this.txtGroupSize.Location = new System.Drawing.Point(141, 67);
            this.txtGroupSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtGroupSize.Name = "txtGroupSize";
            this.txtGroupSize.Size = new System.Drawing.Size(272, 22);
            this.txtGroupSize.TabIndex = 13;
            this.txtGroupSize.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Group Size:";
            this.label3.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // frmReservationList
            // 
            this.AcceptButton = this.btnAddReservation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 545);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpReservation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtGroupSize);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstReservationList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReservationList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox txtGroupSize;
        private System.Windows.Forms.Label label3;
    }
}