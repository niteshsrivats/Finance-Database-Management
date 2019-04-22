namespace Finance_Management.forms.Scholarship
{
    partial class ScholarshipTransaction
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
            this.Submit = new System.Windows.Forms.Button();
            this.LabelScholarshipName = new System.Windows.Forms.Label();
            this.LabelUSN = new System.Windows.Forms.Label();
            this.USNBox = new System.Windows.Forms.TextBox();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.ScholarshipNameList = new System.Windows.Forms.ListBox();
            this.LabelAmount = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.Window;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Submit.Location = new System.Drawing.Point(400, 398);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(93, 34);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // LabelScholarshipName
            // 
            this.LabelScholarshipName.AutoSize = true;
            this.LabelScholarshipName.Location = new System.Drawing.Point(10, 315);
            this.LabelScholarshipName.Name = "LabelScholarshipName";
            this.LabelScholarshipName.Size = new System.Drawing.Size(123, 17);
            this.LabelScholarshipName.TabIndex = 2;
            this.LabelScholarshipName.Text = "Scholarship Name";
            // 
            // LabelUSN
            // 
            this.LabelUSN.AutoSize = true;
            this.LabelUSN.Location = new System.Drawing.Point(30, 109);
            this.LabelUSN.Name = "LabelUSN";
            this.LabelUSN.Size = new System.Drawing.Size(37, 17);
            this.LabelUSN.TabIndex = 3;
            this.LabelUSN.Text = "USN";
            this.LabelUSN.Click += new System.EventHandler(this.LabelUSN_Click);
            // 
            // USNBox
            // 
            this.USNBox.Location = new System.Drawing.Point(149, 106);
            this.USNBox.MaxLength = 10;
            this.USNBox.Name = "USNBox";
            this.USNBox.Size = new System.Drawing.Size(125, 22);
            this.USNBox.TabIndex = 1;
            // 
            // DataView
            // 
            this.DataView.AllowUserToOrderColumns = true;
            this.DataView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(379, 36);
            this.DataView.Name = "DataView";
            this.DataView.RowTemplate.Height = 24;
            this.DataView.Size = new System.Drawing.Size(480, 210);
            this.DataView.TabIndex = 6;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(657, 315);
            this.SearchBox.MaxLength = 255;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(125, 22);
            this.SearchBox.TabIndex = 5;
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(538, 320);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(53, 17);
            this.LabelSearch.TabIndex = 7;
            this.LabelSearch.Text = "Search";
            this.LabelSearch.Click += new System.EventHandler(this.LabelSearch_Click);
            // 
            // ScholarshipNameList
            // 
            this.ScholarshipNameList.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ScholarshipNameList.FormattingEnabled = true;
            this.ScholarshipNameList.ItemHeight = 16;
            this.ScholarshipNameList.Items.AddRange(new object[] {
            "Bal Vidhya Scholarship",
            "Excel Student Scholarship",
            "Girl Child Scholarship",
            "KCET Scholarship For Defence Wards",
            "Krishi Vidhya Scholarship",
            "Maritime Scholarship For Engineers",
            "National College Scholarship",
            "NCC Scholarship For Undergraduates",
            "SC/ST Undergraduates Scholarship",
            "Sri Visveswaraya Scholarship"});
            this.ScholarshipNameList.Location = new System.Drawing.Point(149, 274);
            this.ScholarshipNameList.Name = "ScholarshipNameList";
            this.ScholarshipNameList.Size = new System.Drawing.Size(266, 100);
            this.ScholarshipNameList.Sorted = true;
            this.ScholarshipNameList.TabIndex = 3;
            // 
            // LabelAmount
            // 
            this.LabelAmount.AutoSize = true;
            this.LabelAmount.Location = new System.Drawing.Point(30, 188);
            this.LabelAmount.Name = "LabelAmount";
            this.LabelAmount.Size = new System.Drawing.Size(56, 17);
            this.LabelAmount.TabIndex = 9;
            this.LabelAmount.Text = "Amount";
            this.LabelAmount.Click += new System.EventHandler(this.LabelAmount_Click);
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(149, 185);
            this.AmountBox.MaxLength = 9;
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(125, 22);
            this.AmountBox.TabIndex = 2;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.Window;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Location = new System.Drawing.Point(13, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(93, 34);
            this.Back.TabIndex = 7;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ScholarshipTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 459);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.LabelAmount);
            this.Controls.Add(this.ScholarshipNameList);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.USNBox);
            this.Controls.Add(this.LabelUSN);
            this.Controls.Add(this.LabelScholarshipName);
            this.Controls.Add(this.Submit);
            this.Name = "ScholarshipTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scholarship Transaction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScholarshipTransaction_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label LabelScholarshipName;
        private System.Windows.Forms.Label LabelUSN;
        private System.Windows.Forms.TextBox USNBox;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.ListBox ScholarshipNameList;
        private System.Windows.Forms.Label LabelAmount;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Button Back;
    }
}