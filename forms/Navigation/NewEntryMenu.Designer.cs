namespace Finance_Management.forms.Navigation
{
    partial class NewEntryMenu
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
            this.Student = new System.Windows.Forms.Button();
            this.Staff = new System.Windows.Forms.Button();
            this.Hostel = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Student
            // 
            this.Student.BackColor = System.Drawing.SystemColors.Window;
            this.Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Student.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Student.Location = new System.Drawing.Point(275, 125);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(350, 30);
            this.Student.TabIndex = 0;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = false;
            this.Student.Click += new System.EventHandler(this.Student_Click);
            // 
            // Staff
            // 
            this.Staff.BackColor = System.Drawing.SystemColors.Window;
            this.Staff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Staff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Staff.Location = new System.Drawing.Point(275, 200);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(350, 30);
            this.Staff.TabIndex = 1;
            this.Staff.Text = "Staff";
            this.Staff.UseVisualStyleBackColor = false;
            this.Staff.Click += new System.EventHandler(this.Staff_Click);
            // 
            // Hostel
            // 
            this.Hostel.BackColor = System.Drawing.SystemColors.Window;
            this.Hostel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hostel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Hostel.Location = new System.Drawing.Point(275, 275);
            this.Hostel.Name = "Hostel";
            this.Hostel.Size = new System.Drawing.Size(350, 30);
            this.Hostel.TabIndex = 2;
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
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // NewEntryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 459);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Hostel);
            this.Controls.Add(this.Staff);
            this.Controls.Add(this.Student);
            this.Name = "NewEntryMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Entry Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewEntryMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Student;
        private System.Windows.Forms.Button Staff;
        private System.Windows.Forms.Button Hostel;
        private System.Windows.Forms.Button Back;
    }
}