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
    public partial class Frm10_GuessNumber : Form
    {
        Random random;
        int answer;
        public Frm10_GuessNumber()
        {
            InitializeComponent();
            random = new Random();
            answer = random.Next(1, 101);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {

            int guess;
            if (!int.TryParse(txtGuess.Text, out guess) || guess < 1 || guess > 100)
            {
                LabGuess.Text = "要輸入0到100的數字啦(ﾒ ﾟ皿ﾟ)ﾒ！";
                return;
            }

            if (guess == answer)
            {
                LabGuess.Text = "答對啦! 你贏了｡:.ﾟヽ(*´∀`)ﾉﾟ.:｡";
                random = new Random();
                answer = random.Next(1, 101);
            }
            else if (guess < answer)
            {
                LabGuess.Text = "太低了! 數字在 " + guess + " 到 100 之間(´⊙ω⊙`)!";
            }
            else
            {
                LabGuess.Text = "太高了! 數字在 0 到 " + guess + " 之間(๑´ڡ`๑)!.";
            }
        }
            private void btnAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你很懶欸，答案是：" + answer + "啦(ﾒ ﾟ皿ﾟ)ﾒ");
            random = new Random();
            answer = random.Next(1, 101);
        }
    }
}
