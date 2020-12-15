namespace Homework_Fangko
{
    partial class Frm02_Loan
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
            this.labTitle = new System.Windows.Forms.Label();
            this.labLoan = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labPeriod = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.txtYearInterest = new System.Windows.Forms.TextBox();
            this.txtPeriodMonth = new System.Windows.Forms.TextBox();
            this.btnMothPay = new System.Windows.Forms.Button();
            this.btnTotalPay = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.labtxtmonth = new System.Windows.Forms.Label();
            this.labtxtper = new System.Windows.Forms.Label();
            this.labtxtntd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTitle.Location = new System.Drawing.Point(172, 37);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(145, 40);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "貸款試算";
            // 
            // labLoan
            // 
            this.labLoan.AutoSize = true;
            this.labLoan.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoan.Location = new System.Drawing.Point(100, 126);
            this.labLoan.Name = "labLoan";
            this.labLoan.Size = new System.Drawing.Size(96, 26);
            this.labLoan.TabIndex = 1;
            this.labLoan.Text = "貸款金額";
            this.labLoan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labYear.Location = new System.Drawing.Point(88, 180);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(108, 26);
            this.labYear.TabIndex = 2;
            this.labYear.Text = "年利率(%)";
            this.labYear.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labPeriod
            // 
            this.labPeriod.AutoSize = true;
            this.labPeriod.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPeriod.Location = new System.Drawing.Point(65, 226);
            this.labPeriod.Name = "labPeriod";
            this.labPeriod.Size = new System.Drawing.Size(131, 26);
            this.labPeriod.TabIndex = 3;
            this.labPeriod.Text = "貸款期數(月)";
            this.labPeriod.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtLoan
            // 
            this.txtLoan.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoan.Location = new System.Drawing.Point(246, 123);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(156, 29);
            this.txtLoan.TabIndex = 5;
            // 
            // txtYearInterest
            // 
            this.txtYearInterest.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYearInterest.Location = new System.Drawing.Point(246, 177);
            this.txtYearInterest.Name = "txtYearInterest";
            this.txtYearInterest.Size = new System.Drawing.Size(156, 29);
            this.txtYearInterest.TabIndex = 6;
            // 
            // txtPeriodMonth
            // 
            this.txtPeriodMonth.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPeriodMonth.Location = new System.Drawing.Point(246, 223);
            this.txtPeriodMonth.Name = "txtPeriodMonth";
            this.txtPeriodMonth.Size = new System.Drawing.Size(156, 29);
            this.txtPeriodMonth.TabIndex = 7;
            // 
            // btnMothPay
            // 
            this.btnMothPay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMothPay.Location = new System.Drawing.Point(70, 301);
            this.btnMothPay.Name = "btnMothPay";
            this.btnMothPay.Size = new System.Drawing.Size(107, 37);
            this.btnMothPay.TabIndex = 9;
            this.btnMothPay.Text = "月付額";
            this.btnMothPay.UseVisualStyleBackColor = true;
            this.btnMothPay.Click += new System.EventHandler(this.btnMothPay_Click);
            // 
            // btnTotalPay
            // 
            this.btnTotalPay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotalPay.Location = new System.Drawing.Point(199, 301);
            this.btnTotalPay.Name = "btnTotalPay";
            this.btnTotalPay.Size = new System.Drawing.Size(107, 37);
            this.btnTotalPay.TabIndex = 10;
            this.btnTotalPay.Text = "總付額";
            this.btnTotalPay.UseVisualStyleBackColor = true;
            this.btnTotalPay.Click += new System.EventHandler(this.btnTotalPay_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(332, 301);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(107, 37);
            this.btnReport.TabIndex = 11;
            this.btnReport.Text = "完整報告";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // labtxtmonth
            // 
            this.labtxtmonth.AutoSize = true;
            this.labtxtmonth.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labtxtmonth.Location = new System.Drawing.Point(408, 223);
            this.labtxtmonth.Name = "labtxtmonth";
            this.labtxtmonth.Size = new System.Drawing.Size(33, 26);
            this.labtxtmonth.TabIndex = 13;
            this.labtxtmonth.Text = "月";
            this.labtxtmonth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labtxtper
            // 
            this.labtxtper.AutoSize = true;
            this.labtxtper.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labtxtper.Location = new System.Drawing.Point(408, 179);
            this.labtxtper.Name = "labtxtper";
            this.labtxtper.Size = new System.Drawing.Size(31, 26);
            this.labtxtper.TabIndex = 14;
            this.labtxtper.Text = "%";
            this.labtxtper.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labtxtntd
            // 
            this.labtxtntd.AutoSize = true;
            this.labtxtntd.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labtxtntd.Location = new System.Drawing.Point(408, 126);
            this.labtxtntd.Name = "labtxtntd";
            this.labtxtntd.Size = new System.Drawing.Size(33, 26);
            this.labtxtntd.TabIndex = 15;
            this.labtxtntd.Text = "元";
            this.labtxtntd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Frm02_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 398);
            this.Controls.Add(this.labtxtntd);
            this.Controls.Add(this.labtxtper);
            this.Controls.Add(this.labtxtmonth);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotalPay);
            this.Controls.Add(this.btnMothPay);
            this.Controls.Add(this.txtPeriodMonth);
            this.Controls.Add(this.txtYearInterest);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.labPeriod);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labLoan);
            this.Controls.Add(this.labTitle);
            this.Name = "Frm02_Loan";
            this.Text = "Frm02_Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labLoan;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labPeriod;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.TextBox txtYearInterest;
        private System.Windows.Forms.TextBox txtPeriodMonth;
        private System.Windows.Forms.Button btnMothPay;
        private System.Windows.Forms.Button btnTotalPay;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label labtxtmonth;
        private System.Windows.Forms.Label labtxtper;
        private System.Windows.Forms.Label labtxtntd;
    }
}