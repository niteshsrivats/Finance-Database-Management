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
            this.SuspendLayout();
            // 
            // Student
            // 
            this.Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Student.Location = new System.Drawing.Point(309, 221);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(363, 23);
            this.Student.TabIndex = 1;
            this.Student.Text = "Student Transaction";
            this.Student.UseVisualStyleBackColor = true;
            this.Student.Click += new System.EventHandler(this.Student_Click);
            // 
            // Staff
            // 
            this.Staff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Staff.Location = new System.Drawing.Point(309, 157);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(343, 23);
            this.Staff.TabIndex = 0;
            this.Staff.Text = "Staff Transaction";
            this.Staff.UseVisualStyleBackColor = true;
            this.Staff.Click += new System.EventHandler(this.Staff_Click);
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Location = new System.Drawing.Point(345, 311);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(240, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add New Entry";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(882, 459);
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
    }
}