namespace HomeWork
{
    partial class Frm03_Loan
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
            this.Lab_Principal = new System.Windows.Forms.Label();
            this.Lab_Rate = new System.Windows.Forms.Label();
            this.Lab_Period = new System.Windows.Forms.Label();
            this.btnMonthpay = new System.Windows.Forms.Button();
            this.btnTotalpay = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtDownpayment = new System.Windows.Forms.TextBox();
            this.labDownpayment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lab_Principal
            // 
            this.Lab_Principal.AutoSize = true;
            this.Lab_Principal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Principal.Location = new System.Drawing.Point(43, 62);
            this.Lab_Principal.Name = "Lab_Principal";
            this.Lab_Principal.Size = new System.Drawing.Size(138, 25);
            this.Lab_Principal.TabIndex = 0;
            this.Lab_Principal.Text = "貸款金額($)：";
            // 
            // Lab_Rate
            // 
            this.Lab_Rate.AutoSize = true;
            this.Lab_Rate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Rate.Location = new System.Drawing.Point(43, 123);
            this.Lab_Rate.Name = "Lab_Rate";
            this.Lab_Rate.Size = new System.Drawing.Size(124, 25);
            this.Lab_Rate.TabIndex = 1;
            this.Lab_Rate.Text = "年利率(%)：";
            // 
            // Lab_Period
            // 
            this.Lab_Period.AutoSize = true;
            this.Lab_Period.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Period.Location = new System.Drawing.Point(43, 184);
            this.Lab_Period.Name = "Lab_Period";
            this.Lab_Period.Size = new System.Drawing.Size(146, 25);
            this.Lab_Period.TabIndex = 2;
            this.Lab_Period.Text = "貸款期數(月)：";
            // 
            // btnMonthpay
            // 
            this.btnMonthpay.BackColor = System.Drawing.Color.Beige;
            this.btnMonthpay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthpay.Location = new System.Drawing.Point(48, 328);
            this.btnMonthpay.Name = "btnMonthpay";
            this.btnMonthpay.Size = new System.Drawing.Size(181, 58);
            this.btnMonthpay.TabIndex = 4;
            this.btnMonthpay.Text = "PTM(月付額)";
            this.btnMonthpay.UseVisualStyleBackColor = false;
            this.btnMonthpay.Click += new System.EventHandler(this.btnMonthpay_Click);
            // 
            // btnTotalpay
            // 
            this.btnTotalpay.BackColor = System.Drawing.Color.Beige;
            this.btnTotalpay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalpay.Location = new System.Drawing.Point(276, 328);
            this.btnTotalpay.Name = "btnTotalpay";
            this.btnTotalpay.Size = new System.Drawing.Size(148, 58);
            this.btnTotalpay.TabIndex = 5;
            this.btnTotalpay.Text = "總付款";
            this.btnTotalpay.UseVisualStyleBackColor = false;
            this.btnTotalpay.Click += new System.EventHandler(this.btnTotalpay_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Beige;
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(487, 328);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(148, 58);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrincipal.Location = new System.Drawing.Point(189, 59);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(123, 34);
            this.txtPrincipal.TabIndex = 7;
            this.txtPrincipal.Text = "100000";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(189, 114);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(123, 34);
            this.txtRate.TabIndex = 8;
            this.txtRate.Text = "10";
            // 
            // txtPeriod
            // 
            this.txtPeriod.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriod.Location = new System.Drawing.Point(189, 175);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(123, 34);
            this.txtPeriod.TabIndex = 9;
            this.txtPeriod.Text = "24";
            // 
            // txtDownpayment
            // 
            this.txtDownpayment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownpayment.Location = new System.Drawing.Point(189, 232);
            this.txtDownpayment.Name = "txtDownpayment";
            this.txtDownpayment.Size = new System.Drawing.Size(123, 34);
            this.txtDownpayment.TabIndex = 11;
            this.txtDownpayment.Text = "0";
            // 
            // labDownpayment
            // 
            this.labDownpayment.AutoSize = true;
            this.labDownpayment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDownpayment.Location = new System.Drawing.Point(43, 241);
            this.labDownpayment.Name = "labDownpayment";
            this.labDownpayment.Size = new System.Drawing.Size(92, 25);
            this.labDownpayment.TabIndex = 10;
            this.labDownpayment.Text = "頭期款：";
            // 
            // Frm_F02_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDownpayment);
            this.Controls.Add(this.labDownpayment);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotalpay);
            this.Controls.Add(this.btnMonthpay);
            this.Controls.Add(this.Lab_Period);
            this.Controls.Add(this.Lab_Rate);
            this.Controls.Add(this.Lab_Principal);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Name = "Frm_F02_Loan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_Principal;
        private System.Windows.Forms.Label Lab_Rate;
        private System.Windows.Forms.Label Lab_Period;
        private System.Windows.Forms.Button btnMonthpay;
        private System.Windows.Forms.Button btnTotalpay;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.TextBox txtDownpayment;
        private System.Windows.Forms.Label labDownpayment;
    }
}