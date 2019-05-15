namespace Finance_Management.forms.Navigation
{
    partial class StaffTransactionSearchMenu
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
            this.College = new System.Windows.Forms.Button();
            this.Hostel = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // College
            // 
            this.College.BackColor = System.Drawing.SystemColors.Window;
            this.College.Cursor = System.Windows.Forms.Cursors.Hand;
            this.College.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.College.Location = new System.Drawing.Point(275, 175);
            this.College.Name = "College";
            this.College.Size = new System.Drawing.Size(350, 30);
            this.College.TabIndex = 0;
            this.College.Text = "College";
            this.College.UseVisualStyleBackColor = false;
            this.College.Click += new System.EventHandler(this.College_Click);
            // 
            // Hostel
            // 
            this.Hostel.BackColor = System.Drawing.SystemColors.Window;
            this.Hostel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hostel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Hostel.Location = new System.Drawing.Point(275, 250);
            this.Hostel.Name = "Hostel";
            this.Hostel.Size = new System.Drawing.Size(350, 30);
            this.Hostel.TabIndex = 1;
            this.Hostel.Text = "Hostel";
            this.Hostel.UseVisualStyleBackColor = false;
            this.Hostel.Click += new System.EventHandler(this.Hostel_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.Window;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Location = new System.Drawing.Point(40, 30);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(80, 30);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // StaffTransactionSearchMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 459);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Hostel);
            this.Controls.Add(this.College);
            this.Name = "StaffTransactionSearchMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffTransactionSearchMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffTransactionSearchMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button College;
        private System.Windows.Forms.Button Hostel;
        private System.Windows.Forms.Button Back;
    }
}