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
            this.lstServers.Location = new System.Drawing.Point(149, 29);
            this.lstServers.Name = "lstServers";
            this.lstServers.Size = new System.Drawing.Size(217, 277);
            this.lstServers.TabIndex = 0;
            this.lstServers.SelectedIndexChanged += new System.EventHandler(this.lstServers_SelectedIndexChanged);
            // 
            // btnDeleteServer
            // 
            this.btnDeleteServer.Enabled = false;
            this.btnDeleteServer.Location = new System.Drawing.Point(202, 321);
            this.btnDeleteServer.Name = "btnDeleteServer";
            this.btnDeleteServer.Size = new System.Drawing.Size(97, 23);
            this.btnDeleteServer.TabIndex = 1;
            this.btnDeleteServer.Text = "Delete Server";
            this.btnDeleteServer.UseVisualStyleBackColor = true;
            this.btnDeleteServer.Click += new System.EventHandler(this.btnDeleteServer_Click);
            // 
            // lblManageServers
            // 
            this.lblManageServers.AutoSize = true;
            this.lblManageServers.Font = new System.Drawing.Font("Arial", 15F);
            this.lblManageServers.Location = new System.Drawing.Point(172, 3);
            this.lblManageServers.Name = "lblManageServers";
            this.lblManageServers.Size = new System.Drawing.Size(155, 23);
            this.lblManageServers.TabIndex = 5;
            this.lblManageServers.Text = "Manage Servers";
            // 
            // frmManageServers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 392);
            this.Controls.Add(this.lblManageServers);
            this.Controls.Add(this.btnDeleteServer);
            this.Controls.Add(this.lstServers);
            this.Name = "frmManageServers";
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