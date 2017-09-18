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
            this.txtTableNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBarSeatNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddBarSeat = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTableManager = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboSeats = new System.Windows.Forms.ComboBox();
            this.rdoSection3 = new System.Windows.Forms.RadioButton();
            this.rdoSection2 = new System.Windows.Forms.RadioButton();
            this.rdoSection1 = new System.Windows.Forms.RadioButton();
            this.tabBarSeatManager = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDeleteBarseat = new System.Windows.Forms.Button();
            this.tabBarManager = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnDeleteBar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCreateBar = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnDeleteLayout = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTableManager.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabBarSeatManager.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabBarManager.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveLayout.Location = new System.Drawing.Point(964, 473);
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
            this.pnlRoom.BackColor = System.Drawing.Color.DimGray;
            this.pnlRoom.Location = new System.Drawing.Point(12, 12);
            this.pnlRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRoom.Name = "pnlRoom";
            this.pnlRoom.Size = new System.Drawing.Size(707, 674);
            this.pnlRoom.TabIndex = 1;
            // 
            // btnAddTable
            // 
            this.btnAddTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTable.Location = new System.Drawing.Point(75, 115);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(131, 46);
            this.btnAddTable.TabIndex = 2;
            this.btnAddTable.Text = "&Add Table";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // txtTableNumber
            // 
            this.txtTableNumber.Location = new System.Drawing.Point(174, 39);
            this.txtTableNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTableNumber.Name = "txtTableNumber";
            this.txtTableNumber.Size = new System.Drawing.Size(49, 22);
            this.txtTableNumber.TabIndex = 5;
            this.txtTableNumber.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Seats:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Table Number:";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(964, 636);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 50);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCancelLayout_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBarSeatNumber);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnAddBarSeat);
            this.groupBox2.Location = new System.Drawing.Point(5, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(274, 269);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Barseats";
            // 
            // txtBarSeatNumber
            // 
            this.txtBarSeatNumber.Location = new System.Drawing.Point(167, 90);
            this.txtBarSeatNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBarSeatNumber.Name = "txtBarSeatNumber";
            this.txtBarSeatNumber.Size = new System.Drawing.Size(39, 22);
            this.txtBarSeatNumber.TabIndex = 5;
            this.txtBarSeatNumber.Text = "1";
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
            this.btnAddBarSeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBarSeat.Location = new System.Drawing.Point(77, 124);
            this.btnAddBarSeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBarSeat.Name = "btnAddBarSeat";
            this.btnAddBarSeat.Size = new System.Drawing.Size(131, 46);
            this.btnAddBarSeat.TabIndex = 2;
            this.btnAddBarSeat.Text = "Add Barseat";
            this.btnAddBarSeat.UseVisualStyleBackColor = true;
            this.btnAddBarSeat.Click += new System.EventHandler(this.btnAddBarSeat_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTableManager);
            this.tabControl1.Controls.Add(this.tabBarSeatManager);
            this.tabControl1.Controls.Add(this.tabBarManager);
            this.tabControl1.Location = new System.Drawing.Point(738, 129);
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
            this.groupBox4.Controls.Add(this.btnDeleteTable);
            this.groupBox4.Location = new System.Drawing.Point(289, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(271, 269);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Remove Tables";
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTable.Location = new System.Drawing.Point(80, 115);
            this.btnDeleteTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(131, 46);
            this.btnDeleteTable.TabIndex = 2;
            this.btnDeleteTable.Text = "Delete Table";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSeats);
            this.groupBox1.Controls.Add(this.rdoSection3);
            this.groupBox1.Controls.Add(this.rdoSection2);
            this.groupBox1.Controls.Add(this.rdoSection1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTableNumber);
            this.groupBox1.Controls.Add(this.btnAddTable);
            this.groupBox1.Location = new System.Drawing.Point(5, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(278, 269);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Tables";
            // 
            // cboSeats
            // 
            this.cboSeats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboSeats.FormattingEnabled = true;
            this.cboSeats.Items.AddRange(new object[] {
            "2",
            "4",
            "6"});
            this.cboSeats.Location = new System.Drawing.Point(174, 65);
            this.cboSeats.Name = "cboSeats";
            this.cboSeats.Size = new System.Drawing.Size(49, 24);
            this.cboSeats.TabIndex = 12;
            // 
            // rdoSection3
            // 
            this.rdoSection3.AutoSize = true;
            this.rdoSection3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSection3.Location = new System.Drawing.Point(96, 231);
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
            this.rdoSection2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSection2.Location = new System.Drawing.Point(96, 204);
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
            this.rdoSection1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSection1.Location = new System.Drawing.Point(96, 177);
            this.rdoSection1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoSection1.Name = "rdoSection1";
            this.rdoSection1.Size = new System.Drawing.Size(88, 21);
            this.rdoSection1.TabIndex = 9;
            this.rdoSection1.TabStop = true;
            this.rdoSection1.Text = "Section 1";
            this.rdoSection1.UseVisualStyleBackColor = true;
            // 
            // tabBarSeatManager
            // 
            this.tabBarSeatManager.Controls.Add(this.groupBox5);
            this.tabBarSeatManager.Controls.Add(this.groupBox2);
            this.tabBarSeatManager.Location = new System.Drawing.Point(4, 25);
            this.tabBarSeatManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBarSeatManager.Name = "tabBarSeatManager";
            this.tabBarSeatManager.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBarSeatManager.Size = new System.Drawing.Size(565, 277);
            this.tabBarSeatManager.TabIndex = 1;
            this.tabBarSeatManager.Text = "Bar Seating Manager";
            this.tabBarSeatManager.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDeleteBarseat);
            this.groupBox5.Location = new System.Drawing.Point(285, 1);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(274, 269);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Remove Barseats";
            // 
            // btnDeleteBarseat
            // 
            this.btnDeleteBarseat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBarseat.Location = new System.Drawing.Point(64, 124);
            this.btnDeleteBarseat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteBarseat.Name = "btnDeleteBarseat";
            this.btnDeleteBarseat.Size = new System.Drawing.Size(131, 46);
            this.btnDeleteBarseat.TabIndex = 3;
            this.btnDeleteBarseat.Text = "Delete Barseat";
            this.btnDeleteBarseat.UseVisualStyleBackColor = true;
            this.btnDeleteBarseat.Click += new System.EventHandler(this.btnDeleteBarseat_Click);
            // 
            // tabBarManager
            // 
            this.tabBarManager.Controls.Add(this.groupBox7);
            this.tabBarManager.Controls.Add(this.groupBox3);
            this.tabBarManager.Location = new System.Drawing.Point(4, 25);
            this.tabBarManager.Name = "tabBarManager";
            this.tabBarManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabBarManager.Size = new System.Drawing.Size(565, 277);
            this.tabBarManager.TabIndex = 2;
            this.tabBarManager.Text = "Bar Manager";
            this.tabBarManager.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnDeleteBar);
            this.groupBox7.Location = new System.Drawing.Point(285, 0);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(272, 269);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Remove Bar";
            // 
            // btnDeleteBar
            // 
            this.btnDeleteBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBar.Location = new System.Drawing.Point(79, 123);
            this.btnDeleteBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteBar.Name = "btnDeleteBar";
            this.btnDeleteBar.Size = new System.Drawing.Size(131, 46);
            this.btnDeleteBar.TabIndex = 2;
            this.btnDeleteBar.Text = "Delete Bar";
            this.btnDeleteBar.UseVisualStyleBackColor = true;
            this.btnDeleteBar.Click += new System.EventHandler(this.btnDeleteBar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.btnCreateBar);
            this.groupBox3.Location = new System.Drawing.Point(6, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(273, 269);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Bar";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Location = new System.Drawing.Point(289, 3);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(267, 269);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Add Barseats";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 114);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Create Bar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCreateBar
            // 
            this.btnCreateBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateBar.Location = new System.Drawing.Point(79, 123);
            this.btnCreateBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateBar.Name = "btnCreateBar";
            this.btnCreateBar.Size = new System.Drawing.Size(131, 46);
            this.btnCreateBar.TabIndex = 2;
            this.btnCreateBar.Text = "Create Bar";
            this.btnCreateBar.UseVisualStyleBackColor = true;
            this.btnCreateBar.Click += new System.EventHandler(this.btnCreateBar_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(742, 54);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(123, 20);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Message Label";
            // 
            // btnDeleteLayout
            // 
            this.btnDeleteLayout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteLayout.Location = new System.Drawing.Point(964, 534);
            this.btnDeleteLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteLayout.Name = "btnDeleteLayout";
            this.btnDeleteLayout.Size = new System.Drawing.Size(141, 50);
            this.btnDeleteLayout.TabIndex = 10;
            this.btnDeleteLayout.Text = "&Delete Layout";
            this.btnDeleteLayout.UseVisualStyleBackColor = true;
            this.btnDeleteLayout.Click += new System.EventHandler(this.btnDeleteLayout_Click);
            // 
            // frmManageSeatingLayout
            // 
            this.AcceptButton = this.btnSaveLayout;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1323, 709);
            this.ControlBox = false;
            this.Controls.Add(this.btnDeleteLayout);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClose);
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
            this.tabBarSeatManager.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tabBarManager.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveLayout;
        private System.Windows.Forms.Panel pnlRoom;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.TextBox txtTableNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBarSeatNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddBarSeat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTableManager;
        private System.Windows.Forms.TabPage tabBarSeatManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.RadioButton rdoSection3;
        private System.Windows.Forms.RadioButton rdoSection2;
        private System.Windows.Forms.RadioButton rdoSection1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnDeleteLayout;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDeleteBarseat;
        private System.Windows.Forms.TabPage tabBarManager;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnDeleteBar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCreateBar;
        private System.Windows.Forms.ComboBox cboSeats;
    }
}