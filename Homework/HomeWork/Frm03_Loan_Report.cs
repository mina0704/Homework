using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeWork
{
    public partial class Frm03_Loan_Report : Form
    {

        public Frm03_Loan_Report()
        {
            InitializeComponent();
        }

        public Frm03_Loan_Report(string principal, string rate, string period, string downpayment, string monthpay,string totalpay)
        {
            InitializeComponent();

            labPrincipalR.Text = principal;
            labRateR.Text = rate;
            labPeriodR.Text = period;
            labDownpaymentR.Text = downpayment;
            labMonthpayR.Text = monthpay;
            labTotalpayR.Text = totalpay;
        }


        private void Frm2_Load(object sender, EventArgs e)
        {

            Frm03_Loan frm2 = new Frm03_Loan();
        }

    }
}
