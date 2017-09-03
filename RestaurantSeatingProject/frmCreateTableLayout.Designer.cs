namespace RestaurantSeatingProject {
    partial class frmCreateTableLayout {
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTableManager = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.mnuDeleteTable = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSection3 = new System.Windows.Forms.RadioButton();
            this.rdoSection2 = new System.Windows.Forms.RadioButton();
            this.rdoSection1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabBarManager = new System.Windows.Forms.TabPage();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnDeleteLayout = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTableManager.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabBarManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Location = new System.Drawing.Point(723, 427);
            this.btnSaveLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.Size = new System.Drawing.Size(106, 41);
            this.btnSaveLayout.TabIndex = 0;
            this.btnSaveLayout.Text = "&Save Layout";
            this.btnSaveLayout.UseVisualStyleBackColor = true;
            this.btnSaveLayout.Click += new System.EventHandler(this.btnSaveLayout_Click);
            // 
            // pnlRoom
            // 
            this.pnlRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRoom.Location = new System.Drawing.Point(9, 10);
            this.pnlRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlRoom.Name = "pnlRoom";
            this.pnlRoom.Size = new System.Drawing.Size(531, 548);
            this.pnlRoom.TabIndex = 1;
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(56, 112);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(98, 37);
            this.btnAddTable.TabIndex = 2;
            this.btnAddTable.Text = "&Add Table";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // txtNumberOfSeats
            // 
            this.txtNumberOfSeats.Location = new System.Drawing.Point(134, 85);
            this.txtNumberOfSeats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumberOfSeats.Name = "txtNumberOfSeats";
            this.txtNumberOfSeats.Size = new System.Drawing.Size(30, 20);
            this.txtNumberOfSeats.TabIndex = 6;
            this.txtNumberOfSeats.Text = "4";
            // 
            // txtTableNumber
            // 
            this.txtTableNumber.Enabled = false;
            this.txtTableNumber.Location = new System.Drawing.Point(134, 62);
            this.txtTableNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTableNumber.Name = "txtTableNumber";
            this.txtTableNumber.Size = new System.Drawing.Size(30, 20);
            this.txtTableNumber.TabIndex = 5;
            this.txtTableNumber.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Seats:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Table Number:";
            // 
            // btnCancelLayout
            // 
            this.btnCancelLayout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelLayout.Location = new System.Drawing.Point(723, 517);
            this.btnCancelLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelLayout.Name = "btnCancelLayout";
            this.btnCancelLayout.Size = new System.Drawing.Size(106, 41);
            this.btnCancelLayout.TabIndex = 4;
            this.btnCancelLayout.Text = "&Cancel";
            this.btnCancelLayout.UseVisualStyleBackColor = true;
            this.btnCancelLayout.Click += new System.EventHandler(this.btnCancelLayout_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(4, 58);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(416, 103);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Barseat";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(222, 23);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(30, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bar Number:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Add New Barseat";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTableManager);
            this.tabControl1.Controls.Add(this.tabBarManager);
            this.tabControl1.Location = new System.Drawing.Point(553, 95);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(430, 249);
            this.tabControl1.TabIndex = 8;
            // 
            // tabTableManager
            // 
            this.tabTableManager.Controls.Add(this.groupBox4);
            this.tabTableManager.Controls.Add(this.groupBox1);
            this.tabTableManager.Location = new System.Drawing.Point(4, 22);
            this.tabTableManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabTableManager.Name = "tabTableManager";
            this.tabTableManager.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabTableManager.Size = new System.Drawing.Size(422, 223);
            this.tabTableManager.TabIndex = 0;
            this.tabTableManager.Text = "Table Manager";
            this.tabTableManager.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.mnuDeleteTable);
            this.groupBox4.Location = new System.Drawing.Point(208, 5);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(212, 215);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add New Tables";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Table Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Number of Seats:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(134, 85);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(30, 20);
            this.textBox6.TabIndex = 6;
            this.textBox6.Text = "4";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(134, 62);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(30, 20);
            this.textBox7.TabIndex = 5;
            this.textBox7.Text = "1";
            // 
            // mnuDeleteTable
            // 
            this.mnuDeleteTable.Location = new System.Drawing.Point(56, 112);
            this.mnuDeleteTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mnuDeleteTable.Name = "mnuDeleteTable";
            this.mnuDeleteTable.Size = new System.Drawing.Size(98, 37);
            this.mnuDeleteTable.TabIndex = 2;
            this.mnuDeleteTable.Text = "&Delete Table";
            this.mnuDeleteTable.UseVisualStyleBackColor = true;
            this.mnuDeleteTable.Click += new System.EventHandler(this.mnuDeleteTable_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoSection3);
            this.groupBox1.Controls.Add(this.rdoSection2);
            this.groupBox1.Controls.Add(this.rdoSection1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumberOfSeats);
            this.groupBox1.Controls.Add(this.txtTableNumber);
            this.groupBox1.Controls.Add(this.btnAddTable);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(194, 215);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Tables";
            // 
            // rdoSection3
            // 
            this.rdoSection3.AutoSize = true;
            this.rdoSection3.Location = new System.Drawing.Point(59, 194);
            this.rdoSection3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoSection3.Name = "rdoSection3";
            this.rdoSection3.Size = new System.Drawing.Size(70, 17);
            this.rdoSection3.TabIndex = 11;
            this.rdoSection3.Text = "Section 3";
            this.rdoSection3.UseVisualStyleBackColor = true;
            // 
            // rdoSection2
            // 
            this.rdoSection2.AutoSize = true;
            this.rdoSection2.Location = new System.Drawing.Point(59, 174);
            this.rdoSection2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoSection2.Name = "rdoSection2";
            this.rdoSection2.Size = new System.Drawing.Size(70, 17);
            this.rdoSection2.TabIndex = 10;
            this.rdoSection2.Text = "Section 2";
            this.rdoSection2.UseVisualStyleBackColor = true;
            // 
            // rdoSection1
            // 
            this.rdoSection1.AutoSize = true;
            this.rdoSection1.Checked = true;
            this.rdoSection1.Location = new System.Drawing.Point(59, 153);
            this.rdoSection1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoSection1.Name = "rdoSection1";
            this.rdoSection1.Size = new System.Drawing.Size(70, 17);
            this.rdoSection1.TabIndex = 9;
            this.rdoSection1.TabStop = true;
            this.rdoSection1.Text = "Section 1";
            this.rdoSection1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(199, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(217, 215);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add New Tables";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Table Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of Seats:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 85);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "4";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(134, 62);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(30, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 112);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Add Table";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabBarManager
            // 
            this.tabBarManager.Controls.Add(this.groupBox2);
            this.tabBarManager.Location = new System.Drawing.Point(4, 22);
            this.tabBarManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabBarManager.Name = "tabBarManager";
            this.tabBarManager.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabBarManager.Size = new System.Drawing.Size(422, 223);
            this.tabBarManager.TabIndex = 1;
            this.tabBarManager.Text = "Bar Manager";
            this.tabBarManager.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(554, 10);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(79, 13);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Message Label";
            // 
            // btnDeleteLayout
            // 
            this.btnDeleteLayout.Location = new System.Drawing.Point(723, 472);
            this.btnDeleteLayout.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteLayout.Name = "btnDeleteLayout";
            this.btnDeleteLayout.Size = new System.Drawing.Size(106, 41);
            this.btnDeleteLayout.TabIndex = 10;
            this.btnDeleteLayout.Text = "&Delete Layout";
            this.btnDeleteLayout.UseVisualStyleBackColor = true;
            this.btnDeleteLayout.Click += new System.EventHandler(this.btnDeleteLayout_Click);
            // 
            // frmCreateTableLayout
            // 
            this.AcceptButton = this.btnSaveLayout;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelLayout;
            this.ClientSize = new System.Drawing.Size(992, 576);
            this.ControlBox = false;
            this.Controls.Add(this.btnDeleteLayout);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancelLayout);
            this.Controls.Add(this.pnlRoom);
            this.Controls.Add(this.btnSaveLayout);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCreateTableLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Table Layout";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabTableManager.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabBarManager.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTableManager;
        private System.Windows.Forms.TabPage tabBarManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button mnuDeleteTable;
        private System.Windows.Forms.RadioButton rdoSection3;
        private System.Windows.Forms.RadioButton rdoSection2;
        private System.Windows.Forms.RadioButton rdoSection1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnDeleteLayout;
    }
}