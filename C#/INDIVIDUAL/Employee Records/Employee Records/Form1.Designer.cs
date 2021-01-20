namespace Employee_Records
{
    partial class Form1
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
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.BtnChoose = new System.Windows.Forms.Button();
            this.TbFilePath = new System.Windows.Forms.TextBox();
            this.LbPath = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.DgEmployees = new System.Windows.Forms.DataGridView();
            this.CbAmt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSch = new System.Windows.Forms.TextBox();
            this.btnSch = new System.Windows.Forms.Button();
            this.dgSearch = new System.Windows.Forms.DataGridView();
            this.lblSearchRes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            this.OpenFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // BtnChoose
            // 
            this.BtnChoose.Location = new System.Drawing.Point(612, 28);
            this.BtnChoose.Name = "BtnChoose";
            this.BtnChoose.Size = new System.Drawing.Size(75, 23);
            this.BtnChoose.TabIndex = 0;
            this.BtnChoose.Text = "Choose File";
            this.BtnChoose.UseVisualStyleBackColor = true;
            this.BtnChoose.Click += new System.EventHandler(this.button1_Click);
            // 
            // TbFilePath
            // 
            this.TbFilePath.Location = new System.Drawing.Point(12, 30);
            this.TbFilePath.Name = "TbFilePath";
            this.TbFilePath.Size = new System.Drawing.Size(594, 20);
            this.TbFilePath.TabIndex = 1;
            // 
            // LbPath
            // 
            this.LbPath.AutoSize = true;
            this.LbPath.Location = new System.Drawing.Point(9, 14);
            this.LbPath.Name = "LbPath";
            this.LbPath.Size = new System.Drawing.Size(48, 13);
            this.LbPath.TabIndex = 2;
            this.LbPath.Text = "File Path";
            this.LbPath.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(1069, 27);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DgEmployees
            // 
            this.DgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgEmployees.Location = new System.Drawing.Point(12, 88);
            this.DgEmployees.Name = "DgEmployees";
            this.DgEmployees.ReadOnly = true;
            this.DgEmployees.Size = new System.Drawing.Size(1132, 204);
            this.DgEmployees.TabIndex = 4;
            this.DgEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgEmployees_CellContentClick);
            // 
            // CbAmt
            // 
            this.CbAmt.FormattingEnabled = true;
            this.CbAmt.Items.AddRange(new object[] {
            "All",
            "3",
            "4",
            "5",
            "6"});
            this.CbAmt.Location = new System.Drawing.Point(612, 61);
            this.CbAmt.Name = "CbAmt";
            this.CbAmt.Size = new System.Drawing.Size(121, 21);
            this.CbAmt.TabIndex = 5;
            this.CbAmt.SelectedIndexChanged += new System.EventHandler(this.CbAmt_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Display How Many Records?";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtSch
            // 
            this.txtSch.Location = new System.Drawing.Point(12, 61);
            this.txtSch.Name = "txtSch";
            this.txtSch.Size = new System.Drawing.Size(317, 20);
            this.txtSch.TabIndex = 7;
            // 
            // btnSch
            // 
            this.btnSch.Location = new System.Drawing.Point(335, 58);
            this.btnSch.Name = "btnSch";
            this.btnSch.Size = new System.Drawing.Size(75, 23);
            this.btnSch.TabIndex = 8;
            this.btnSch.Text = "Search";
            this.btnSch.UseVisualStyleBackColor = true;
            this.btnSch.Click += new System.EventHandler(this.btnSch_Click);
            // 
            // dgSearch
            // 
            this.dgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearch.Location = new System.Drawing.Point(12, 321);
            this.dgSearch.Name = "dgSearch";
            this.dgSearch.ReadOnly = true;
            this.dgSearch.Size = new System.Drawing.Size(1132, 189);
            this.dgSearch.TabIndex = 9;
            // 
            // lblSearchRes
            // 
            this.lblSearchRes.AutoSize = true;
            this.lblSearchRes.Location = new System.Drawing.Point(9, 305);
            this.lblSearchRes.Name = "lblSearchRes";
            this.lblSearchRes.Size = new System.Drawing.Size(237, 13);
            this.lblSearchRes.TabIndex = 10;
            this.lblSearchRes.Text = "Search Results (Must match full words and case)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1649, 522);
            this.Controls.Add(this.lblSearchRes);
            this.Controls.Add(this.dgSearch);
            this.Controls.Add(this.btnSch);
            this.Controls.Add(this.txtSch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbAmt);
            this.Controls.Add(this.DgEmployees);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LbPath);
            this.Controls.Add(this.TbFilePath);
            this.Controls.Add(this.BtnChoose);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Button BtnChoose;
        private System.Windows.Forms.TextBox TbFilePath;
        private System.Windows.Forms.Label LbPath;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridView DgEmployees;
        private System.Windows.Forms.ComboBox CbAmt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSch;
        private System.Windows.Forms.Button btnSch;
        private System.Windows.Forms.DataGridView dgSearch;
        private System.Windows.Forms.Label lblSearchRes;
    }
}

