﻿namespace Finance_Management.forms.Navigation
{
    partial class StudentTransactionMenu
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
            this.Scholarship = new System.Windows.Forms.Button();
            this.College = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Scholarship
            // 
            this.Scholarship.BackColor = System.Drawing.SystemColors.Window;
            this.Scholarship.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Scholarship.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Scholarship.Location = new System.Drawing.Point(264, 162);
            this.Scholarship.Name = "Scholarship";
            this.Scholarship.Size = new System.Drawing.Size(363, 32);
            this.Scholarship.TabIndex = 0;
            this.Scholarship.Text = "Scholarship";
            this.Scholarship.UseVisualStyleBackColor = false;
            this.Scholarship.Click += new System.EventHandler(this.Scholarship_Click);
            // 
            // College
            // 
            this.College.BackColor = System.Drawing.SystemColors.Window;
            this.College.Cursor = System.Windows.Forms.Cursors.Hand;
            this.College.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.College.Location = new System.Drawing.Point(264, 246);
            this.College.Name = "College";
            this.College.Size = new System.Drawing.Size(363, 32);
            this.College.TabIndex = 1;
            this.College.Text = "College";
            this.College.UseVisualStyleBackColor = false;
            this.College.Click += new System.EventHandler(this.College_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.Window;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Location = new System.Drawing.Point(44, 34);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(93, 34);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // StudentTransactionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 459);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.College);
            this.Controls.Add(this.Scholarship);
            this.Name = "StudentTransactionMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Transaction Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentTransactionMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Scholarship;
        private System.Windows.Forms.Button College;
        private System.Windows.Forms.Button Back;
    }
}