namespace Finance_Management.forms.Hostel_Staff
{
    partial class HostelStaff
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
            this.WardenBox = new System.Windows.Forms.TextBox();
            this.SupervisorBox = new System.Windows.Forms.TextBox();
            this.BlockList = new System.Windows.Forms.ListBox();
            this.Submit = new System.Windows.Forms.Button();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.LabelWardenID = new System.Windows.Forms.Label();
            this.LabelSupervisorID = new System.Windows.Forms.Label();
            this.LabelBlockName = new System.Windows.Forms.Label();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // WardenBox
            // 
            this.WardenBox.Location = new System.Drawing.Point(150, 90);
            this.WardenBox.MaxLength = 6;
            this.WardenBox.Name = "WardenBox";
            this.WardenBox.Size = new System.Drawing.Size(100, 22);
            this.WardenBox.TabIndex = 0;
            // 
            // SupervisorBox
            // 
            this.SupervisorBox.Location = new System.Drawing.Point(150, 180);
            this.SupervisorBox.MaxLength = 6;
            this.SupervisorBox.Name = "SupervisorBox";
            this.SupervisorBox.Size = new System.Drawing.Size(100, 22);
            this.SupervisorBox.TabIndex = 1;
            // 
            // BlockList
            // 
            this.BlockList.Cursor = System.Windows.Forms.Cursors.Cross;
            this.BlockList.FormattingEnabled = true;
            this.BlockList.ItemHeight = 16;
            this.BlockList.Items.AddRange(new object[] {
            "GH-4(G)",
            "IH2(G)",
            "MH1(B)",
            "NBH1(B)",
            "NBH2(B)",
            "NBH3(B)",
            "NBH4(B)",
            "NBH5(B)",
            "NGH2(G)",
            "NGH5(G)",
            "NH3(B)"});
            this.BlockList.Location = new System.Drawing.Point(150, 261);
            this.BlockList.Name = "BlockList";
            this.BlockList.Size = new System.Drawing.Size(100, 36);
            this.BlockList.Sorted = true;
            this.BlockList.TabIndex = 2;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.Window;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Submit.Location = new System.Drawing.Point(410, 400);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(80, 30);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // DataView
            // 
            this.DataView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(350, 90);
            this.DataView.Name = "DataView";
            this.DataView.RowTemplate.Height = 24;
            this.DataView.Size = new System.Drawing.Size(480, 207);
            this.DataView.TabIndex = 5;
            // 
            // LabelWardenID
            // 
            this.LabelWardenID.AutoSize = true;
            this.LabelWardenID.Location = new System.Drawing.Point(37, 93);
            this.LabelWardenID.Name = "LabelWardenID";
            this.LabelWardenID.Size = new System.Drawing.Size(75, 17);
            this.LabelWardenID.TabIndex = 6;
            this.LabelWardenID.Text = "Warden ID";
            this.LabelWardenID.Click += new System.EventHandler(this.LabelWardenID_Click);
            // 
            // LabelSupervisorID
            // 
            this.LabelSupervisorID.AutoSize = true;
            this.LabelSupervisorID.Location = new System.Drawing.Point(37, 183);
            this.LabelSupervisorID.Name = "LabelSupervisorID";
            this.LabelSupervisorID.Size = new System.Drawing.Size(93, 17);
            this.LabelSupervisorID.TabIndex = 7;
            this.LabelSupervisorID.Text = "Supervisor ID";
            this.LabelSupervisorID.Click += new System.EventHandler(this.LabelSupervisorID_Click);
            // 
            // LabelBlockName
            // 
            this.LabelBlockName.AutoSize = true;
            this.LabelBlockName.Location = new System.Drawing.Point(37, 270);
            this.LabelBlockName.Name = "LabelBlockName";
            this.LabelBlockName.Size = new System.Drawing.Size(83, 17);
            this.LabelBlockName.TabIndex = 8;
            this.LabelBlockName.Text = "Block Name";
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(500, 329);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(53, 17);
            this.LabelSearch.TabIndex = 9;
            this.LabelSearch.Text = "Search";
            this.LabelSearch.Click += new System.EventHandler(this.LabelSearch_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(559, 326);
            this.SearchBox.MaxLength = 255;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(100, 22);
            this.SearchBox.TabIndex = 4;
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.Window;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Location = new System.Drawing.Point(40, 30);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(80, 30);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // HostelStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 459);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.LabelBlockName);
            this.Controls.Add(this.LabelSupervisorID);
            this.Controls.Add(this.LabelWardenID);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.BlockList);
            this.Controls.Add(this.SupervisorBox);
            this.Controls.Add(this.WardenBox);
            this.Name = "HostelStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Hostel Entry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HostelStaff_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WardenBox;
        private System.Windows.Forms.TextBox SupervisorBox;
        private System.Windows.Forms.ListBox BlockList;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.Label LabelWardenID;
        private System.Windows.Forms.Label LabelSupervisorID;
        private System.Windows.Forms.Label LabelBlockName;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button Back;
    }
}