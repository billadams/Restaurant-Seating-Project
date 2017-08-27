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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManager = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateSeatingLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditSeatingLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHost = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeatingLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuManager,
            this.mnuHost,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(44, 24);
            this.mnuFile.Text = "&File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(181, 26);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuManager
            // 
            this.mnuManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateSeatingLayout,
            this.mnuEditSeatingLayout});
            this.mnuManager.Name = "mnuManager";
            this.mnuManager.Size = new System.Drawing.Size(80, 24);
            this.mnuManager.Text = "&Manager";
            // 
            // mnuCreateSeatingLayout
            // 
            this.mnuCreateSeatingLayout.Name = "mnuCreateSeatingLayout";
            this.mnuCreateSeatingLayout.Size = new System.Drawing.Size(229, 26);
            this.mnuCreateSeatingLayout.Text = "&Create Seating Layout";
            this.mnuCreateSeatingLayout.Click += new System.EventHandler(this.mnuCreateSeatingLayout_Click);
            // 
            // mnuEditSeatingLayout
            // 
            this.mnuEditSeatingLayout.Name = "mnuEditSeatingLayout";
            this.mnuEditSeatingLayout.Size = new System.Drawing.Size(229, 26);
            this.mnuEditSeatingLayout.Text = "Edit Seating Layout";
            // 
            // mnuHost
            // 
            this.mnuHost.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSeatingLayout});
            this.mnuHost.Name = "mnuHost";
            this.mnuHost.Size = new System.Drawing.Size(52, 24);
            this.mnuHost.Text = "H&ost";
            // 
            // mnuSeatingLayout
            // 
            this.mnuSeatingLayout.Name = "mnuSeatingLayout";
            this.mnuSeatingLayout.Size = new System.Drawing.Size(182, 26);
            this.mnuSeatingLayout.Text = "&Seating Layout";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(53, 24);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(253, 26);
            this.mnuAbout.Text = "About Restaurant Seating";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 707);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Restaurant Seating";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuManager;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateSeatingLayout;
        private System.Windows.Forms.ToolStripMenuItem mnuHost;
        private System.Windows.Forms.ToolStripMenuItem mnuSeatingLayout;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuEditSeatingLayout;
    }
}

