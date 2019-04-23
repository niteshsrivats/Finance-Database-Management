namespace Finance_Management.forms
{
    partial class SearchStudentTransaction
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.USNBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelUSN = new System.Windows.Forms.Label();
            this.LabelType = new System.Windows.Forms.Label();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.AmountToBox = new System.Windows.Forms.TextBox();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.LabelTo = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelAmount = new System.Windows.Forms.Label();
            this.LabelAmountTo = new System.Windows.Forms.Label();
            this.YearList = new System.Windows.Forms.ListBox();
            this.MonthList = new System.Windows.Forms.ListBox();
            this.DayList = new System.Windows.Forms.ListBox();
            this.HourList = new System.Windows.Forms.ListBox();
            this.MinuteList = new System.Windows.Forms.ListBox();
            this.AMPMList = new System.Windows.Forms.ListBox();
            this.YearToList = new System.Windows.Forms.ListBox();
            this.MonthToList = new System.Windows.Forms.ListBox();
            this.DayToList = new System.Windows.Forms.ListBox();
            this.HourToList = new System.Windows.Forms.ListBox();
            this.MinuteToList = new System.Windows.Forms.ListBox();
            this.AMPMToList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.Window;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Location = new System.Drawing.Point(40, 30);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(80, 30);
            this.Back.TabIndex = 19;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(180, 95);
            this.NameBox.MaxLength = 255;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 22);
            this.NameBox.TabIndex = 0;
            // 
            // USNBox
            // 
            this.USNBox.Location = new System.Drawing.Point(180, 150);
            this.USNBox.MaxLength = 10;
            this.USNBox.Name = "USNBox";
            this.USNBox.Size = new System.Drawing.Size(100, 22);
            this.USNBox.TabIndex = 1;
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(180, 205);
            this.TypeBox.MaxLength = 30;
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(100, 22);
            this.TypeBox.TabIndex = 2;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(110, 98);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(45, 17);
            this.LabelName.TabIndex = 4;
            this.LabelName.Text = "Name";
            this.LabelName.Click += new System.EventHandler(this.LabelName_Click);
            // 
            // LabelUSN
            // 
            this.LabelUSN.AutoSize = true;
            this.LabelUSN.Location = new System.Drawing.Point(110, 153);
            this.LabelUSN.Name = "LabelUSN";
            this.LabelUSN.Size = new System.Drawing.Size(37, 17);
            this.LabelUSN.TabIndex = 5;
            this.LabelUSN.Text = "USN";
            this.LabelUSN.Click += new System.EventHandler(this.LabelUSN_Click);
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Location = new System.Drawing.Point(110, 208);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(40, 17);
            this.LabelType.TabIndex = 6;
            this.LabelType.Text = "Type";
            this.LabelType.Click += new System.EventHandler(this.LabelType_Click);
            // 
            // DataView
            // 
            this.DataView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(390, 60);
            this.DataView.Name = "DataView";
            this.DataView.RowTemplate.Height = 24;
            this.DataView.Size = new System.Drawing.Size(480, 197);
            this.DataView.TabIndex = 17;
            // 
            // AmountToBox
            // 
            this.AmountToBox.Location = new System.Drawing.Point(670, 335);
            this.AmountToBox.MaxLength = 9;
            this.AmountToBox.Name = "AmountToBox";
            this.AmountToBox.Size = new System.Drawing.Size(100, 22);
            this.AmountToBox.TabIndex = 16;
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(670, 275);
            this.AmountBox.MaxLength = 9;
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(100, 22);
            this.AmountBox.TabIndex = 15;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.Window;
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search.Location = new System.Drawing.Point(410, 400);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(80, 30);
            this.Search.TabIndex = 18;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // LabelTo
            // 
            this.LabelTo.AutoSize = true;
            this.LabelTo.Location = new System.Drawing.Point(0, 342);
            this.LabelTo.Name = "LabelTo";
            this.LabelTo.Size = new System.Drawing.Size(25, 17);
            this.LabelTo.TabIndex = 22;
            this.LabelTo.Text = "To";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(0, 278);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(39, 17);
            this.LabelTime.TabIndex = 23;
            this.LabelTime.Text = "Time";
            // 
            // LabelAmount
            // 
            this.LabelAmount.AutoSize = true;
            this.LabelAmount.Location = new System.Drawing.Point(594, 278);
            this.LabelAmount.Name = "LabelAmount";
            this.LabelAmount.Size = new System.Drawing.Size(56, 17);
            this.LabelAmount.TabIndex = 24;
            this.LabelAmount.Text = "Amount";
            this.LabelAmount.Click += new System.EventHandler(this.LabelAmount_Click);
            // 
            // LabelAmountTo
            // 
            this.LabelAmountTo.AutoSize = true;
            this.LabelAmountTo.Location = new System.Drawing.Point(594, 338);
            this.LabelAmountTo.Name = "LabelAmountTo";
            this.LabelAmountTo.Size = new System.Drawing.Size(25, 17);
            this.LabelAmountTo.TabIndex = 25;
            this.LabelAmountTo.Text = "To";
            this.LabelAmountTo.Click += new System.EventHandler(this.LabelAmountTo_Click);
            // 
            // YearList
            // 
            this.YearList.Cursor = System.Windows.Forms.Cursors.Cross;
            this.YearList.FormattingEnabled = true;
            this.YearList.ItemHeight = 16;
            this.YearList.Location = new System.Drawing.Point(45, 268);
            this.YearList.Name = "YearList";
            this.YearList.Size = new System.Drawing.Size(65, 36);
            this.YearList.TabIndex = 3;
            this.YearList.SelectedIndexChanged += new System.EventHandler(this.YearList_SelectedIndexChanged);
            // 
            // MonthList
            // 
            this.MonthList.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MonthList.FormattingEnabled = true;
            this.MonthList.ItemHeight = 16;
            this.MonthList.Location = new System.Drawing.Point(130, 268);
            this.MonthList.Name = "MonthList";
            this.MonthList.Size = new System.Drawing.Size(50, 36);
            this.MonthList.TabIndex = 4;
            this.MonthList.Visible = false;
            this.MonthList.SelectedIndexChanged += new System.EventHandler(this.MonthList_SelectedIndexChanged);
            // 
            // DayList
            // 
            this.DayList.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DayList.FormattingEnabled = true;
            this.DayList.ItemHeight = 16;
            this.DayList.Location = new System.Drawing.Point(195, 268);
            this.DayList.Name = "DayList";
            this.DayList.Size = new System.Drawing.Size(50, 36);
            this.DayList.TabIndex = 5;
            this.DayList.Visible = false;
            this.DayList.SelectedIndexChanged += new System.EventHandler(this.DayList_SelectedIndexChanged);
            // 
            // HourList
            // 
            this.HourList.Cursor = System.Windows.Forms.Cursors.Cross;
            this.HourList.FormattingEnabled = true;
            this.HourList.ItemHeight = 16;
            this.HourList.Location = new System.Drawing.Point(260, 268);
            this.HourList.Name = "HourList";
            this.HourList.Size = new System.Drawing.Size(50, 36);
            this.HourList.TabIndex = 6;
            this.HourList.Visible = false;
            this.HourList.SelectedIndexChanged += new System.EventHandler(this.HourList_SelectedIndexChanged);
            // 
            // MinuteList
            // 
            this.MinuteList.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MinuteList.FormattingEnabled = true;
            this.MinuteList.ItemHeight = 16;
            this.MinuteList.Location = new System.Drawing.Point(325, 268);
            this.MinuteList.Name = "MinuteList";
            this.MinuteList.Size = new System.Drawing.Size(50, 36);
            this.MinuteList.TabIndex = 7;
            this.MinuteList.Visible = false;
            // 
            // AMPMList
            // 
            this.AMPMList.Cursor = System.Windows.Forms.Cursors.Cross;
            this.AMPMList.FormattingEnabled = true;
            this.AMPMList.ItemHeight = 16;
            this.AMPMList.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.AMPMList.Location = new System.Drawing.Point(390, 268);
            this.AMPMList.Name = "AMPMList";
            this.AMPMList.Size = new System.Drawing.Size(50, 36);
            this.AMPMList.TabIndex = 8;
            this.AMPMList.Visible = false;
            // 
            // YearToList
            // 
            this.YearToList.Cursor = System.Windows.Forms.Cursors.Cross;
            this.YearToList.FormattingEnabled = true;
            this.YearToList.ItemHeight = 16;
            this.YearToList.Location = new System.Drawing.Point(45, 333);
            this.YearToList.Name = "YearToList";
            this.YearToList.Size = new System.Drawing.Size(65, 36);
            this.YearToList.TabIndex = 9;
            this.YearToList.SelectedIndexChanged += new System.EventHandler(this.YearToList_SelectedIndexChanged);
            // 
            // MonthToList
            // 
            this.MonthToList.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MonthToList.FormattingEnabled = true;
            this.MonthToList.ItemHeight = 16;
            this.MonthToList.Location = new System.Drawing.Point(130, 333);
            this.MonthToList.Name = "MonthToList";
            this.MonthToList.Size = new System.Drawing.Size(50, 36);
            this.MonthToList.TabIndex = 10;
            this.MonthToList.Visible = false;
            this.MonthToList.SelectedIndexChanged += new System.EventHandler(this.MonthToList_SelectedIndexChanged);
            // 
            // DayToList
            // 
            this.DayToList.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DayToList.FormattingEnabled = true;
            this.DayToList.ItemHeight = 16;
            this.DayToList.Location = new System.Drawing.Point(195, 333);
            this.DayToList.Name = "DayToList";
            this.DayToList.Size = new System.Drawing.Size(50, 36);
            this.DayToList.TabIndex = 11;
            this.DayToList.Visible = false;
            this.DayToList.SelectedIndexChanged += new System.EventHandler(this.DayToList_SelectedIndexChanged);
            // 
            // HourToList
            // 
            this.HourToList.Cursor = System.Windows.Forms.Cursors.Cross;
            this.HourToList.FormattingEnabled = true;
            this.HourToList.ItemHeight = 16;
            this.HourToList.Location = new System.Drawing.Point(260, 333);
            this.HourToList.Name = "HourToList";
            this.HourToList.Size = new System.Drawing.Size(50, 36);
            this.HourToList.TabIndex = 12;
            this.HourToList.Visible = false;
            this.HourToList.SelectedIndexChanged += new System.EventHandler(this.HourToList_SelectedIndexChanged);
            // 
            // MinuteToList
            // 
            this.MinuteToList.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MinuteToList.FormattingEnabled = true;
            this.MinuteToList.ItemHeight = 16;
            this.MinuteToList.Location = new System.Drawing.Point(325, 333);
            this.MinuteToList.Name = "MinuteToList";
            this.MinuteToList.Size = new System.Drawing.Size(50, 36);
            this.MinuteToList.TabIndex = 13;
            this.MinuteToList.Visible = false;
            // 
            // AMPMToList
            // 
            this.AMPMToList.Cursor = System.Windows.Forms.Cursors.Cross;
            this.AMPMToList.FormattingEnabled = true;
            this.AMPMToList.ItemHeight = 16;
            this.AMPMToList.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.AMPMToList.Location = new System.Drawing.Point(390, 332);
            this.AMPMToList.Name = "AMPMToList";
            this.AMPMToList.Size = new System.Drawing.Size(50, 36);
            this.AMPMToList.TabIndex = 14;
            this.AMPMToList.Visible = false;
            // 
            // SearchStudentTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 459);
            this.Controls.Add(this.AMPMToList);
            this.Controls.Add(this.MinuteToList);
            this.Controls.Add(this.HourToList);
            this.Controls.Add(this.DayToList);
            this.Controls.Add(this.MonthToList);
            this.Controls.Add(this.YearToList);
            this.Controls.Add(this.AMPMList);
            this.Controls.Add(this.MinuteList);
            this.Controls.Add(this.HourList);
            this.Controls.Add(this.DayList);
            this.Controls.Add(this.MonthList);
            this.Controls.Add(this.YearList);
            this.Controls.Add(this.LabelAmountTo);
            this.Controls.Add(this.LabelAmount);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.LabelTo);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.AmountToBox);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.LabelUSN);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.USNBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Back);
            this.Name = "SearchStudentTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Student Transactions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchStudentTransaction_FormClosing);
            this.Load += new System.EventHandler(this.SearchStudentTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox USNBox;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelUSN;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.TextBox AmountToBox;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label LabelTo;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelAmount;
        private System.Windows.Forms.Label LabelAmountTo;
        private System.Windows.Forms.ListBox YearList;
        private System.Windows.Forms.ListBox MonthList;
        private System.Windows.Forms.ListBox DayList;
        private System.Windows.Forms.ListBox HourList;
        private System.Windows.Forms.ListBox MinuteList;
        private System.Windows.Forms.ListBox AMPMList;
        private System.Windows.Forms.ListBox YearToList;
        private System.Windows.Forms.ListBox MonthToList;
        private System.Windows.Forms.ListBox DayToList;
        private System.Windows.Forms.ListBox HourToList;
        private System.Windows.Forms.ListBox MinuteToList;
        private System.Windows.Forms.ListBox AMPMToList;
    }
}