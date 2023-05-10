using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Loan
    {
        public double principal=0;
        public double downpayment=0;
        public double rate = 0;
        public double period = 0;
        public double monthpayrate = 0;
        public double mpay = 0;
        public double tpay = 0;
    }
    public class LoanReport
    {
        public string monthpayR { get; set; }
        public string totalpayR { get; set; }

    }


 public class Postimes
 {
    public int Latte = 0;
    public int Pasta = 0;
    public int Pudding = 0;
    public int Mille = 0;

}



public struct StudentScore
    {
        public string Name { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public int Score3 { get; set; }

        public StudentScore(string StudentName, int ScoreChi, int ScoreMath, int ScoreEng)
        {
            Name = StudentName;
            Score1 = ScoreChi;
            Score2 = ScoreMath;
            Score3 = ScoreEng;
        }
    }
}
