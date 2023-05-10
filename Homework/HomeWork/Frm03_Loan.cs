using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Frm03_Loan : Form
    {
        public Frm03_Loan()
        {
            InitializeComponent();
        }

        private void btnMonthpay_Click(object sender, EventArgs e)
        {
            btnMonthpay_Click(sender, e, txtPeriod);
        }

        Loan loan = new Loan();
        LoanReport  loanrp = new LoanReport();

        private void btnMonthpay_Click(object sender, EventArgs e, TextBox txtPeriod)
        {
            int principal;
            int downpayment;
            int rate;
            int period;

            if (int.TryParse(txtPrincipal.Text, out principal))
            {
                loan.principal = principal;
            }
            else
            {
                txtPrincipal.Text = "";
                txtPrincipal.Focus();
                MessageBox.Show("請輸入數字！", "確認輸入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(txtDownpayment.Text, out downpayment))
            {
                loan.downpayment= downpayment;
            }
            else
            {
                txtDownpayment.Text = "";
                txtDownpayment.Focus();
                MessageBox.Show("請輸入數字！", "確認輸入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(txtRate.Text, out rate))
            {
                loan.rate  = rate;
            }
            else
            {
                txtRate.Text = "";
                txtRate.Focus();
                MessageBox.Show("請輸入數字！", "確認輸入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (int.TryParse(txtPeriod.Text, out period))
            {
                loan.period = period;
            }
            else
            {
                txtPeriod.Text = "";
                txtPeriod.Focus();
                MessageBox.Show("請輸入數字！", "確認輸入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            loan.monthpayrate = Math.Pow(1 + (loan.rate / 100 / 12), loan.period) * (loan.rate / 100 / 12) / (Math.Pow(1 + (loan.rate / 100 / 12), loan.period) - 1);
            loan.mpay = (loan.principal - loan.downpayment) * loan.monthpayrate;
            //每月應付本息金額之平均攤還率＝{[(1＋月利率)^月數]×月利率}÷{ [(1＋月利率)^月數]－1}
            //(公式中：月利率 ＝ 年利率／12 ； 月數 = 貸款年期 ｘ 12)
            //平均每月應攤付本息金額＝貸款本金×每月應付本息金額之平均攤還率＝每月應還本金金額＋每 月應付利息金額
            loanrp.monthpayR = loan.mpay.ToString("0");
            MessageBox.Show("月款額："+ loan.mpay.ToString("0")+"元");

         }

        private void btnTotalpay_Click(object sender, EventArgs e)
        {
            //每月應付利息金額＝本金餘額×月利率
            //每月應還本金金額＝平均每月應攤付本息金額－每月應付利息金額
            double principal;
            double downpayment;
            double rate;
            double period;

            if (double.TryParse(txtPrincipal.Text, out principal))
            {
                loan.principal = principal;
            }
            else
            {
                txtPrincipal.Text = "";
                txtPrincipal.Focus();
                MessageBox.Show("請輸入數字！", "確認輸入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (double.TryParse(txtDownpayment.Text, out downpayment))
            {
                loan.downpayment = downpayment;
            }
            else
            {
                txtDownpayment.Text = "";
                txtDownpayment.Focus();
                MessageBox.Show("請輸入數字！", "確認輸入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (double.TryParse(txtRate.Text, out rate))
            {
                loan.rate = rate;
            }
            else
            {
                txtRate.Text = "";
                txtRate.Focus();
                MessageBox.Show("請輸入數字！", "確認輸入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (double.TryParse(txtPeriod.Text, out period))
            {
                loan.period = period;
            }
            else
            {
                txtPeriod.Text = "";
                txtPeriod.Focus();
                MessageBox.Show("請輸入數字！", "確認輸入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            loan.monthpayrate = Math.Pow(1 + (loan.rate / 100 / 12), loan.period) * (loan.rate / 100 / 12) / (Math.Pow(1 + (loan.rate / 100 / 12), loan.period) - 1);
            loan.mpay = (loan.principal - loan.downpayment) * loan.monthpayrate;
            loan.tpay = loan.mpay * loan.period;
            loanrp.totalpayR = loan.tpay.ToString("0");
            MessageBox.Show("總付款：" + loan.tpay.ToString("0") + "元");

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            string principal = txtPrincipal.Text;
            string rate = txtRate.Text;
            string period = txtPeriod.Text;
            string downpayment = txtDownpayment.Text;
            string monthpay = loanrp.monthpayR;
            string totalpay = loanrp.totalpayR;
            Frm03_Loan_Report frmrep = new Frm03_Loan_Report(principal, rate, period, downpayment,monthpay,totalpay);
            frmrep.Show();
        }
    }
}
