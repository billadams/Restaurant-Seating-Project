namespace RestaurantSeatingProject
{
    partial class frmSeatingLayout
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
            this.pnlRoom = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBusTable = new System.Windows.Forms.RadioButton();
            this.rdoClearTable = new System.Windows.Forms.RadioButton();
            this.rdoAssignTable = new System.Windows.Forms.RadioButton();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lstServers = new System.Windows.Forms.ListBox();
            this.lblServers = new System.Windows.Forms.Label();
            this.lblNumCustomers = new System.Windows.Forms.Label();
            this.txtNumCustomers = new System.Windows.Forms.TextBox();
            this.lstReservations = new System.Windows.Forms.ListBox();
            this.lstAssignments = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUse = new System.Windows.Forms.Button();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.grpBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRoom
            // 
            this.pnlRoom.BackColor = System.Drawing.Color.DimGray;
            this.pnlRoom.Location = new System.Drawing.Point(9, 9);
            this.pnlRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlRoom.Name = "pnlRoom";
            this.pnlRoom.Size = new System.Drawing.Size(530, 548);
            this.pnlRoom.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(630, 516);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 41);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.rdoBusTable);
            this.grpBox1.Controls.Add(this.rdoClearTable);
            this.grpBox1.Controls.Add(this.rdoAssignTable);
            this.grpBox1.Location = new System.Drawing.Point(578, 317);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(195, 140);
            this.grpBox1.TabIndex = 5;
            this.grpBox1.TabStop = false;
            // 
            // rdoBusTable
            // 
            this.rdoBusTable.AutoSize = true;
            this.rdoBusTable.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.rdoBusTable.Location = new System.Drawing.Point(6, 94);
            this.rdoBusTable.Name = "rdoBusTable";
            this.rdoBusTable.Size = new System.Drawing.Size(141, 31);
            this.rdoBusTable.TabIndex = 2;
            this.rdoBusTable.Text = "Bus Table";
            this.rdoBusTable.UseVisualStyleBackColor = true;
            this.rdoBusTable.CheckedChanged += new System.EventHandler(this.rdoBusTable_CheckedChanged);
            // 
            // rdoClearTable
            // 
            this.rdoClearTable.AutoSize = true;
            this.rdoClearTable.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.rdoClearTable.Location = new System.Drawing.Point(7, 57);
            this.rdoClearTable.Name = "rdoClearTable";
            this.rdoClearTable.Size = new System.Drawing.Size(155, 31);
            this.rdoClearTable.TabIndex = 1;
            this.rdoClearTable.Text = "Clear Table";
            this.rdoClearTable.UseVisualStyleBackColor = true;
            this.rdoClearTable.CheckedChanged += new System.EventHandler(this.rdoClearTable_CheckedChanged);
            // 
            // rdoAssignTable
            // 
            this.rdoAssignTable.AutoSize = true;
            this.rdoAssignTable.Checked = true;
            this.rdoAssignTable.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.rdoAssignTable.Location = new System.Drawing.Point(7, 20);
            this.rdoAssignTable.Name = "rdoAssignTable";
            this.rdoAssignTable.Size = new System.Drawing.Size(175, 31);
            this.rdoAssignTable.TabIndex = 0;
            this.rdoAssignTable.TabStop = true;
            this.rdoAssignTable.Text = "Assign Table";
            this.rdoAssignTable.UseVisualStyleBackColor = true;
            this.rdoAssignTable.CheckedChanged += new System.EventHandler(this.rdoAssignTable_CheckedChanged);
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Arial", 11F);
            this.lblOptions.Location = new System.Drawing.Point(627, 268);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(63, 17);
            this.lblOptions.TabIndex = 6;
            this.lblOptions.Text = "Options:";
            // 
            // lstServers
            // 
            this.lstServers.FormattingEnabled = true;
            this.lstServers.Location = new System.Drawing.Point(568, 26);
            this.lstServers.Name = "lstServers";
            this.lstServers.Size = new System.Drawing.Size(160, 199);
            this.lstServers.TabIndex = 7;
            // 
            // lblServers
            // 
            this.lblServers.AutoSize = true;
            this.lblServers.Font = new System.Drawing.Font("Arial", 11F);
            this.lblServers.Location = new System.Drawing.Point(607, 4);
            this.lblServers.Name = "lblServers";
            this.lblServers.Size = new System.Drawing.Size(59, 17);
            this.lblServers.TabIndex = 8;
            this.lblServers.Text = "Servers";
            // 
            // lblNumCustomers
            // 
            this.lblNumCustomers.AutoSize = true;
            this.lblNumCustomers.Location = new System.Drawing.Point(583, 478);
            this.lblNumCustomers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumCustomers.Name = "lblNumCustomers";
            this.lblNumCustomers.Size = new System.Drawing.Size(111, 13);
            this.lblNumCustomers.TabIndex = 9;
            this.lblNumCustomers.Text = "Number of Customers:";
            // 
            // txtNumCustomers
            // 
            this.txtNumCustomers.Location = new System.Drawing.Point(699, 475);
            this.txtNumCustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumCustomers.Name = "txtNumCustomers";
            this.txtNumCustomers.Size = new System.Drawing.Size(30, 20);
            this.txtNumCustomers.TabIndex = 10;
            this.txtNumCustomers.Text = "4";
            // 
            // lstReservations
            // 
            this.lstReservations.Enabled = false;
            this.lstReservations.FormattingEnabled = true;
            this.lstReservations.Location = new System.Drawing.Point(751, 26);
            this.lstReservations.Name = "lstReservations";
            this.lstReservations.Size = new System.Drawing.Size(160, 199);
            this.lstReservations.TabIndex = 11;
            this.lstReservations.SelectedIndexChanged += new System.EventHandler(this.lstReservations_SelectedIndexChanged);
            // 
            // lstAssignments
            // 
            this.lstAssignments.FormattingEnabled = true;
            this.lstAssignments.Location = new System.Drawing.Point(821, 317);
            this.lstAssignments.Name = "lstAssignments";
            this.lstAssignments.Size = new System.Drawing.Size(327, 212);
            this.lstAssignments.TabIndex = 0;
            this.lstAssignments.SelectedIndexChanged += new System.EventHandler(this.lstAssignments_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F);
            this.label1.Location = new System.Drawing.Point(782, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reservations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F);
            this.label2.Location = new System.Drawing.Point(906, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Current Assignments";
            // 
            // btnUse
            // 
            this.btnUse.Location = new System.Drawing.Point(772, 231);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(104, 23);
            this.btnUse.TabIndex = 13;
            this.btnUse.Text = "Use Reservation";
            this.btnUse.UseVisualStyleBackColor = true;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // btnClearTable
            // 
            this.btnClearTable.Location = new System.Drawing.Point(928, 534);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(104, 23);
            this.btnClearTable.TabIndex = 14;
            this.btnClearTable.Text = "Clear Table";
            this.btnClearTable.UseVisualStyleBackColor = true;
            this.btnClearTable.Visible = false;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTable_Click);
            // 
            // frmSeatingLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 579);
            this.ControlBox = false;
            this.Controls.Add(this.btnClearTable);
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstServers);
            this.Controls.Add(this.lstReservations);
            this.Controls.Add(this.lblServers);
            this.Controls.Add(this.lstAssignments);
            this.Controls.Add(this.lblNumCustomers);
            this.Controls.Add(this.txtNumCustomers);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.grpBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlRoom);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSeatingLayout";
            this.Text = "Seating Layout";
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRoom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.RadioButton rdoBusTable;
        private System.Windows.Forms.RadioButton rdoClearTable;
        private System.Windows.Forms.RadioButton rdoAssignTable;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.ListBox lstServers;
        private System.Windows.Forms.Label lblServers;
        private System.Windows.Forms.Label lblNumCustomers;
        private System.Windows.Forms.TextBox txtNumCustomers;
        private System.Windows.Forms.ListBox lstReservations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstAssignments;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.Button btnClearTable;
    }
}