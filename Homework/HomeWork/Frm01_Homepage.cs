using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls.Ribbon;

namespace HomeWork
{
    public partial class Frm_HomePage : Form
    {
        public Frm_HomePage()
        {
            InitializeComponent();
        }

        private void btnCallFrm02_Click(object sender, EventArgs e)
        {
            Frm02_Hello frm1 = new Frm02_Hello();
            frm1.TopLevel = false;
            this.pnlHomePage.Controls.Clear();
            this.pnlHomePage.Controls.Add(frm1);
            frm1.Show();            
        }

        private void btnCallFrm03_Click(object sender, EventArgs e)
        {
            Frm03_Loan frm1 = new Frm03_Loan();
            frm1.TopLevel = false;
            this.pnlHomePage.Controls.Clear();
            this.pnlHomePage.Controls.Add(frm1);
            frm1.Show();
        }

        private void btnCallFrm04_Click(object sender, EventArgs e)
        {
            Frm04_POS frm = new Frm04_POS();
            frm.TopLevel = false;
            this.pnlHomePage.Controls.Clear();
            this.pnlHomePage.Controls.Add(frm);
            frm.Show();
        }

        private void btnCallFrm05_Click(object sender, EventArgs e)
        {
            Frm05_Score_StructForm frm= new Frm05_Score_StructForm();
            frm.TopLevel = false;
            this.pnlHomePage.Controls.Clear();
            this.pnlHomePage.Controls.Add(frm);
            frm.Show();
        }

        private void btnCallFrm06_Click(object sender, EventArgs e)
        {
            Frm06_計算機 frm = new Frm06_計算機();
            frm.TopLevel = false;
            this.pnlHomePage.Controls.Clear();
            this.pnlHomePage.Controls.Add(frm);
            frm.Show();
        }

        private void btnCallFrm07_Click(object sender, EventArgs e)
        {
            Frm07_Notepad frm = new Frm07_Notepad();
            frm.TopLevel = true;
            this.pnlHomePage.Controls.Clear();
            frm.Show();
        }

        private void btnCallFrm08_Click(object sender, EventArgs e)
        {
            Frm08_ScreenSaver frm = new Frm08_ScreenSaver();
            frm.TopLevel = true;
            this.pnlHomePage.Controls.Clear();
            frm.Show();
        }

        private void btnCallFrm09_Click(object sender, EventArgs e)
        {
            Frm09_PictureViewer frm = new Frm09_PictureViewer();
            frm.TopLevel = false;
            this.pnlHomePage.Controls.Clear();
            this.pnlHomePage.Controls.Add(frm);
            frm.Show();
        }

        private void btnCallFrm10_Click(object sender, EventArgs e)
        {
            Frm10_GuessNumber frm = new Frm10_GuessNumber();
            frm.TopLevel = false;
            this.pnlHomePage.Controls.Clear();
            this.pnlHomePage.Controls.Add(frm);
            frm.Show();
        }
    }
}
