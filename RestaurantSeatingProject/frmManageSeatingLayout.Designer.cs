namespace RestaurantSeatingProject {
    partial class frmManageSeatingLayout {
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
            this.btnSaveLayout = new System.Windows.Forms.Button();
            this.pnlRoom = new System.Windows.Forms.Panel();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.txtNumberOfSeats = new System.Windows.Forms.TextBox();
            this.txtTableNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelLayout = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddBarSeat = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTableManager = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mnuDeleteTable = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSection3 = new System.Windows.Forms.RadioButton();
            this.rdoSection2 = new System.Windows.Forms.RadioButton();
            this.rdoSection1 = new System.Windows.Forms.RadioButton();
            this.tabBarManager = new System.Windows.Forms.TabPage();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnDeleteLayout = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAddBar = new System.Windows.Forms.Button();
            this.btnDeleteBar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTableManager.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabBarManager.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Location = new System.Drawing.Point(964, 526);
            this.btnSaveLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.Size = new System.Drawing.Size(141, 50);
            this.btnSaveLayout.TabIndex = 0;
            this.btnSaveLayout.Text = "&Save Layout";
            this.btnSaveLayout.UseVisualStyleBackColor = true;
            this.btnSaveLayout.Click += new System.EventHandler(this.btnSaveLayout_Click);
            // 
            // pnlRoom
            // 
            this.pnlRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRoom.Location = new System.Drawing.Point(12, 12);
            this.pnlRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRoom.Name = "pnlRoom";
            this.pnlRoom.Size = new System.Drawing.Size(707, 674);
            this.pnlRoom.TabIndex = 1;
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(75, 138);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(131, 46);
            this.btnAddTable.TabIndex = 2;
            this.btnAddTable.Text = "&Add Table";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // txtNumberOfSeats
            // 
            this.txtNumberOfSeats.Location = new System.Drawing.Point(179, 105);
            this.txtNumberOfSeats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumberOfSeats.Name = "txtNumberOfSeats";
            this.txtNumberOfSeats.Size = new System.Drawing.Size(39, 22);
            this.txtNumberOfSeats.TabIndex = 6;
            this.txtNumberOfSeats.Text = "4";
            // 
            // txtTableNumber
            // 
            this.txtTableNumber.Enabled = false;
            this.txtTableNumber.Location = new System.Drawing.Point(179, 76);
            this.txtTableNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTableNumber.Name = "txtTableNumber";
            this.txtTableNumber.Size = new System.Drawing.Size(39, 22);
            this.txtTableNumber.TabIndex = 5;
            this.txtTableNumber.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Seats:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Table Number:";
            // 
            // btnCancelLayout
            // 
            this.btnCancelLayout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelLayout.Location = new System.Drawing.Point(964, 636);
            this.btnCancelLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelLayout.Name = "btnCancelLayout";
            this.btnCancelLayout.Size = new System.Drawing.Size(141, 50);
            this.btnCancelLayout.TabIndex = 4;
            this.btnCancelLayout.Text = "&Cancel";
            this.btnCancelLayout.UseVisualStyleBackColor = true;
            this.btnCancelLayout.Click += new System.EventHandler(this.btnCancelLayout_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnAddBarSeat);
            this.groupBox2.Location = new System.Drawing.Point(5, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(283, 269);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Barseat";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(167, 90);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(39, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bar Number:";
            // 
            // btnAddBarSeat
            // 
            this.btnAddBarSeat.Location = new System.Drawing.Point(77, 124);
            this.btnAddBarSeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBarSeat.Name = "btnAddBarSeat";
            this.btnAddBarSeat.Size = new System.Drawing.Size(131, 46);
            this.btnAddBarSeat.TabIndex = 2;
            this.btnAddBarSeat.Text = "&Add Barseat";
            this.btnAddBarSeat.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTableManager);
            this.tabControl1.Controls.Add(this.tabBarManager);
            this.tabControl1.Location = new System.Drawing.Point(737, 117);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(573, 306);
            this.tabControl1.TabIndex = 8;
            // 
            // tabTableManager
            // 
            this.tabTableManager.Controls.Add(this.groupBox4);
            this.tabTableManager.Controls.Add(this.groupBox1);
            this.tabTableManager.Location = new System.Drawing.Point(4, 25);
            this.tabTableManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTableManager.Name = "tabTableManager";
            this.tabTableManager.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTableManager.Size = new System.Drawing.Size(565, 277);
            this.tabTableManager.TabIndex = 0;
            this.tabTableManager.Text = "Table Manager";
            this.tabTableManager.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mnuDeleteTable);
            this.groupBox4.Location = new System.Drawing.Point(289, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(271, 269);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Remove Tables";
            // 
            // mnuDeleteTable
            // 
            this.mnuDeleteTable.Location = new System.Drawing.Point(80, 115);
            this.mnuDeleteTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mnuDeleteTable.Name = "mnuDeleteTable";
            this.mnuDeleteTable.Size = new System.Drawing.Size(131, 46);
            this.mnuDeleteTable.TabIndex = 2;
            this.mnuDeleteTable.Text = "&Delete Table";
            this.mnuDeleteTable.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoSection3);
            this.groupBox1.Controls.Add(this.rdoSection2);
            this.groupBox1.Controls.Add(this.rdoSection1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumberOfSeats);
            this.groupBox1.Controls.Add(this.txtTableNumber);
            this.groupBox1.Controls.Add(this.btnAddTable);
            this.groupBox1.Location = new System.Drawing.Point(5, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(278, 269);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Tables";
            // 
            // rdoSection3
            // 
            this.rdoSection3.AutoSize = true;
            this.rdoSection3.Location = new System.Drawing.Point(96, 239);
            this.rdoSection3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoSection3.Name = "rdoSection3";
            this.rdoSection3.Size = new System.Drawing.Size(88, 21);
            this.rdoSection3.TabIndex = 11;
            this.rdoSection3.Text = "Section 3";
            this.rdoSection3.UseVisualStyleBackColor = true;
            // 
            // rdoSection2
            // 
            this.rdoSection2.AutoSize = true;
            this.rdoSection2.Location = new System.Drawing.Point(96, 214);
            this.rdoSection2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoSection2.Name = "rdoSection2";
            this.rdoSection2.Size = new System.Drawing.Size(88, 21);
            this.rdoSection2.TabIndex = 10;
            this.rdoSection2.Text = "Section 2";
            this.rdoSection2.UseVisualStyleBackColor = true;
            // 
            // rdoSection1
            // 
            this.rdoSection1.AutoSize = true;
            this.rdoSection1.Checked = true;
            this.rdoSection1.Location = new System.Drawing.Point(96, 188);
            this.rdoSection1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoSection1.Name = "rdoSection1";
            this.rdoSection1.Size = new System.Drawing.Size(88, 21);
            this.rdoSection1.TabIndex = 9;
            this.rdoSection1.TabStop = true;
            this.rdoSection1.Text = "Section 1";
            this.rdoSection1.UseVisualStyleBackColor = true;
            // 
            // tabBarManager
            // 
            this.tabBarManager.Controls.Add(this.groupBox5);
            this.tabBarManager.Controls.Add(this.groupBox2);
            this.tabBarManager.Location = new System.Drawing.Point(4, 25);
            this.tabBarManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBarManager.Name = "tabBarManager";
            this.tabBarManager.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBarManager.Size = new System.Drawing.Size(565, 277);
            this.tabBarManager.TabIndex = 1;
            this.tabBarManager.Text = "Bar Manager";
            this.tabBarManager.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(739, 12);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(104, 17);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Message Label";
            // 
            // btnDeleteLayout
            // 
            this.btnDeleteLayout.Location = new System.Drawing.Point(964, 581);
            this.btnDeleteLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteLayout.Name = "btnDeleteLayout";
            this.btnDeleteLayout.Size = new System.Drawing.Size(141, 50);
            this.btnDeleteLayout.TabIndex = 10;
            this.btnDeleteLayout.Text = "&Delete Layout";
            this.btnDeleteLayout.UseVisualStyleBackColor = true;
            this.btnDeleteLayout.Click += new System.EventHandler(this.btnDeleteLayout_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDeleteBar);
            this.groupBox5.Controls.Add(this.btnAddBar);
            this.groupBox5.Location = new System.Drawing.Point(294, 4);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(252, 269);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add New Barseat";
            // 
            // btnAddBar
            // 
            this.btnAddBar.Location = new System.Drawing.Point(63, 81);
            this.btnAddBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBar.Name = "btnAddBar";
            this.btnAddBar.Size = new System.Drawing.Size(131, 46);
            this.btnAddBar.TabIndex = 2;
            this.btnAddBar.Text = "Add Bar";
            this.btnAddBar.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBar
            // 
            this.btnDeleteBar.Location = new System.Drawing.Point(63, 146);
            this.btnDeleteBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteBar.Name = "btnDeleteBar";
            this.btnDeleteBar.Size = new System.Drawing.Size(131, 46);
            this.btnDeleteBar.TabIndex = 3;
            this.btnDeleteBar.Text = "Delete Bar";
            this.btnDeleteBar.UseVisualStyleBackColor = true;
            // 
            // frmManageSeatingLayout
            // 
            this.AcceptButton = this.btnSaveLayout;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelLayout;
            this.ClientSize = new System.Drawing.Size(1323, 709);
            this.ControlBox = false;
            this.Controls.Add(this.btnDeleteLayout);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancelLayout);
            this.Controls.Add(this.pnlRoom);
            this.Controls.Add(this.btnSaveLayout);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmManageSeatingLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Seating Layout";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabTableManager.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabBarManager.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveLayout;
        private System.Windows.Forms.Panel pnlRoom;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.TextBox txtNumberOfSeats;
        private System.Windows.Forms.TextBox txtTableNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelLayout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddBarSeat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTableManager;
        private System.Windows.Forms.TabPage tabBarManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button mnuDeleteTable;
        private System.Windows.Forms.RadioButton rdoSection3;
        private System.Windows.Forms.RadioButton rdoSection2;
        private System.Windows.Forms.RadioButton rdoSection1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnDeleteLayout;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDeleteBar;
        private System.Windows.Forms.Button btnAddBar;
    }
}