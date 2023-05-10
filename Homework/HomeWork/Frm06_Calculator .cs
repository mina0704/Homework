using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Frm06_計算機 : Form
    {
        public Frm06_計算機()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal num1 = 0;
            decimal num2 = 0;
            bool isNum1 = decimal.TryParse(txtNum1.Text, out num1);
            bool isNum2 = decimal.TryParse(txtNum2.Text, out num2);
            if (isNum1)
            {
                if (isNum2)
                {
                    decimal numA = decimal.Parse(txtNum1.Text);
                    decimal numB = decimal.Parse(txtNum2.Text);
                    decimal Ans = numA + numB;
                    txtAns.Text = Ans.ToString();
                }
                else
                {
                    txtNum2.Text = "";
                    txtNum2.Focus();
                    MessageBox.Show("請輸入數字！", "確認輸入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("請輸入數字！", "確認輸入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNum1.Text = "";
                txtNum1.Focus();
            }

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            decimal num1 = 0;
            decimal num2 = 0;
            bool isNum1 = decimal.TryParse(txtNum1.Text, out num1);
            bool isNum2 = decimal.TryParse(txtNum2.Text, out num2);
            if (isNum1)
            {
                if (isNum2)
                {
                    decimal numA = decimal.Parse(txtNum1.Text);
                    decimal numB = decimal.Parse(txtNum2.Text);
                    decimal Ans = numA - numB;
                    txtAns.Text = Ans.ToString();
                }
                else
                {
                    txtNum2.Text = "";
                    txtNum2.Focus();
                    MessageBox.Show("請輸入數字！", "確認輸入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("請輸入數字！", "確認輸入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNum1.Text = "";
                txtNum1.Focus();
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            decimal num1 = 0;
            decimal num2 = 0;
            bool isNum1 = decimal.TryParse(txtNum1.Text, out num1);
            bool isNum2 = decimal.TryParse(txtNum2.Text, out num2);
            if (isNum1)
            {
                if (isNum2)
                {
                    decimal numA = decimal.Parse(txtNum1.Text);
                    decimal numB = decimal.Parse(txtNum2.Text);
                    decimal Ans = numA * numB;
                    txtAns.Text = Ans.ToString();
                }
                else
                {
                    txtNum2.Text = "";
                    txtNum2.Focus();
                    MessageBox.Show("請輸入數字！", "確認輸入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("請輸入數字！", "確認輸入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNum1.Text = "";
                txtNum1.Focus();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            decimal num1 = 0;
            decimal num2 = 0;
            bool isNum1 = decimal.TryParse(txtNum1.Text, out num1);
            bool isNum2 = decimal.TryParse(txtNum2.Text, out num2);
            if (isNum1)
            {
                if (isNum2)
                {
                    decimal numA = decimal.Parse(txtNum1.Text);
                    decimal numB = decimal.Parse(txtNum2.Text);
                    decimal Ans = numA / numB;
                    txtAns.Text = Ans.ToString();
                }
                else
                {
                    txtNum2.Text = "";
                    txtNum2.Focus();
                    MessageBox.Show("請輸入數字！", "確認輸入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("請輸入數字！", "確認輸入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNum1.Text = "";
                txtNum1.Focus();
            }
        }

    }
}
