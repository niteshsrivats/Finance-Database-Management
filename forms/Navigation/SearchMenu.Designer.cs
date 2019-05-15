namespace Finance_Management.forms.Navigation
{
    partial class SearchMenu
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
            this.Staff = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Staff
            // 
            this.Staff.BackColor = System.Drawing.SystemColors.Window;
            this.Staff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Staff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Staff.Location = new System.Drawing.Point(275, 175);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(350, 30);
            this.Staff.TabIndex = 0;
            this.Staff.Text = "Staff";
            this.Staff.UseVisualStyleBackColor = false;
            this.Staff.Click += new System.EventHandler(this.Staff_Click);
            // 
            // Student
            // 
            this.Student.BackColor = System.Drawing.SystemColors.Window;
            this.Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Student.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Student.Location = new System.Drawing.Point(275, 250);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(350, 30);
            this.Student.TabIndex = 1;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = false;
            this.Student.Click += new System.EventHandler(this.Student_Click);
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
            // SearchMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 459);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.Staff);
            this.Name = "SearchMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Staff;
        private System.Windows.Forms.Button Student;
        private System.Windows.Forms.Button Back;
    }
}