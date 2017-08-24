namespace RestaurantSeatingProject {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.grpSelectRole = new System.Windows.Forms.GroupBox();
            this.optManager = new System.Windows.Forms.RadioButton();
            this.optHost = new System.Windows.Forms.RadioButton();
            this.optBusser = new System.Windows.Forms.RadioButton();
            this.pnlInterface = new System.Windows.Forms.Panel();
            this.btnCreateTableLayout = new System.Windows.Forms.Button();
            this.btnUpdateTableLayout = new System.Windows.Forms.Button();
            this.btnClearTableLayout = new System.Windows.Forms.Button();
            this.grpTableSetup = new System.Windows.Forms.GroupBox();
            this.grpServerSetup = new System.Windows.Forms.GroupBox();
            this.lstServerSetup = new System.Windows.Forms.ListBox();
            this.btnAddServer = new System.Windows.Forms.Button();
            this.btnEditServer = new System.Windows.Forms.Button();
            this.btnRemoveServer = new System.Windows.Forms.Button();
            this.grpSelectRole.SuspendLayout();
            this.pnlInterface.SuspendLayout();
            this.grpTableSetup.SuspendLayout();
            this.grpServerSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSelectRole
            // 
            this.grpSelectRole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpSelectRole.Controls.Add(this.optBusser);
            this.grpSelectRole.Controls.Add(this.optHost);
            this.grpSelectRole.Controls.Add(this.optManager);
            this.grpSelectRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grpSelectRole.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpSelectRole.Location = new System.Drawing.Point(308, 607);
            this.grpSelectRole.Name = "grpSelectRole";
            this.grpSelectRole.Size = new System.Drawing.Size(321, 79);
            this.grpSelectRole.TabIndex = 0;
            this.grpSelectRole.TabStop = false;
            this.grpSelectRole.Text = "User Role";
            // 
            // optManager
            // 
            this.optManager.AutoSize = true;
            this.optManager.Location = new System.Drawing.Point(32, 33);
            this.optManager.Name = "optManager";
            this.optManager.Size = new System.Drawing.Size(85, 21);
            this.optManager.TabIndex = 0;
            this.optManager.TabStop = true;
            this.optManager.Text = "Manager";
            this.optManager.UseVisualStyleBackColor = true;
            // 
            // optHost
            // 
            this.optHost.AutoSize = true;
            this.optHost.Location = new System.Drawing.Point(139, 33);
            this.optHost.Name = "optHost";
            this.optHost.Size = new System.Drawing.Size(58, 21);
            this.optHost.TabIndex = 1;
            this.optHost.TabStop = true;
            this.optHost.Text = "Host";
            this.optHost.UseVisualStyleBackColor = true;
            // 
            // optBusser
            // 
            this.optBusser.AutoSize = true;
            this.optBusser.Location = new System.Drawing.Point(217, 33);
            this.optBusser.Name = "optBusser";
            this.optBusser.Size = new System.Drawing.Size(73, 21);
            this.optBusser.TabIndex = 2;
            this.optBusser.TabStop = true;
            this.optBusser.Text = "Busser";
            this.optBusser.UseVisualStyleBackColor = true;
            // 
            // pnlInterface
            // 
            this.pnlInterface.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInterface.Controls.Add(this.grpServerSetup);
            this.pnlInterface.Controls.Add(this.grpTableSetup);
            this.pnlInterface.Location = new System.Drawing.Point(21, 20);
            this.pnlInterface.Name = "pnlInterface";
            this.pnlInterface.Size = new System.Drawing.Size(895, 570);
            this.pnlInterface.TabIndex = 1;
            // 
            // btnCreateTableLayout
            // 
            this.btnCreateTableLayout.Location = new System.Drawing.Point(26, 34);
            this.btnCreateTableLayout.Name = "btnCreateTableLayout";
            this.btnCreateTableLayout.Size = new System.Drawing.Size(254, 57);
            this.btnCreateTableLayout.TabIndex = 0;
            this.btnCreateTableLayout.Text = "Create Table Layout";
            this.btnCreateTableLayout.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTableLayout
            // 
            this.btnUpdateTableLayout.Location = new System.Drawing.Point(26, 114);
            this.btnUpdateTableLayout.Name = "btnUpdateTableLayout";
            this.btnUpdateTableLayout.Size = new System.Drawing.Size(254, 57);
            this.btnUpdateTableLayout.TabIndex = 1;
            this.btnUpdateTableLayout.Text = "Update Table Layout";
            this.btnUpdateTableLayout.UseVisualStyleBackColor = true;
            // 
            // btnClearTableLayout
            // 
            this.btnClearTableLayout.Location = new System.Drawing.Point(26, 194);
            this.btnClearTableLayout.Name = "btnClearTableLayout";
            this.btnClearTableLayout.Size = new System.Drawing.Size(254, 57);
            this.btnClearTableLayout.TabIndex = 2;
            this.btnClearTableLayout.Text = "Clear Table Layout";
            this.btnClearTableLayout.UseVisualStyleBackColor = true;
            // 
            // grpTableSetup
            // 
            this.grpTableSetup.Controls.Add(this.btnClearTableLayout);
            this.grpTableSetup.Controls.Add(this.btnUpdateTableLayout);
            this.grpTableSetup.Controls.Add(this.btnCreateTableLayout);
            this.grpTableSetup.Location = new System.Drawing.Point(21, 20);
            this.grpTableSetup.Name = "grpTableSetup";
            this.grpTableSetup.Size = new System.Drawing.Size(309, 273);
            this.grpTableSetup.TabIndex = 3;
            this.grpTableSetup.TabStop = false;
            this.grpTableSetup.Text = "Table Setup";
            // 
            // grpServerSetup
            // 
            this.grpServerSetup.Controls.Add(this.btnRemoveServer);
            this.grpServerSetup.Controls.Add(this.btnEditServer);
            this.grpServerSetup.Controls.Add(this.btnAddServer);
            this.grpServerSetup.Controls.Add(this.lstServerSetup);
            this.grpServerSetup.Location = new System.Drawing.Point(531, 29);
            this.grpServerSetup.Name = "grpServerSetup";
            this.grpServerSetup.Size = new System.Drawing.Size(325, 323);
            this.grpServerSetup.TabIndex = 4;
            this.grpServerSetup.TabStop = false;
            this.grpServerSetup.Text = "Server Setup";
            // 
            // lstServerSetup
            // 
            this.lstServerSetup.FormattingEnabled = true;
            this.lstServerSetup.ItemHeight = 16;
            this.lstServerSetup.Location = new System.Drawing.Point(146, 38);
            this.lstServerSetup.Name = "lstServerSetup";
            this.lstServerSetup.Size = new System.Drawing.Size(157, 260);
            this.lstServerSetup.TabIndex = 0;
            // 
            // btnAddServer
            // 
            this.btnAddServer.Location = new System.Drawing.Point(20, 39);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(111, 44);
            this.btnAddServer.TabIndex = 1;
            this.btnAddServer.Text = "Add Server";
            this.btnAddServer.UseVisualStyleBackColor = true;
            // 
            // btnEditServer
            // 
            this.btnEditServer.Location = new System.Drawing.Point(20, 89);
            this.btnEditServer.Name = "btnEditServer";
            this.btnEditServer.Size = new System.Drawing.Size(111, 44);
            this.btnEditServer.TabIndex = 2;
            this.btnEditServer.Text = "Edit Server";
            this.btnEditServer.UseVisualStyleBackColor = true;
            // 
            // btnRemoveServer
            // 
            this.btnRemoveServer.Location = new System.Drawing.Point(20, 139);
            this.btnRemoveServer.Name = "btnRemoveServer";
            this.btnRemoveServer.Size = new System.Drawing.Size(111, 44);
            this.btnRemoveServer.TabIndex = 3;
            this.btnRemoveServer.Text = "Remove Server";
            this.btnRemoveServer.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 707);
            this.Controls.Add(this.pnlInterface);
            this.Controls.Add(this.grpSelectRole);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Restaurant Seating";
            this.grpSelectRole.ResumeLayout(false);
            this.grpSelectRole.PerformLayout();
            this.pnlInterface.ResumeLayout(false);
            this.grpTableSetup.ResumeLayout(false);
            this.grpServerSetup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelectRole;
        private System.Windows.Forms.RadioButton optBusser;
        private System.Windows.Forms.RadioButton optHost;
        private System.Windows.Forms.RadioButton optManager;
        private System.Windows.Forms.Panel pnlInterface;
        private System.Windows.Forms.GroupBox grpServerSetup;
        private System.Windows.Forms.Button btnRemoveServer;
        private System.Windows.Forms.Button btnEditServer;
        private System.Windows.Forms.Button btnAddServer;
        private System.Windows.Forms.ListBox lstServerSetup;
        private System.Windows.Forms.GroupBox grpTableSetup;
        private System.Windows.Forms.Button btnClearTableLayout;
        private System.Windows.Forms.Button btnUpdateTableLayout;
        private System.Windows.Forms.Button btnCreateTableLayout;
    }
}

