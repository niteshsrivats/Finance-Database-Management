namespace Finance_Management
{
    partial class StudentInfo
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
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelUsn = new System.Windows.Forms.Label();
            this.LabelDob = new System.Windows.Forms.Label();
            this.LabelHostel = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.USNBox = new System.Windows.Forms.TextBox();
            this.DOBBox = new System.Windows.Forms.TextBox();
            this.YesButton = new System.Windows.Forms.RadioButton();
            this.NoButton = new System.Windows.Forms.RadioButton();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LabelName.Location = new System.Drawing.Point(295, 116);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(45, 17);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Name";
            this.LabelName.Click += new System.EventHandler(this.LabelName_Click);
            // 
            // LabelUsn
            // 
            this.LabelUsn.AutoSize = true;
            this.LabelUsn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LabelUsn.Location = new System.Drawing.Point(295, 188);
            this.LabelUsn.Name = "LabelUsn";
            this.LabelUsn.Size = new System.Drawing.Size(37, 17);
            this.LabelUsn.TabIndex = 1;
            this.LabelUsn.Text = "USN";
            this.LabelUsn.Click += new System.EventHandler(this.LabelUsn_Click);
            // 
            // LabelDob
            // 
            this.LabelDob.AutoSize = true;
            this.LabelDob.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LabelDob.Location = new System.Drawing.Point(295, 260);
            this.LabelDob.Name = "LabelDob";
            this.LabelDob.Size = new System.Drawing.Size(88, 34);
            this.LabelDob.TabIndex = 2;
            this.LabelDob.Text = "      DOB\r\n(YY-MM-DD)";
            this.LabelDob.Click += new System.EventHandler(this.LabelDob_Click);
            // 
            // LabelHostel
            // 
            this.LabelHostel.AutoSize = true;
            this.LabelHostel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LabelHostel.Location = new System.Drawing.Point(295, 331);
            this.LabelHostel.Name = "LabelHostel";
            this.LabelHostel.Size = new System.Drawing.Size(48, 17);
            this.LabelHostel.TabIndex = 4;
            this.LabelHostel.Text = "Hostel";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.Window;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Submit.Location = new System.Drawing.Point(410, 400);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(80, 30);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.Window;
            this.NameBox.Location = new System.Drawing.Point(400, 113);
            this.NameBox.MaxLength = 255;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 22);
            this.NameBox.TabIndex = 1;
            // 
            // USNBox
            // 
            this.USNBox.BackColor = System.Drawing.SystemColors.Window;
            this.USNBox.Location = new System.Drawing.Point(400, 185);
            this.USNBox.MaxLength = 10;
            this.USNBox.Name = "USNBox";
            this.USNBox.Size = new System.Drawing.Size(99, 22);
            this.USNBox.TabIndex = 2;
            // 
            // DOBBox
            // 
            this.DOBBox.Location = new System.Drawing.Point(400, 257);
            this.DOBBox.MaxLength = 10;
            this.DOBBox.Name = "DOBBox";
            this.DOBBox.Size = new System.Drawing.Size(100, 22);
            this.DOBBox.TabIndex = 3;
            // 
            // YesButton
            // 
            this.YesButton.AutoSize = true;
            this.YesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YesButton.Location = new System.Drawing.Point(400, 329);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(53, 21);
            this.YesButton.TabIndex = 4;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            // 
            // NoButton
            // 
            this.NoButton.AutoSize = true;
            this.NoButton.Checked = true;
            this.NoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoButton.Location = new System.Drawing.Point(452, 329);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(47, 21);
            this.NoButton.TabIndex = 5;
            this.NoButton.TabStop = true;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.Window;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Location = new System.Drawing.Point(40, 30);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(80, 30);
            this.Back.TabIndex = 7;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 459);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.DOBBox);
            this.Controls.Add(this.USNBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.LabelHostel);
            this.Controls.Add(this.LabelDob);
            this.Controls.Add(this.LabelUsn);
            this.Controls.Add(this.LabelName);
            this.Name = "StudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentInfo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelUsn;
        private System.Windows.Forms.Label LabelDob;
        private System.Windows.Forms.Label LabelHostel;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox USNBox;
        private System.Windows.Forms.TextBox DOBBox;
        private System.Windows.Forms.RadioButton YesButton;
        private System.Windows.Forms.RadioButton NoButton;
        private System.Windows.Forms.Button Back;
    }
}