namespace Finance_Management.forms.Navigation
{
    partial class Home
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
            this.Add = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Student
            // 
            this.Student.BackColor = System.Drawing.SystemColors.Window;
            this.Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Student.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Student.Location = new System.Drawing.Point(275, 185);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(350, 30);
            this.Student.TabIndex = 1;
            this.Student.Text = "Student Transaction";
            this.Student.UseVisualStyleBackColor = false;
            this.Student.Click += new System.EventHandler(this.Student_Click);
            // 
            // Staff
            // 
            this.Staff.BackColor = System.Drawing.SystemColors.Window;
            this.Staff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Staff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Staff.Location = new System.Drawing.Point(275, 110);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(350, 30);
            this.Staff.TabIndex = 0;
            this.Staff.Text = "Staff Transaction";
            this.Staff.UseVisualStyleBackColor = false;
            this.Staff.Click += new System.EventHandler(this.Staff_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.Window;
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.Location = new System.Drawing.Point(300, 260);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(300, 30);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add New Entry";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.Window;
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search.Location = new System.Drawing.Point(375, 335);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(150, 30);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 459);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Staff);
            this.Controls.Add(this.Student);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Student;
        private System.Windows.Forms.Button Staff;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Search;
    }
}