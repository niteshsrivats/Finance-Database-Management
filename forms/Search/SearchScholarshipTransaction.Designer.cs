namespace Finance_Management.forms.Search
{
    partial class SearchScholarshipTransaction
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
            this.Back = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.USNBox = new System.Windows.Forms.TextBox();
            this.ScholarshipNameBox = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelUSN = new System.Windows.Forms.Label();
            this.LabelScholarshipName = new System.Windows.Forms.Label();
            this.YearList = new System.Windows.Forms.ListBox();
            this.MonthList = new System.Windows.Forms.ListBox();
            this.DayList = new System.Windows.Forms.ListBox();
            this.HourList = new System.Windows.Forms.ListBox();
            this.MinuteList = new System.Windows.Forms.ListBox();
            this.AMPMList = new System.Windows.Forms.ListBox();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelTo = new System.Windows.Forms.Label();
            this.YearToList = new System.Windows.Forms.ListBox();
            this.MonthToList = new System.Windows.Forms.ListBox();
            this.DayToList = new System.Windows.Forms.ListBox();
            this.HourToList = new System.Windows.Forms.ListBox();
            this.MinuteToList = new System.Windows.Forms.ListBox();
            this.AMPMToList = new System.Windows.Forms.ListBox();
            this.LabelAmount = new System.Windows.Forms.Label();
            this.LabelAmountTo = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.AmountToBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.Window;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Location = new System.Drawing.Point(40, 30);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(80, 30);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.Window;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search.Location = new System.Drawing.Point(410, 400);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(80, 30);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // DataView
            // 
            this.DataView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(390, 60);
            this.DataView.Name = "DataView";
            this.DataView.RowTemplate.Height = 24;
            this.DataView.Size = new System.Drawing.Size(480, 185);
            this.DataView.TabIndex = 2;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(180, 95);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 22);
            this.NameBox.TabIndex = 3;
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // USNBox
            // 
            this.USNBox.Location = new System.Drawing.Point(180, 150);
            this.USNBox.Name = "USNBox";
            this.USNBox.Size = new System.Drawing.Size(100, 22);
            this.USNBox.TabIndex = 4;
            this.USNBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.USNBox_KeyPress);
            // 
            // ScholarshipNameBox
            // 
            this.ScholarshipNameBox.Location = new System.Drawing.Point(180, 205);
            this.ScholarshipNameBox.Name = "ScholarshipNameBox";
            this.ScholarshipNameBox.Size = new System.Drawing.Size(100, 22);
            this.ScholarshipNameBox.TabIndex = 5;
            this.ScholarshipNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ScholarshipNameBox_KeyPress);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(110, 98);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(45, 17);
            this.LabelName.TabIndex = 6;
            this.LabelName.Text = "Name";
            this.LabelName.Click += new System.EventHandler(this.LabelName_Click);
            // 
            // LabelUSN
            // 
            this.LabelUSN.AutoSize = true;
            this.LabelUSN.Location = new System.Drawing.Point(110, 153);
            this.LabelUSN.Name = "LabelUSN";
            this.LabelUSN.Size = new System.Drawing.Size(37, 17);
            this.LabelUSN.TabIndex = 7;
            this.LabelUSN.Text = "USN";
            this.LabelUSN.Click += new System.EventHandler(this.LabelUSN_Click);
            // 
            // LabelScholarshipName
            // 
            this.LabelScholarshipName.AutoSize = true;
            this.LabelScholarshipName.Location = new System.Drawing.Point(32, 208);
            this.LabelScholarshipName.Name = "LabelScholarshipName";
            this.LabelScholarshipName.Size = new System.Drawing.Size(123, 17);
            this.LabelScholarshipName.TabIndex = 8;
            this.LabelScholarshipName.Text = "Scholarship Name";
            this.LabelScholarshipName.Click += new System.EventHandler(this.LabelScholarshipName_Click);
            // 
            // YearList
            // 
            this.YearList.FormattingEnabled = true;
            this.YearList.ItemHeight = 16;
            this.YearList.Location = new System.Drawing.Point(45, 268);
            this.YearList.Name = "YearList";
            this.YearList.Size = new System.Drawing.Size(65, 36);
            this.YearList.TabIndex = 9;
            this.YearList.SelectedIndexChanged += new System.EventHandler(this.YearList_SelectedIndexChanged);
            // 
            // MonthList
            // 
            this.MonthList.FormattingEnabled = true;
            this.MonthList.ItemHeight = 16;
            this.MonthList.Location = new System.Drawing.Point(130, 268);
            this.MonthList.Name = "MonthList";
            this.MonthList.Size = new System.Drawing.Size(50, 36);
            this.MonthList.TabIndex = 10;
            this.MonthList.Visible = false;
            this.MonthList.SelectedIndexChanged += new System.EventHandler(this.MonthList_SelectedIndexChanged);
            // 
            // DayList
            // 
            this.DayList.FormattingEnabled = true;
            this.DayList.ItemHeight = 16;
            this.DayList.Location = new System.Drawing.Point(195, 268);
            this.DayList.Name = "DayList";
            this.DayList.Size = new System.Drawing.Size(50, 36);
            this.DayList.TabIndex = 11;
            this.DayList.Visible = false;
            this.DayList.SelectedIndexChanged += new System.EventHandler(this.DayList_SelectedIndexChanged);
            // 
            // HourList
            // 
            this.HourList.FormattingEnabled = true;
            this.HourList.ItemHeight = 16;
            this.HourList.Location = new System.Drawing.Point(260, 268);
            this.HourList.Name = "HourList";
            this.HourList.Size = new System.Drawing.Size(50, 36);
            this.HourList.TabIndex = 12;
            this.HourList.Visible = false;
            this.HourList.SelectedIndexChanged += new System.EventHandler(this.HourList_SelectedIndexChanged);
            // 
            // MinuteList
            // 
            this.MinuteList.FormattingEnabled = true;
            this.MinuteList.ItemHeight = 16;
            this.MinuteList.Location = new System.Drawing.Point(325, 268);
            this.MinuteList.Name = "MinuteList";
            this.MinuteList.Size = new System.Drawing.Size(50, 36);
            this.MinuteList.TabIndex = 13;
            this.MinuteList.Visible = false;
            // 
            // AMPMList
            // 
            this.AMPMList.FormattingEnabled = true;
            this.AMPMList.ItemHeight = 16;
            this.AMPMList.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.AMPMList.Location = new System.Drawing.Point(390, 268);
            this.AMPMList.Name = "AMPMList";
            this.AMPMList.Size = new System.Drawing.Size(50, 36);
            this.AMPMList.TabIndex = 14;
            this.AMPMList.Visible = false;
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(0, 278);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(39, 17);
            this.LabelTime.TabIndex = 15;
            this.LabelTime.Text = "Time";
            // 
            // LabelTo
            // 
            this.LabelTo.AutoSize = true;
            this.LabelTo.Location = new System.Drawing.Point(0, 342);
            this.LabelTo.Name = "LabelTo";
            this.LabelTo.Size = new System.Drawing.Size(25, 17);
            this.LabelTo.TabIndex = 16;
            this.LabelTo.Text = "To";
            // 
            // YearToList
            // 
            this.YearToList.FormattingEnabled = true;
            this.YearToList.ItemHeight = 16;
            this.YearToList.Location = new System.Drawing.Point(44, 333);
            this.YearToList.Name = "YearToList";
            this.YearToList.Size = new System.Drawing.Size(65, 36);
            this.YearToList.TabIndex = 17;
            this.YearToList.SelectedIndexChanged += new System.EventHandler(this.YearToList_SelectedIndexChanged);
            // 
            // MonthToList
            // 
            this.MonthToList.FormattingEnabled = true;
            this.MonthToList.ItemHeight = 16;
            this.MonthToList.Location = new System.Drawing.Point(130, 333);
            this.MonthToList.Name = "MonthToList";
            this.MonthToList.Size = new System.Drawing.Size(50, 36);
            this.MonthToList.TabIndex = 18;
            this.MonthToList.Visible = false;
            this.MonthToList.SelectedIndexChanged += new System.EventHandler(this.MonthToList_SelectedIndexChanged);
            // 
            // DayToList
            // 
            this.DayToList.FormattingEnabled = true;
            this.DayToList.ItemHeight = 16;
            this.DayToList.Location = new System.Drawing.Point(195, 333);
            this.DayToList.Name = "DayToList";
            this.DayToList.Size = new System.Drawing.Size(50, 36);
            this.DayToList.TabIndex = 19;
            this.DayToList.Visible = false;
            this.DayToList.SelectedIndexChanged += new System.EventHandler(this.DayToList_SelectedIndexChanged);
            // 
            // HourToList
            // 
            this.HourToList.FormattingEnabled = true;
            this.HourToList.ItemHeight = 16;
            this.HourToList.Location = new System.Drawing.Point(260, 333);
            this.HourToList.Name = "HourToList";
            this.HourToList.Size = new System.Drawing.Size(50, 36);
            this.HourToList.TabIndex = 20;
            this.HourToList.Visible = false;
            this.HourToList.SelectedIndexChanged += new System.EventHandler(this.HourToList_SelectedIndexChanged);
            // 
            // MinuteToList
            // 
            this.MinuteToList.FormattingEnabled = true;
            this.MinuteToList.ItemHeight = 16;
            this.MinuteToList.Location = new System.Drawing.Point(325, 333);
            this.MinuteToList.Name = "MinuteToList";
            this.MinuteToList.Size = new System.Drawing.Size(50, 36);
            this.MinuteToList.TabIndex = 21;
            this.MinuteToList.Visible = false;
            // 
            // AMPMToList
            // 
            this.AMPMToList.FormattingEnabled = true;
            this.AMPMToList.ItemHeight = 16;
            this.AMPMToList.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.AMPMToList.Location = new System.Drawing.Point(390, 332);
            this.AMPMToList.Name = "AMPMToList";
            this.AMPMToList.Size = new System.Drawing.Size(50, 36);
            this.AMPMToList.TabIndex = 22;
            this.AMPMToList.Visible = false;
            // 
            // LabelAmount
            // 
            this.LabelAmount.AutoSize = true;
            this.LabelAmount.Location = new System.Drawing.Point(594, 278);
            this.LabelAmount.Name = "LabelAmount";
            this.LabelAmount.Size = new System.Drawing.Size(56, 17);
            this.LabelAmount.TabIndex = 23;
            this.LabelAmount.Text = "Amount";
            this.LabelAmount.Click += new System.EventHandler(this.LabelAmount_Click);
            // 
            // LabelAmountTo
            // 
            this.LabelAmountTo.AutoSize = true;
            this.LabelAmountTo.Location = new System.Drawing.Point(594, 338);
            this.LabelAmountTo.Name = "LabelAmountTo";
            this.LabelAmountTo.Size = new System.Drawing.Size(25, 17);
            this.LabelAmountTo.TabIndex = 24;
            this.LabelAmountTo.Text = "To";
            this.LabelAmountTo.Click += new System.EventHandler(this.LabelAmountTo_Click);
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(670, 275);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(100, 22);
            this.AmountBox.TabIndex = 25;
            this.AmountBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountBox_KeyPress);
            // 
            // AmountToBox
            // 
            this.AmountToBox.Location = new System.Drawing.Point(670, 335);
            this.AmountToBox.Name = "AmountToBox";
            this.AmountToBox.Size = new System.Drawing.Size(100, 22);
            this.AmountToBox.TabIndex = 26;
            this.AmountToBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountToBox_KeyPress);
            // 
            // SearchScholarshipTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 459);
            this.Controls.Add(this.AmountToBox);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.LabelAmountTo);
            this.Controls.Add(this.LabelAmount);
            this.Controls.Add(this.AMPMToList);
            this.Controls.Add(this.MinuteToList);
            this.Controls.Add(this.HourToList);
            this.Controls.Add(this.DayToList);
            this.Controls.Add(this.MonthToList);
            this.Controls.Add(this.YearToList);
            this.Controls.Add(this.LabelTo);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.AMPMList);
            this.Controls.Add(this.MinuteList);
            this.Controls.Add(this.HourList);
            this.Controls.Add(this.DayList);
            this.Controls.Add(this.MonthList);
            this.Controls.Add(this.YearList);
            this.Controls.Add(this.LabelScholarshipName);
            this.Controls.Add(this.LabelUSN);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.ScholarshipNameBox);
            this.Controls.Add(this.USNBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Back);
            this.Name = "SearchScholarshipTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchScholarship";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchScholarshipTransaction_FormClosing);
            this.Load += new System.EventHandler(this.SearchScholarshipTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox USNBox;
        private System.Windows.Forms.TextBox ScholarshipNameBox;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelUSN;
        private System.Windows.Forms.Label LabelScholarshipName;
        private System.Windows.Forms.ListBox YearList;
        private System.Windows.Forms.ListBox MonthList;
        private System.Windows.Forms.ListBox DayList;
        private System.Windows.Forms.ListBox HourList;
        private System.Windows.Forms.ListBox MinuteList;
        private System.Windows.Forms.ListBox AMPMList;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelTo;
        private System.Windows.Forms.ListBox YearToList;
        private System.Windows.Forms.ListBox MonthToList;
        private System.Windows.Forms.ListBox DayToList;
        private System.Windows.Forms.ListBox HourToList;
        private System.Windows.Forms.ListBox MinuteToList;
        private System.Windows.Forms.ListBox AMPMToList;
        private System.Windows.Forms.Label LabelAmount;
        private System.Windows.Forms.Label LabelAmountTo;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.TextBox AmountToBox;
    }
}