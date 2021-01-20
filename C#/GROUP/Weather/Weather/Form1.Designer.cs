namespace Weather
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.LoclblCurrentTemp = new System.Windows.Forms.Label();
            this.LoclblHigh = new System.Windows.Forms.Label();
            this.lblTempHigh = new System.Windows.Forms.Label();
            this.LoclblLow = new System.Windows.Forms.Label();
            this.lblTempLow = new System.Windows.Forms.Label();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.LoclblDesc = new System.Windows.Forms.Label();
            this.lblObserve = new System.Windows.Forms.Label();
            this.LoclblObservation = new System.Windows.Forms.Label();
            this.lblWindPressure = new System.Windows.Forms.Label();
            this.LoclblWindPressure = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.LoclblHumidity = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.LoclblPressure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(310, 11);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 47);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter a zip code and press Search.";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(60, 46);
            this.txtZip.Margin = new System.Windows.Forms.Padding(4);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(132, 22);
            this.txtZip.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ZIP:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(418, 11);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 47);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear Screen";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(526, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 47);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LoclblCurrentTemp
            // 
            this.LoclblCurrentTemp.AutoSize = true;
            this.LoclblCurrentTemp.Location = new System.Drawing.Point(129, 96);
            this.LoclblCurrentTemp.Name = "LoclblCurrentTemp";
            this.LoclblCurrentTemp.Size = new System.Drawing.Size(145, 17);
            this.LoclblCurrentTemp.TabIndex = 8;
            this.LoclblCurrentTemp.Text = "Current Temperature:";
            // 
            // LoclblHigh
            // 
            this.LoclblHigh.AutoSize = true;
            this.LoclblHigh.Location = new System.Drawing.Point(23, 197);
            this.LoclblHigh.Name = "LoclblHigh";
            this.LoclblHigh.Size = new System.Drawing.Size(92, 17);
            this.LoclblHigh.TabIndex = 9;
            this.LoclblHigh.Text = "Current High:";
            // 
            // lblTempHigh
            // 
            this.lblTempHigh.AutoSize = true;
            this.lblTempHigh.Location = new System.Drawing.Point(119, 197);
            this.lblTempHigh.Name = "lblTempHigh";
            this.lblTempHigh.Size = new System.Drawing.Size(16, 17);
            this.lblTempHigh.TabIndex = 10;
            this.lblTempHigh.Text = "  ";
            // 
            // LoclblLow
            // 
            this.LoclblLow.AutoSize = true;
            this.LoclblLow.Location = new System.Drawing.Point(23, 229);
            this.LoclblLow.Name = "LoclblLow";
            this.LoclblLow.Size = new System.Drawing.Size(88, 17);
            this.LoclblLow.TabIndex = 11;
            this.LoclblLow.Text = "Current Low:";
            // 
            // lblTempLow
            // 
            this.lblTempLow.AutoSize = true;
            this.lblTempLow.Location = new System.Drawing.Point(119, 229);
            this.lblTempLow.Name = "lblTempLow";
            this.lblTempLow.Size = new System.Drawing.Size(16, 17);
            this.lblTempLow.TabIndex = 12;
            this.lblTempLow.Text = "  ";
            // 
            // imgBox
            // 
            this.imgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBox.Location = new System.Drawing.Point(19, 96);
            this.imgBox.Margin = new System.Windows.Forms.Padding(0);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(96, 78);
            this.imgBox.TabIndex = 13;
            this.imgBox.TabStop = false;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Calisto MT", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(124, 128);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(50, 46);
            this.lblTemp.TabIndex = 14;
            this.lblTemp.Text = "   ";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(428, 129);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(16, 17);
            this.lblDesc.TabIndex = 18;
            this.lblDesc.Text = "  ";
            // 
            // LoclblDesc
            // 
            this.LoclblDesc.AutoSize = true;
            this.LoclblDesc.Location = new System.Drawing.Point(332, 129);
            this.LoclblDesc.Name = "LoclblDesc";
            this.LoclblDesc.Size = new System.Drawing.Size(83, 17);
            this.LoclblDesc.TabIndex = 17;
            this.LoclblDesc.Text = "Description:";
            // 
            // lblObserve
            // 
            this.lblObserve.AutoSize = true;
            this.lblObserve.Location = new System.Drawing.Point(428, 96);
            this.lblObserve.Name = "lblObserve";
            this.lblObserve.Size = new System.Drawing.Size(16, 17);
            this.lblObserve.TabIndex = 16;
            this.lblObserve.Text = "  ";
            // 
            // LoclblObservation
            // 
            this.LoclblObservation.AutoSize = true;
            this.LoclblObservation.Location = new System.Drawing.Point(332, 96);
            this.LoclblObservation.Name = "LoclblObservation";
            this.LoclblObservation.Size = new System.Drawing.Size(89, 17);
            this.LoclblObservation.TabIndex = 15;
            this.LoclblObservation.Text = "Observation:";
            // 
            // lblWindPressure
            // 
            this.lblWindPressure.AutoSize = true;
            this.lblWindPressure.Location = new System.Drawing.Point(428, 229);
            this.lblWindPressure.Name = "lblWindPressure";
            this.lblWindPressure.Size = new System.Drawing.Size(16, 17);
            this.lblWindPressure.TabIndex = 24;
            this.lblWindPressure.Text = "  ";
            // 
            // LoclblWindPressure
            // 
            this.LoclblWindPressure.AutoSize = true;
            this.LoclblWindPressure.Location = new System.Drawing.Point(332, 229);
            this.LoclblWindPressure.Name = "LoclblWindPressure";
            this.LoclblWindPressure.Size = new System.Drawing.Size(89, 17);
            this.LoclblWindPressure.TabIndex = 23;
            this.LoclblWindPressure.Text = "Wind Speed:";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(428, 196);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(16, 17);
            this.lblHumidity.TabIndex = 22;
            this.lblHumidity.Text = "  ";
            // 
            // LoclblHumidity
            // 
            this.LoclblHumidity.AutoSize = true;
            this.LoclblHumidity.Location = new System.Drawing.Point(332, 196);
            this.LoclblHumidity.Name = "LoclblHumidity";
            this.LoclblHumidity.Size = new System.Drawing.Size(66, 17);
            this.LoclblHumidity.TabIndex = 21;
            this.LoclblHumidity.Text = "Humidity:";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Location = new System.Drawing.Point(428, 161);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(16, 17);
            this.lblPressure.TabIndex = 20;
            this.lblPressure.Text = "  ";
            // 
            // LoclblPressure
            // 
            this.LoclblPressure.AutoSize = true;
            this.LoclblPressure.Location = new System.Drawing.Point(332, 161);
            this.LoclblPressure.Name = "LoclblPressure";
            this.LoclblPressure.Size = new System.Drawing.Size(69, 17);
            this.LoclblPressure.TabIndex = 19;
            this.LoclblPressure.Text = "Pressure:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 273);
            this.Controls.Add(this.lblWindPressure);
            this.Controls.Add(this.LoclblWindPressure);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.LoclblHumidity);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.LoclblPressure);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.LoclblDesc);
            this.Controls.Add(this.lblObserve);
            this.Controls.Add(this.LoclblObservation);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.lblTempLow);
            this.Controls.Add(this.LoclblLow);
            this.Controls.Add(this.lblTempHigh);
            this.Controls.Add(this.LoclblHigh);
            this.Controls.Add(this.LoclblCurrentTemp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Insta-Weather v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label LoclblCurrentTemp;
        private System.Windows.Forms.Label LoclblHigh;
        private System.Windows.Forms.Label lblTempHigh;
        private System.Windows.Forms.Label LoclblLow;
        private System.Windows.Forms.Label lblTempLow;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label LoclblDesc;
        private System.Windows.Forms.Label lblObserve;
        private System.Windows.Forms.Label LoclblObservation;
        private System.Windows.Forms.Label lblWindPressure;
        private System.Windows.Forms.Label LoclblWindPressure;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label LoclblHumidity;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label LoclblPressure;
    }
}

