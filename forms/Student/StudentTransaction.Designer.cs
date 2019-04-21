namespace Finance_Management.forms.Student_Info
{
    partial class StudentTransaction
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
            this.USNBox = new System.Windows.Forms.TextBox();
            this.LabelUSN = new System.Windows.Forms.Label();
            this.CategoryList = new System.Windows.Forms.ListBox();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelAmount = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.Credit = new System.Windows.Forms.RadioButton();
            this.Debit = new System.Windows.Forms.RadioButton();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // USNBox
            // 
            this.USNBox.Location = new System.Drawing.Point(150, 41);
            this.USNBox.MaxLength = 10;
            this.USNBox.Name = "USNBox";
            this.USNBox.Size = new System.Drawing.Size(100, 22);
            this.USNBox.TabIndex = 1;
            // 
            // LabelUSN
            // 
            this.LabelUSN.AutoSize = true;
            this.LabelUSN.Location = new System.Drawing.Point(48, 45);
            this.LabelUSN.Name = "LabelUSN";
            this.LabelUSN.Size = new System.Drawing.Size(37, 17);
            this.LabelUSN.TabIndex = 1;
            this.LabelUSN.Text = "USN";
            this.LabelUSN.Click += new System.EventHandler(this.LabelUSN_Click);
            // 
            // CategoryList
            // 
            this.CategoryList.Cursor = System.Windows.Forms.Cursors.Cross;
            this.CategoryList.FormattingEnabled = true;
            this.CategoryList.ItemHeight = 16;
            this.CategoryList.Items.AddRange(new object[] {
            "College: ID Card Charges",
            "College: Library Charges",
            "College: Make Up Exam",
            "College: Miscellaneous",
            "College: Re-Evaluation",
            "College: Tuition Fee",
            "Hostel: Fees",
            "Hostel: Miscellaneous",
            "Hostel: Security Deposit"});
            this.CategoryList.Location = new System.Drawing.Point(97, 217);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(202, 84);
            this.CategoryList.Sorted = true;
            this.CategoryList.TabIndex = 5;
            this.CategoryList.SelectedValueChanged += new System.EventHandler(this.CategoryList_SelectedValueChanged);
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(12, 229);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(65, 17);
            this.LabelCategory.TabIndex = 3;
            this.LabelCategory.Text = "Category";
            // 
            // LabelAmount
            // 
            this.LabelAmount.AutoSize = true;
            this.LabelAmount.Location = new System.Drawing.Point(48, 109);
            this.LabelAmount.Name = "LabelAmount";
            this.LabelAmount.Size = new System.Drawing.Size(56, 17);
            this.LabelAmount.TabIndex = 4;
            this.LabelAmount.Text = "Amount";
            this.LabelAmount.Click += new System.EventHandler(this.LabelAmount_Click);
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(150, 104);
            this.AmountBox.MaxLength = 9;
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(100, 22);
            this.AmountBox.TabIndex = 2;
            // 
            // Credit
            // 
            this.Credit.AutoSize = true;
            this.Credit.Checked = true;
            this.Credit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Credit.Location = new System.Drawing.Point(150, 163);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(66, 21);
            this.Credit.TabIndex = 3;
            this.Credit.TabStop = true;
            this.Credit.Text = "Credit";
            this.Credit.UseVisualStyleBackColor = true;
            // 
            // Debit
            // 
            this.Debit.AutoSize = true;
            this.Debit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Debit.Enabled = false;
            this.Debit.Location = new System.Drawing.Point(222, 163);
            this.Debit.Name = "Debit";
            this.Debit.Size = new System.Drawing.Size(62, 21);
            this.Debit.TabIndex = 4;
            this.Debit.Text = "Debit";
            this.Debit.UseVisualStyleBackColor = true;
            // 
            // DataView
            // 
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(369, 6);
            this.DataView.Name = "DataView";
            this.DataView.RowTemplate.Height = 24;
            this.DataView.Size = new System.Drawing.Size(480, 192);
            this.DataView.TabIndex = 8;
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(459, 229);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(53, 17);
            this.LabelSearch.TabIndex = 9;
            this.LabelSearch.Text = "Search";
            this.LabelSearch.Click += new System.EventHandler(this.LabelSearch_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(587, 226);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(100, 22);
            this.SearchBox.TabIndex = 7;
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // Submit
            // 
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.Location = new System.Drawing.Point(150, 403);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Back
            // 
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Location = new System.Drawing.Point(13, 13);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 9;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // StudentTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 459);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.Debit);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.LabelAmount);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.CategoryList);
            this.Controls.Add(this.LabelUSN);
            this.Controls.Add(this.USNBox);
            this.Name = "StudentTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Transaction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentTransaction_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox USNBox;
        private System.Windows.Forms.Label LabelUSN;
        private System.Windows.Forms.ListBox CategoryList;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelAmount;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.RadioButton Credit;
        private System.Windows.Forms.RadioButton Debit;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Back;
    }
}