namespace RestaurantSeatingProject {
    partial class frmEditTableLayout {
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
            this.pnlRoom = new System.Windows.Forms.Panel();
            this.btnCancelLayout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlRoom
            // 
            this.pnlRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRoom.Location = new System.Drawing.Point(9, 9);
            this.pnlRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlRoom.Name = "pnlRoom";
            this.pnlRoom.Size = new System.Drawing.Size(531, 548);
            this.pnlRoom.TabIndex = 2;
            // 
            // btnCancelLayout
            // 
            this.btnCancelLayout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelLayout.Location = new System.Drawing.Point(630, 516);
            this.btnCancelLayout.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelLayout.Name = "btnCancelLayout";
            this.btnCancelLayout.Size = new System.Drawing.Size(106, 41);
            this.btnCancelLayout.TabIndex = 5;
            this.btnCancelLayout.Text = "&Cancel";
            this.btnCancelLayout.UseVisualStyleBackColor = true;
            this.btnCancelLayout.Click += new System.EventHandler(this.btnCancelLayout_Click);
            // 
            // frmEditTableLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 576);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelLayout);
            this.Controls.Add(this.pnlRoom);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEditTableLayout";
            this.Text = "Edit Table Layout";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRoom;
        private System.Windows.Forms.Button btnCancelLayout;
    }
}