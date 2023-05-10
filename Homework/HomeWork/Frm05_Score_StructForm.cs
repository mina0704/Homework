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
    
    public partial class Frm05_Score_StructForm : Form
    {
        private StudentScore SS;
        public Frm05_Score_StructForm()
        {
            InitializeComponent();            
            SS = new StudentScore(" ", 0, 0, 0);
        }


        private void UpdateScoreTextBox()
        {
            txtScore.Text = "姓名：" + SS.Name + "\r\n國文：" + SS.Score1 + "\r\n數學："
                + SS.Score2 + "\r\n英文：" + SS.Score3;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtScoreChi.Text, out int score1))
            {
                txtScoreChi.Text = "";
                txtScoreChi.Focus();
                MessageBox.Show("請輸入數字！", "確認輸入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtScoreMath.Text, out int score2))
            {
                txtScoreMath.Text = "";
                txtScoreMath.Focus();
                MessageBox.Show("請輸入數字！", "確認輸入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtScoreEng.Text, out int score3))
            {
                txtScoreEng.Text = "";
                txtScoreEng.Focus();
                MessageBox.Show("請輸入數字！", "確認輸入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SS.Name = txtName.Text;
            SS.Score1 = score1;
            SS.Score2 = score2;
            SS.Score3 = score3;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            UpdateScoreTextBox();
        }


        private void btnHighestLowest_Click(object sender, EventArgs e)
        {
            int score1, score2, score3;
            if (!int.TryParse(txtScoreChi.Text, out score1) || !int.TryParse(txtScoreMath.Text, out score2) || !int.TryParse(txtScoreEng.Text, out score3))
            {
                MessageBox.Show("請輸入有效的分數");
                return;
            }

            StudentScore totalscore = new StudentScore(txtName.Text, score1, score2, score3);

            int maxScore = Math.Max(totalscore.Score1, Math.Max(totalscore.Score2, totalscore.Score3));
            int minScore = Math.Min(totalscore.Score1, Math.Min(totalscore.Score2, totalscore.Score3));

            string maxSubject = "";
            string minSubject = "";

            if (maxScore == totalscore.Score1)
            {
                maxSubject = "國文";
            }
            else if (maxScore == totalscore.Score2)
            {
                maxSubject = "數學";
            }
            else if (maxScore == totalscore.Score3)
            {
                maxSubject = "英文";
            }

            if (minScore == totalscore.Score1)
            {
                minSubject = "國文";
            }
            else if (minScore == totalscore.Score2)
            {
                minSubject = "數學";
            }
            else if (minScore == totalscore.Score3)
            {
                minSubject = "英文";
            }

            txtHorLScore.Text = "最高分科目：" + maxSubject + "，分数：" + maxScore.ToString() + "\r\n"
                          + "最低分科目：" + minSubject + "，分数：" + minScore.ToString();
        }



    }
}
