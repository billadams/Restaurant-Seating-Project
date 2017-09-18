namespace RestaurantSeatingProject
{
    partial class frmManageServers
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
            this.lstServers = new System.Windows.Forms.ListBox();
            this.btnDeleteServer = new System.Windows.Forms.Button();
            this.lblManageServers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstServers
            // 
            this.lstServers.FormattingEnabled = true;
            this.lstServers.ItemHeight = 16;
            this.lstServers.Location = new System.Drawing.Point(199, 36);
            this.lstServers.Margin = new System.Windows.Forms.Padding(4);
            this.lstServers.Name = "lstServers";
            this.lstServers.Size = new System.Drawing.Size(288, 340);
            this.lstServers.TabIndex = 0;
            this.lstServers.SelectedIndexChanged += new System.EventHandler(this.lstServers_SelectedIndexChanged);
            // 
            // btnDeleteServer
            // 
            this.btnDeleteServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteServer.Enabled = false;
            this.btnDeleteServer.Location = new System.Drawing.Point(269, 395);
            this.btnDeleteServer.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteServer.Name = "btnDeleteServer";
            this.btnDeleteServer.Size = new System.Drawing.Size(129, 28);
            this.btnDeleteServer.TabIndex = 1;
            this.btnDeleteServer.Text = "Delete Server";
            this.btnDeleteServer.UseVisualStyleBackColor = true;
            this.btnDeleteServer.Click += new System.EventHandler(this.btnDeleteServer_Click);
            // 
            // lblManageServers
            // 
            this.lblManageServers.AutoSize = true;
            this.lblManageServers.Font = new System.Drawing.Font("Arial", 15F);
            this.lblManageServers.Location = new System.Drawing.Point(229, 4);
            this.lblManageServers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManageServers.Name = "lblManageServers";
            this.lblManageServers.Size = new System.Drawing.Size(195, 28);
            this.lblManageServers.TabIndex = 5;
            this.lblManageServers.Text = "Manage Servers";
            // 
            // frmManageServers
            // 
            this.AcceptButton = this.btnDeleteServer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 482);
            this.Controls.Add(this.lblManageServers);
            this.Controls.Add(this.btnDeleteServer);
            this.Controls.Add(this.lstServers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManageServers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Servers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstServers;
        private System.Windows.Forms.Button btnDeleteServer;
        private System.Windows.Forms.Label lblManageServers;
    }
}