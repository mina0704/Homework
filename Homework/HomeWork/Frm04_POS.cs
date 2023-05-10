using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Frm04_POS : Form
    {
        public Frm04_POS()
        {
            InitializeComponent();
        }

        Postimes times = new Postimes();

        void OrderListShow()
        {
            int total = times.Latte * 120 + times.Pasta * 150 + times.Pudding * 80 + times.Mille * 100;
            txtTotal.Text = total + "元";
            txtOrderList.Text = "";

            if (times.Latte > 0)
            { txtOrderList.Text = "抹茶拿鐵x" + times.Latte + ",共NT$" + times.Latte * 120 + "元"+"\r\n"; }
            if (times.Pasta > 0)
            { txtOrderList.Text += "義大利麵x" + times.Pasta + ",共NT$" + times.Pasta * 150 + "元"+ "\r\n"; }
            if (times.Pudding > 0)
            { txtOrderList.Text += "烤布蕾x" + times.Pudding + ",共NT$" + times.Pudding * 80 + "元"+ "\r\n"; }
            if (times.Mille > 0)
            { txtOrderList.Text += "千層派x" + times.Mille + ",共NT$" + times.Mille * 100 + "元"+ "\r\n"; }
        }


        private void btnLatte_Click(object sender, EventArgs e)
        {
            times.Latte++;
            OrderListShow();
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            times.Pasta++;
            OrderListShow();
        }

        private void btnPudding_Click(object sender, EventArgs e)
        {
            times.Pudding++;
            OrderListShow();

        }

        private void btnMille_Click(object sender, EventArgs e)
        {
            times.Mille++;
            OrderListShow();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            times.Latte =0;
            times.Pasta=0;
            times.Pudding=0;
            times.Mille = 0;
            txtOrderList.Text = string.Empty;
            txtTotal.Text = "0 元";
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            int total = times.Latte * 120 + times.Pasta * 150 + times.Pudding * 80 + times.Mille * 100;
            if (total > 0)
            {
                MessageBox.Show("總金額：NT$" + total + "元","確認付款");
            }
            else
            {
                MessageBox.Show("尚未點餐！", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            int total = times.Latte * 120 + times.Pasta * 150 + times.Pudding * 80 + times.Mille * 100;
            if (total > 0)
            {
                MessageBox.Show("總金額：NT$" + total * 0.9 + "元", "確認付款");
            } 
            else
            {
                MessageBox.Show("尚未點餐！","確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
