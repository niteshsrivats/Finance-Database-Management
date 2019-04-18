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
            this.Search = new System.Windows.Forms.Button();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.LabelWardenID = new System.Windows.Forms.Label();
            this.LabelSupervisorID = new System.Windows.Forms.Label();
            this.LabelBlockName = new System.Windows.Forms.Label();
            this.LabelNameID = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // WardenBox
            // 
            this.WardenBox.Location = new System.Drawing.Point(150, 67);
            this.WardenBox.Name = "WardenBox";
            this.WardenBox.Size = new System.Drawing.Size(100, 22);
            this.WardenBox.TabIndex = 0;
            // 
            // SupervisorBox
            // 
            this.SupervisorBox.Location = new System.Drawing.Point(161, 141);
            this.SupervisorBox.Name = "SupervisorBox";
            this.SupervisorBox.Size = new System.Drawing.Size(100, 22);
            this.SupervisorBox.TabIndex = 1;
            // 
            // BlockList
            // 
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
            this.BlockList.Location = new System.Drawing.Point(150, 262);
            this.BlockList.Name = "BlockList";
            this.BlockList.Size = new System.Drawing.Size(121, 36);
            this.BlockList.Sorted = true;
            this.BlockList.TabIndex = 2;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(150, 391);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(557, 354);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 4;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // DataView
            // 
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(485, 54);
            this.DataView.Name = "DataView";
            this.DataView.RowTemplate.Height = 24;
            this.DataView.Size = new System.Drawing.Size(240, 150);
            this.DataView.TabIndex = 5;
            // 
            // LabelWardenID
            // 
            this.LabelWardenID.AutoSize = true;
            this.LabelWardenID.Location = new System.Drawing.Point(49, 71);
            this.LabelWardenID.Name = "LabelWardenID";
            this.LabelWardenID.Size = new System.Drawing.Size(75, 17);
            this.LabelWardenID.TabIndex = 6;
            this.LabelWardenID.Text = "Warden ID";
            // 
            // LabelSupervisorID
            // 
            this.LabelSupervisorID.AutoSize = true;
            this.LabelSupervisorID.Location = new System.Drawing.Point(52, 145);
            this.LabelSupervisorID.Name = "LabelSupervisorID";
            this.LabelSupervisorID.Size = new System.Drawing.Size(93, 17);
            this.LabelSupervisorID.TabIndex = 7;
            this.LabelSupervisorID.Text = "Supervisor ID";
            // 
            // LabelBlockName
            // 
            this.LabelBlockName.AutoSize = true;
            this.LabelBlockName.Location = new System.Drawing.Point(52, 262);
            this.LabelBlockName.Name = "LabelBlockName";
            this.LabelBlockName.Size = new System.Drawing.Size(83, 17);
            this.LabelBlockName.TabIndex = 8;
            this.LabelBlockName.Text = "Block Name";
            // 
            // LabelNameID
            // 
            this.LabelNameID.AutoSize = true;
            this.LabelNameID.Location = new System.Drawing.Point(438, 288);
            this.LabelNameID.Name = "LabelNameID";
            this.LabelNameID.Size = new System.Drawing.Size(62, 17);
            this.LabelNameID.TabIndex = 9;
            this.LabelNameID.Text = "Name/ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(557, 288);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            // 
            // HostelStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.LabelNameID);
            this.Controls.Add(this.LabelBlockName);
            this.Controls.Add(this.LabelSupervisorID);
            this.Controls.Add(this.LabelWardenID);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.BlockList);
            this.Controls.Add(this.SupervisorBox);
            this.Controls.Add(this.WardenBox);
            this.Name = "HostelStaff";
            this.Text = "HostelStaff";
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WardenBox;
        private System.Windows.Forms.TextBox SupervisorBox;
        private System.Windows.Forms.ListBox BlockList;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.Label LabelWardenID;
        private System.Windows.Forms.Label LabelSupervisorID;
        private System.Windows.Forms.Label LabelBlockName;
        private System.Windows.Forms.Label LabelNameID;
        private System.Windows.Forms.TextBox textBox3;
    }
}