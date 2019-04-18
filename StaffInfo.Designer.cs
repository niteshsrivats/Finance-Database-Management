namespace Finance_Management
{
    partial class StaffInfo
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
            this.SuspendLayout();
            // 
            // EmployeeIDBox
            // 
            this.EmployeeIDBox.Location = new System.Drawing.Point(367, 58);
            this.EmployeeIDBox.Name = "EmployeeIDBox";
            this.EmployeeIDBox.Size = new System.Drawing.Size(100, 22);
            this.EmployeeIDBox.TabIndex = 0;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(367, 139);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 22);
            this.NameBox.TabIndex = 1;
            // 
            // LabelEmployeeID
            // 
            this.LabelEmployeeID.AutoSize = true;
            this.LabelEmployeeID.Location = new System.Drawing.Point(222, 63);
            this.LabelEmployeeID.Name = "LabelEmployeeID";
            this.LabelEmployeeID.Size = new System.Drawing.Size(87, 17);
            this.LabelEmployeeID.TabIndex = 4;
            this.LabelEmployeeID.Text = "Employee ID";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(222, 144);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(45, 17);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "Name";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(377, 359);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 10;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // TypeList
            // 
            this.TypeList.FormattingEnabled = true;
            this.TypeList.ItemHeight = 16;
            this.TypeList.Items.AddRange(new object[] {
            "Hostel",
            "Non - Teaching Staff",
            "Security",
            "Teaching Staff"});
            this.TypeList.Location = new System.Drawing.Point(367, 198);
            this.TypeList.Name = "TypeList";
            this.TypeList.Size = new System.Drawing.Size(140, 36);
            this.TypeList.Sorted = true;
            this.TypeList.TabIndex = 11;
            this.TypeList.SelectedIndexChanged += new System.EventHandler(this.TypeList_SelectedIndexChanged);
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Location = new System.Drawing.Point(225, 217);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(40, 17);
            this.LabelType.TabIndex = 14;
            this.LabelType.Text = "Type";
            // 
            // LabelDesignation
            // 
            this.LabelDesignation.AutoSize = true;
            this.LabelDesignation.Location = new System.Drawing.Point(225, 310);
            this.LabelDesignation.Name = "LabelDesignation";
            this.LabelDesignation.Size = new System.Drawing.Size(83, 17);
            this.LabelDesignation.TabIndex = 15;
            this.LabelDesignation.Text = "Designation";
            this.LabelDesignation.Visible = false;
            // 
            // DesignationList
            // 
            this.DesignationList.FormattingEnabled = true;
            this.DesignationList.ItemHeight = 16;
            this.DesignationList.Location = new System.Drawing.Point(367, 291);
            this.DesignationList.Name = "DesignationList";
            this.DesignationList.Size = new System.Drawing.Size(140, 36);
            this.DesignationList.Sorted = true;
            this.DesignationList.TabIndex = 16;
            this.DesignationList.Visible = false;
            // 
            // StaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DesignationList);
            this.Controls.Add(this.LabelDesignation);
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.TypeList);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelEmployeeID);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.EmployeeIDBox);
            this.Name = "StaffInfo";
            this.Text = "StaffInfo";
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
    }
}