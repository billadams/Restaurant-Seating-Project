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
            this.pnlTableLayout = new System.Windows.Forms.Panel();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumberOfSeats = new System.Windows.Forms.TextBox();
            this.txtTableNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelLayout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Location = new System.Drawing.Point(553, 470);
            this.btnSaveLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.Size = new System.Drawing.Size(236, 41);
            this.btnSaveLayout.TabIndex = 0;
            this.btnSaveLayout.Text = "&Save Layout";
            this.btnSaveLayout.UseVisualStyleBackColor = true;
            // 
            // pnlTableLayout
            // 
            this.pnlTableLayout.AllowDrop = true;
            this.pnlTableLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTableLayout.Location = new System.Drawing.Point(9, 10);
            this.pnlTableLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTableLayout.Name = "pnlTableLayout";
            this.pnlTableLayout.Size = new System.Drawing.Size(531, 548);
            this.pnlTableLayout.TabIndex = 1;
            this.pnlTableLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTableLayout_Paint);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(74, 102);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(98, 37);
            this.btnAddTable.TabIndex = 2;
            this.btnAddTable.Text = "&Add New Table";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumberOfSeats);
            this.groupBox1.Controls.Add(this.txtTableNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddTable);
            this.groupBox1.Location = new System.Drawing.Point(553, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(236, 156);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Table";
            // 
            // txtNumberOfSeats
            // 
            this.txtNumberOfSeats.Location = new System.Drawing.Point(152, 66);
            this.txtNumberOfSeats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumberOfSeats.Name = "txtNumberOfSeats";
            this.txtNumberOfSeats.Size = new System.Drawing.Size(30, 20);
            this.txtNumberOfSeats.TabIndex = 6;
            // 
            // txtTableNumber
            // 
            this.txtTableNumber.Location = new System.Drawing.Point(152, 31);
            this.txtTableNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTableNumber.Name = "txtTableNumber";
            this.txtTableNumber.Size = new System.Drawing.Size(30, 20);
            this.txtTableNumber.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Seats:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Table Number:";
            // 
            // btnCancelLayout
            // 
            this.btnCancelLayout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelLayout.Location = new System.Drawing.Point(553, 517);
            this.btnCancelLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelLayout.Name = "btnCancelLayout";
            this.btnCancelLayout.Size = new System.Drawing.Size(236, 41);
            this.btnCancelLayout.TabIndex = 4;
            this.btnCancelLayout.Text = "&Cancel";
            this.btnCancelLayout.UseVisualStyleBackColor = true;
            this.btnCancelLayout.Click += new System.EventHandler(this.btnCancelLayout_Click);
            // 
            // frmCreateTableLayout
            // 
            this.AcceptButton = this.btnSaveLayout;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelLayout;
            this.ClientSize = new System.Drawing.Size(797, 576);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelLayout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlTableLayout);
            this.Controls.Add(this.btnSaveLayout);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCreateTableLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Table Layout";
            this.Load += new System.EventHandler(this.frmCreateTableLayout_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveLayout;
        private System.Windows.Forms.Panel pnlTableLayout;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumberOfSeats;
        private System.Windows.Forms.TextBox txtTableNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelLayout;
    }
}