namespace Finance_Management
{
    partial class NewStaffEntry
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
            this.EmployeeIDBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.LabelEmployeeID = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.TypeList = new System.Windows.Forms.ListBox();
            this.LabelType = new System.Windows.Forms.Label();
            this.LabelDesignation = new System.Windows.Forms.Label();
            this.DesignationList = new System.Windows.Forms.ListBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeIDBox
            // 
            this.EmployeeIDBox.Location = new System.Drawing.Point(400, 54);
            this.EmployeeIDBox.MaxLength = 7;
            this.EmployeeIDBox.Name = "EmployeeIDBox";
            this.EmployeeIDBox.Size = new System.Drawing.Size(100, 22);
            this.EmployeeIDBox.TabIndex = 0;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(400, 124);
            this.NameBox.MaxLength = 255;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 22);
            this.NameBox.TabIndex = 1;
            // 
            // LabelEmployeeID
            // 
            this.LabelEmployeeID.AutoSize = true;
            this.LabelEmployeeID.Location = new System.Drawing.Point(277, 57);
            this.LabelEmployeeID.Name = "LabelEmployeeID";
            this.LabelEmployeeID.Size = new System.Drawing.Size(87, 17);
            this.LabelEmployeeID.TabIndex = 4;
            this.LabelEmployeeID.Text = "Employee ID";
            this.LabelEmployeeID.Click += new System.EventHandler(this.LabelEmployeeID_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(277, 127);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(45, 17);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "Name";
            this.LabelName.Click += new System.EventHandler(this.LabelName_Click);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.Window;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Submit.Location = new System.Drawing.Point(410, 400);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(80, 30);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // TypeList
            // 
            this.TypeList.Cursor = System.Windows.Forms.Cursors.Cross;
            this.TypeList.FormattingEnabled = true;
            this.TypeList.ItemHeight = 16;
            this.TypeList.Items.AddRange(new object[] {
            "Hostel",
            "Non - Teaching Staff",
            "Security",
            "Teaching Staff"});
            this.TypeList.Location = new System.Drawing.Point(380, 194);
            this.TypeList.Name = "TypeList";
            this.TypeList.Size = new System.Drawing.Size(140, 68);
            this.TypeList.Sorted = true;
            this.TypeList.TabIndex = 2;
            this.TypeList.SelectedIndexChanged += new System.EventHandler(this.TypeList_SelectedIndexChanged);
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Location = new System.Drawing.Point(277, 220);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(40, 17);
            this.LabelType.TabIndex = 14;
            this.LabelType.Text = "Type";
            // 
            // LabelDesignation
            // 
            this.LabelDesignation.AutoSize = true;
            this.LabelDesignation.Location = new System.Drawing.Point(277, 323);
            this.LabelDesignation.Name = "LabelDesignation";
            this.LabelDesignation.Size = new System.Drawing.Size(83, 17);
            this.LabelDesignation.TabIndex = 15;
            this.LabelDesignation.Text = "Designation";
            this.LabelDesignation.Visible = false;
            // 
            // DesignationList
            // 
            this.DesignationList.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DesignationList.FormattingEnabled = true;
            this.DesignationList.ItemHeight = 16;
            this.DesignationList.Location = new System.Drawing.Point(380, 314);
            this.DesignationList.Name = "DesignationList";
            this.DesignationList.Size = new System.Drawing.Size(140, 36);
            this.DesignationList.Sorted = true;
            this.DesignationList.TabIndex = 3;
            this.DesignationList.Visible = false;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.Window;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Location = new System.Drawing.Point(40, 30);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(80, 30);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // NewStaffEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 459);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.DesignationList);
            this.Controls.Add(this.LabelDesignation);
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.TypeList);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelEmployeeID);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.EmployeeIDBox);
            this.Name = "NewStaffEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Staff Entry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffInfo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmployeeIDBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label LabelEmployeeID;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ListBox TypeList;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label LabelDesignation;
        private System.Windows.Forms.ListBox DesignationList;
        private System.Windows.Forms.Button Back;
    }
}