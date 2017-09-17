﻿namespace RestaurantSeatingProject
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
            this.lstServers = new System.Windows.Forms.ListBox();
            this.lblNumCustomers = new System.Windows.Forms.Label();
            this.txtNumCustomers = new System.Windows.Forms.TextBox();
            this.lstReservations = new System.Windows.Forms.ListBox();
            this.lstAssignments = new System.Windows.Forms.ListBox();
            this.btnUse = new System.Windows.Forms.Button();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.lstAvailable = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabaServers = new System.Windows.Forms.TabPage();
            this.tabReservations = new System.Windows.Forms.TabPage();
            this.tabAvailableTables = new System.Windows.Forms.TabPage();
            this.tabAssignedTables = new System.Windows.Forms.TabPage();
            this.grpBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabaServers.SuspendLayout();
            this.tabReservations.SuspendLayout();
            this.tabAvailableTables.SuspendLayout();
            this.tabAssignedTables.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRoom
            // 
            this.pnlRoom.BackColor = System.Drawing.Color.DimGray;
            this.pnlRoom.Location = new System.Drawing.Point(12, 11);
            this.pnlRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRoom.Name = "pnlRoom";
            this.pnlRoom.Size = new System.Drawing.Size(707, 674);
            this.pnlRoom.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(922, 635);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 50);
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
            this.grpBox1.Location = new System.Drawing.Point(863, 390);
            this.grpBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBox1.Size = new System.Drawing.Size(260, 172);
            this.grpBox1.TabIndex = 5;
            this.grpBox1.TabStop = false;
            // 
            // rdoBusTable
            // 
            this.rdoBusTable.AutoSize = true;
            this.rdoBusTable.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.rdoBusTable.Location = new System.Drawing.Point(8, 116);
            this.rdoBusTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoBusTable.Name = "rdoBusTable";
            this.rdoBusTable.Size = new System.Drawing.Size(172, 38);
            this.rdoBusTable.TabIndex = 2;
            this.rdoBusTable.Text = "Bus Table";
            this.rdoBusTable.UseVisualStyleBackColor = true;
            this.rdoBusTable.CheckedChanged += new System.EventHandler(this.rdoBusTable_CheckedChanged);
            // 
            // rdoClearTable
            // 
            this.rdoClearTable.AutoSize = true;
            this.rdoClearTable.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.rdoClearTable.Location = new System.Drawing.Point(9, 70);
            this.rdoClearTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoClearTable.Name = "rdoClearTable";
            this.rdoClearTable.Size = new System.Drawing.Size(190, 38);
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
            this.rdoAssignTable.Location = new System.Drawing.Point(9, 25);
            this.rdoAssignTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoAssignTable.Name = "rdoAssignTable";
            this.rdoAssignTable.Size = new System.Drawing.Size(213, 38);
            this.rdoAssignTable.TabIndex = 0;
            this.rdoAssignTable.TabStop = true;
            this.rdoAssignTable.Text = "Assign Table";
            this.rdoAssignTable.UseVisualStyleBackColor = true;
            this.rdoAssignTable.CheckedChanged += new System.EventHandler(this.rdoAssignTable_CheckedChanged);
            // 
            // lstServers
            // 
            this.lstServers.FormattingEnabled = true;
            this.lstServers.ItemHeight = 16;
            this.lstServers.Location = new System.Drawing.Point(15, 13);
            this.lstServers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstServers.Name = "lstServers";
            this.lstServers.Size = new System.Drawing.Size(435, 260);
            this.lstServers.TabIndex = 7;
            // 
            // lblNumCustomers
            // 
            this.lblNumCustomers.AutoSize = true;
            this.lblNumCustomers.Location = new System.Drawing.Point(895, 588);
            this.lblNumCustomers.Name = "lblNumCustomers";
            this.lblNumCustomers.Size = new System.Drawing.Size(149, 17);
            this.lblNumCustomers.TabIndex = 9;
            this.lblNumCustomers.Text = "Number of Customers:";
            // 
            // txtNumCustomers
            // 
            this.txtNumCustomers.Location = new System.Drawing.Point(1050, 585);
            this.txtNumCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumCustomers.Name = "txtNumCustomers";
            this.txtNumCustomers.Size = new System.Drawing.Size(39, 22);
            this.txtNumCustomers.TabIndex = 10;
            this.txtNumCustomers.Text = "4";
            // 
            // lstReservations
            // 
            this.lstReservations.Enabled = false;
            this.lstReservations.FormattingEnabled = true;
            this.lstReservations.ItemHeight = 16;
            this.lstReservations.Location = new System.Drawing.Point(15, 13);
            this.lstReservations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstReservations.Name = "lstReservations";
            this.lstReservations.Size = new System.Drawing.Size(435, 260);
            this.lstReservations.TabIndex = 11;
            this.lstReservations.SelectedIndexChanged += new System.EventHandler(this.lstReservations_SelectedIndexChanged);
            // 
            // lstAssignments
            // 
            this.lstAssignments.FormattingEnabled = true;
            this.lstAssignments.ItemHeight = 16;
            this.lstAssignments.Location = new System.Drawing.Point(15, 13);
            this.lstAssignments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstAssignments.Name = "lstAssignments";
            this.lstAssignments.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstAssignments.Size = new System.Drawing.Size(435, 260);
            this.lstAssignments.TabIndex = 0;
            this.lstAssignments.SelectedIndexChanged += new System.EventHandler(this.lstAssignments_SelectedIndexChanged);
            // 
            // btnUse
            // 
            this.btnUse.Location = new System.Drawing.Point(156, 291);
            this.btnUse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(139, 28);
            this.btnUse.TabIndex = 13;
            this.btnUse.Text = "Use Reservation";
            this.btnUse.UseVisualStyleBackColor = true;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // btnClearTable
            // 
            this.btnClearTable.Location = new System.Drawing.Point(165, 293);
            this.btnClearTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(139, 28);
            this.btnClearTable.TabIndex = 14;
            this.btnClearTable.Text = "Clear Table";
            this.btnClearTable.UseVisualStyleBackColor = true;
            this.btnClearTable.Visible = false;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTable_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(165, 293);
            this.btnMerge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(139, 28);
            this.btnMerge.TabIndex = 17;
            this.btnMerge.Text = "Merge Tables";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Visible = false;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // lstAvailable
            // 
            this.lstAvailable.FormattingEnabled = true;
            this.lstAvailable.ItemHeight = 16;
            this.lstAvailable.Location = new System.Drawing.Point(15, 13);
            this.lstAvailable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstAvailable.Name = "lstAvailable";
            this.lstAvailable.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstAvailable.Size = new System.Drawing.Size(435, 260);
            this.lstAvailable.TabIndex = 15;
            this.lstAvailable.SelectedIndexChanged += new System.EventHandler(this.lstAvailable_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabaServers);
            this.tabControl1.Controls.Add(this.tabReservations);
            this.tabControl1.Controls.Add(this.tabAvailableTables);
            this.tabControl1.Controls.Add(this.tabAssignedTables);
            this.tabControl1.Location = new System.Drawing.Point(748, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(475, 371);
            this.tabControl1.TabIndex = 18;
            // 
            // tabaServers
            // 
            this.tabaServers.Controls.Add(this.lstServers);
            this.tabaServers.Location = new System.Drawing.Point(4, 25);
            this.tabaServers.Name = "tabaServers";
            this.tabaServers.Padding = new System.Windows.Forms.Padding(3);
            this.tabaServers.Size = new System.Drawing.Size(467, 449);
            this.tabaServers.TabIndex = 0;
            this.tabaServers.Text = "Servers";
            this.tabaServers.UseVisualStyleBackColor = true;
            // 
            // tabReservations
            // 
            this.tabReservations.Controls.Add(this.lstReservations);
            this.tabReservations.Controls.Add(this.btnUse);
            this.tabReservations.Location = new System.Drawing.Point(4, 25);
            this.tabReservations.Name = "tabReservations";
            this.tabReservations.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservations.Size = new System.Drawing.Size(467, 449);
            this.tabReservations.TabIndex = 1;
            this.tabReservations.Text = "Reservations";
            this.tabReservations.UseVisualStyleBackColor = true;
            // 
            // tabAvailableTables
            // 
            this.tabAvailableTables.Controls.Add(this.btnMerge);
            this.tabAvailableTables.Controls.Add(this.lstAvailable);
            this.tabAvailableTables.Location = new System.Drawing.Point(4, 25);
            this.tabAvailableTables.Name = "tabAvailableTables";
            this.tabAvailableTables.Size = new System.Drawing.Size(467, 342);
            this.tabAvailableTables.TabIndex = 2;
            this.tabAvailableTables.Text = "Available Tables";
            this.tabAvailableTables.UseVisualStyleBackColor = true;
            // 
            // tabAssignedTables
            // 
            this.tabAssignedTables.Controls.Add(this.lstAssignments);
            this.tabAssignedTables.Controls.Add(this.btnClearTable);
            this.tabAssignedTables.Location = new System.Drawing.Point(4, 25);
            this.tabAssignedTables.Name = "tabAssignedTables";
            this.tabAssignedTables.Size = new System.Drawing.Size(467, 449);
            this.tabAssignedTables.TabIndex = 3;
            this.tabAssignedTables.Text = "Assigned Tables";
            this.tabAssignedTables.UseVisualStyleBackColor = true;
            // 
            // frmSeatingLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 713);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblNumCustomers);
            this.Controls.Add(this.txtNumCustomers);
            this.Controls.Add(this.grpBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlRoom);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSeatingLayout";
            this.Text = "Seating Layout";
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabaServers.ResumeLayout(false);
            this.tabReservations.ResumeLayout(false);
            this.tabAvailableTables.ResumeLayout(false);
            this.tabAssignedTables.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox lstServers;
        private System.Windows.Forms.Label lblNumCustomers;
        private System.Windows.Forms.TextBox txtNumCustomers;
        private System.Windows.Forms.ListBox lstReservations;
        private System.Windows.Forms.ListBox lstAssignments;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.Button btnClearTable;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.ListBox lstAvailable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabaServers;
        private System.Windows.Forms.TabPage tabReservations;
        private System.Windows.Forms.TabPage tabAvailableTables;
        private System.Windows.Forms.TabPage tabAssignedTables;
    }
}