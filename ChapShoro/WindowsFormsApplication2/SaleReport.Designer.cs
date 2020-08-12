namespace WindowsFormsApplication2
{
    partial class SaleReport
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
            this.lblReportBy = new System.Windows.Forms.Label();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.btnShowReport_SalesReport = new System.Windows.Forms.Button();
            this.btnExit_SalesReport = new System.Windows.Forms.Button();
            this.lblSellsCount_SellReport = new System.Windows.Forms.Label();
            this.lblSellAmount_SellReport = new System.Windows.Forms.Label();
            this.lblSellCountNumber_SellReport = new System.Windows.Forms.Label();
            this.lblSellAmountNumber_SellReport = new System.Windows.Forms.Label();
            this.cbyf = new System.Windows.Forms.ComboBox();
            this.cbmf = new System.Windows.Forms.ComboBox();
            this.lblMonthSellReport = new System.Windows.Forms.Label();
            this.lblYearSellReport = new System.Windows.Forms.Label();
            this.rdDaily = new System.Windows.Forms.RadioButton();
            this.rdMonthly = new System.Windows.Forms.RadioButton();
            this.rdYear = new System.Windows.Forms.RadioButton();
            this.rdWhole = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.rdDuration = new System.Windows.Forms.RadioButton();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReportBy
            // 
            this.lblReportBy.AutoSize = true;
            this.lblReportBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportBy.ForeColor = System.Drawing.Color.Black;
            this.lblReportBy.Location = new System.Drawing.Point(9, 14);
            this.lblReportBy.Name = "lblReportBy";
            this.lblReportBy.Size = new System.Drawing.Size(107, 24);
            this.lblReportBy.TabIndex = 0;
            this.lblReportBy.Text = "Report By:";
            this.lblReportBy.Click += new System.EventHandler(this.lblReportBy_Click);
            // 
            // DGV1
            // 
            this.DGV1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(274, 1);
            this.DGV1.Name = "DGV1";
            this.DGV1.ReadOnly = true;
            this.DGV1.Size = new System.Drawing.Size(619, 408);
            this.DGV1.TabIndex = 15;
            this.DGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnShowReport_SalesReport
            // 
            this.btnShowReport_SalesReport.BackColor = System.Drawing.Color.Lime;
            this.btnShowReport_SalesReport.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowReport_SalesReport.Location = new System.Drawing.Point(17, 217);
            this.btnShowReport_SalesReport.Name = "btnShowReport_SalesReport";
            this.btnShowReport_SalesReport.Size = new System.Drawing.Size(157, 67);
            this.btnShowReport_SalesReport.TabIndex = 13;
            this.btnShowReport_SalesReport.Text = "Show";
            this.btnShowReport_SalesReport.UseVisualStyleBackColor = false;
            this.btnShowReport_SalesReport.Click += new System.EventHandler(this.btnShowReport_SalesReport_Click);
            // 
            // btnExit_SalesReport
            // 
            this.btnExit_SalesReport.BackColor = System.Drawing.Color.Red;
            this.btnExit_SalesReport.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit_SalesReport.ForeColor = System.Drawing.Color.Black;
            this.btnExit_SalesReport.Location = new System.Drawing.Point(17, 337);
            this.btnExit_SalesReport.Name = "btnExit_SalesReport";
            this.btnExit_SalesReport.Size = new System.Drawing.Size(157, 68);
            this.btnExit_SalesReport.TabIndex = 14;
            this.btnExit_SalesReport.Text = "Close Sale Report";
            this.btnExit_SalesReport.UseVisualStyleBackColor = false;
            this.btnExit_SalesReport.Click += new System.EventHandler(this.btnExit_SalesReport_Click);
            // 
            // lblSellsCount_SellReport
            // 
            this.lblSellsCount_SellReport.AutoSize = true;
            this.lblSellsCount_SellReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellsCount_SellReport.ForeColor = System.Drawing.Color.Black;
            this.lblSellsCount_SellReport.Location = new System.Drawing.Point(17, 292);
            this.lblSellsCount_SellReport.Name = "lblSellsCount_SellReport";
            this.lblSellsCount_SellReport.Size = new System.Drawing.Size(111, 20);
            this.lblSellsCount_SellReport.TabIndex = 6;
            this.lblSellsCount_SellReport.Text = "Sells Count :";
            this.lblSellsCount_SellReport.Click += new System.EventHandler(this.lblSellsCount_SellReport_Click);
            // 
            // lblSellAmount_SellReport
            // 
            this.lblSellAmount_SellReport.AutoSize = true;
            this.lblSellAmount_SellReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellAmount_SellReport.ForeColor = System.Drawing.Color.Black;
            this.lblSellAmount_SellReport.Location = new System.Drawing.Point(17, 317);
            this.lblSellAmount_SellReport.Name = "lblSellAmount_SellReport";
            this.lblSellAmount_SellReport.Size = new System.Drawing.Size(125, 20);
            this.lblSellAmount_SellReport.TabIndex = 7;
            this.lblSellAmount_SellReport.Text = "Sells Amount :";
            this.lblSellAmount_SellReport.Click += new System.EventHandler(this.lblSellAmount_SellReport_Click);
            // 
            // lblSellCountNumber_SellReport
            // 
            this.lblSellCountNumber_SellReport.AutoSize = true;
            this.lblSellCountNumber_SellReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellCountNumber_SellReport.ForeColor = System.Drawing.Color.Black;
            this.lblSellCountNumber_SellReport.Location = new System.Drawing.Point(153, 290);
            this.lblSellCountNumber_SellReport.Name = "lblSellCountNumber_SellReport";
            this.lblSellCountNumber_SellReport.Size = new System.Drawing.Size(20, 24);
            this.lblSellCountNumber_SellReport.TabIndex = 8;
            this.lblSellCountNumber_SellReport.Text = "0";
            this.lblSellCountNumber_SellReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSellCountNumber_SellReport.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSellAmountNumber_SellReport
            // 
            this.lblSellAmountNumber_SellReport.AutoSize = true;
            this.lblSellAmountNumber_SellReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellAmountNumber_SellReport.ForeColor = System.Drawing.Color.Black;
            this.lblSellAmountNumber_SellReport.Location = new System.Drawing.Point(153, 315);
            this.lblSellAmountNumber_SellReport.Name = "lblSellAmountNumber_SellReport";
            this.lblSellAmountNumber_SellReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSellAmountNumber_SellReport.Size = new System.Drawing.Size(20, 24);
            this.lblSellAmountNumber_SellReport.TabIndex = 9;
            this.lblSellAmountNumber_SellReport.Text = "0";
            this.lblSellAmountNumber_SellReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSellAmountNumber_SellReport.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbyf
            // 
            this.cbyf.FormattingEnabled = true;
            this.cbyf.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbyf.Location = new System.Drawing.Point(97, 173);
            this.cbyf.Name = "cbyf";
            this.cbyf.Size = new System.Drawing.Size(71, 21);
            this.cbyf.TabIndex = 10;
            // 
            // cbmf
            // 
            this.cbmf.FormattingEnabled = true;
            this.cbmf.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbmf.Location = new System.Drawing.Point(21, 173);
            this.cbmf.MaxDropDownItems = 12;
            this.cbmf.Name = "cbmf";
            this.cbmf.Size = new System.Drawing.Size(71, 21);
            this.cbmf.TabIndex = 7;
            // 
            // lblMonthSellReport
            // 
            this.lblMonthSellReport.AutoSize = true;
            this.lblMonthSellReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthSellReport.ForeColor = System.Drawing.Color.Black;
            this.lblMonthSellReport.Location = new System.Drawing.Point(31, 151);
            this.lblMonthSellReport.Name = "lblMonthSellReport";
            this.lblMonthSellReport.Size = new System.Drawing.Size(49, 16);
            this.lblMonthSellReport.TabIndex = 13;
            this.lblMonthSellReport.Text = "Month";
            // 
            // lblYearSellReport
            // 
            this.lblYearSellReport.AutoSize = true;
            this.lblYearSellReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearSellReport.ForeColor = System.Drawing.Color.Black;
            this.lblYearSellReport.Location = new System.Drawing.Point(116, 151);
            this.lblYearSellReport.Name = "lblYearSellReport";
            this.lblYearSellReport.Size = new System.Drawing.Size(41, 16);
            this.lblYearSellReport.TabIndex = 14;
            this.lblYearSellReport.Text = "Year";
            // 
            // rdDaily
            // 
            this.rdDaily.AutoSize = true;
            this.rdDaily.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDaily.ForeColor = System.Drawing.Color.Black;
            this.rdDaily.Location = new System.Drawing.Point(12, 37);
            this.rdDaily.Name = "rdDaily";
            this.rdDaily.Size = new System.Drawing.Size(58, 24);
            this.rdDaily.TabIndex = 2;
            this.rdDaily.TabStop = true;
            this.rdDaily.Text = "Daily";
            this.rdDaily.UseVisualStyleBackColor = true;
            this.rdDaily.CheckedChanged += new System.EventHandler(this.rdDaily_CheckedChanged);
            // 
            // rdMonthly
            // 
            this.rdMonthly.AutoSize = true;
            this.rdMonthly.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMonthly.ForeColor = System.Drawing.Color.Black;
            this.rdMonthly.Location = new System.Drawing.Point(12, 84);
            this.rdMonthly.Name = "rdMonthly";
            this.rdMonthly.Size = new System.Drawing.Size(77, 24);
            this.rdMonthly.TabIndex = 6;
            this.rdMonthly.TabStop = true;
            this.rdMonthly.Text = "Monthly";
            this.rdMonthly.UseVisualStyleBackColor = true;
            this.rdMonthly.CheckedChanged += new System.EventHandler(this.rdMonthly_CheckedChanged);
            // 
            // rdYear
            // 
            this.rdYear.AutoSize = true;
            this.rdYear.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdYear.ForeColor = System.Drawing.Color.Black;
            this.rdYear.Location = new System.Drawing.Point(13, 104);
            this.rdYear.Name = "rdYear";
            this.rdYear.Size = new System.Drawing.Size(65, 24);
            this.rdYear.TabIndex = 9;
            this.rdYear.TabStop = true;
            this.rdYear.Text = "Yearly";
            this.rdYear.UseVisualStyleBackColor = true;
            this.rdYear.CheckedChanged += new System.EventHandler(this.rdYear_CheckedChanged);
            // 
            // rdWhole
            // 
            this.rdWhole.AutoSize = true;
            this.rdWhole.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdWhole.ForeColor = System.Drawing.Color.Black;
            this.rdWhole.Location = new System.Drawing.Point(13, 124);
            this.rdWhole.Name = "rdWhole";
            this.rdWhole.Size = new System.Drawing.Size(65, 24);
            this.rdWhole.TabIndex = 1;
            this.rdWhole.TabStop = true;
            this.rdWhole.Text = "Whole";
            this.rdWhole.UseVisualStyleBackColor = true;
            this.rdWhole.CheckedChanged += new System.EventHandler(this.rdWhole_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.dtTo);
            this.panel1.Controls.Add(this.rdDuration);
            this.panel1.Controls.Add(this.dtFrom);
            this.panel1.Controls.Add(this.rdMonthly);
            this.panel1.Controls.Add(this.lblYearSellReport);
            this.panel1.Controls.Add(this.rdWhole);
            this.panel1.Controls.Add(this.lblMonthSellReport);
            this.panel1.Controls.Add(this.rdYear);
            this.panel1.Controls.Add(this.cbmf);
            this.panel1.Controls.Add(this.cbyf);
            this.panel1.Controls.Add(this.lblReportBy);
            this.panel1.Controls.Add(this.lblSellAmountNumber_SellReport);
            this.panel1.Controls.Add(this.rdDaily);
            this.panel1.Controls.Add(this.lblSellCountNumber_SellReport);
            this.panel1.Controls.Add(this.btnShowReport_SalesReport);
            this.panel1.Controls.Add(this.lblSellAmount_SellReport);
            this.panel1.Controls.Add(this.btnExit_SalesReport);
            this.panel1.Controls.Add(this.lblSellsCount_SellReport);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 408);
            this.panel1.TabIndex = 22;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.Black;
            this.lblFrom.Location = new System.Drawing.Point(14, 191);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(27, 16);
            this.lblFrom.TabIndex = 27;
            this.lblFrom.Text = "To";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.Black;
            this.lblTo.Location = new System.Drawing.Point(9, 167);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(43, 16);
            this.lblTo.TabIndex = 26;
            this.lblTo.Text = "From";
            this.lblTo.Click += new System.EventHandler(this.lblTo_Click);
            // 
            // dtTo
            // 
            this.dtTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.CustomFormat = "dd/MMM/yyyy hh:mm:ss tt";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(72, 191);
            this.dtTo.MinDate = new System.DateTime(2019, 4, 1, 0, 0, 0, 0);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(183, 20);
            this.dtTo.TabIndex = 5;
            // 
            // rdDuration
            // 
            this.rdDuration.AutoSize = true;
            this.rdDuration.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDuration.ForeColor = System.Drawing.Color.Black;
            this.rdDuration.Location = new System.Drawing.Point(12, 60);
            this.rdDuration.Name = "rdDuration";
            this.rdDuration.Size = new System.Drawing.Size(80, 24);
            this.rdDuration.TabIndex = 3;
            this.rdDuration.TabStop = true;
            this.rdDuration.Text = "Duration";
            this.rdDuration.UseVisualStyleBackColor = true;
            this.rdDuration.CheckedChanged += new System.EventHandler(this.rdDuration_CheckedChanged);
            // 
            // dtFrom
            // 
            this.dtFrom.AllowDrop = true;
            this.dtFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.CustomFormat = "dd/MMM/yyyy  hh:mm:ss tt";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(72, 165);
            this.dtFrom.MaxDate = new System.DateTime(3999, 1, 1, 0, 0, 0, 0);
            this.dtFrom.MinDate = new System.DateTime(2019, 4, 1, 0, 0, 0, 0);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(183, 20);
            this.dtFrom.TabIndex = 4;
            this.dtFrom.Value = new System.DateTime(2019, 5, 28, 0, 0, 0, 0);
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // SaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(894, 412);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV1);
            this.MaximizeBox = false;
            this.Name = "SaleReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SaleReport";
            this.Load += new System.EventHandler(this.SaleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblReportBy;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Button btnShowReport_SalesReport;
        private System.Windows.Forms.Button btnExit_SalesReport;
        private System.Windows.Forms.Label lblSellsCount_SellReport;
        private System.Windows.Forms.Label lblSellAmount_SellReport;
        private System.Windows.Forms.Label lblSellCountNumber_SellReport;
        private System.Windows.Forms.Label lblSellAmountNumber_SellReport;
        private System.Windows.Forms.ComboBox cbyf;
        private System.Windows.Forms.ComboBox cbmf;
        private System.Windows.Forms.Label lblMonthSellReport;
        private System.Windows.Forms.Label lblYearSellReport;
        private System.Windows.Forms.RadioButton rdDaily;
        private System.Windows.Forms.RadioButton rdMonthly;
        private System.Windows.Forms.RadioButton rdYear;
        private System.Windows.Forms.RadioButton rdWhole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.RadioButton rdDuration;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
    }
}