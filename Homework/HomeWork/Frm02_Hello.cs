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
    public partial class Frm02_Hello : Form
    {
        public Frm02_Hello()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LabName_Click(object sender, EventArgs e)
        {

        }
        private void LabSex_Click(object sender, EventArgs e)
        {

        }
        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string englishname = txtEnglishName.Text;
            string Sex = txtSex.Text;
            string Signs = txtSigns.Text;
            MessageBox.Show("Hello,我是" + name + "," + "\r\n"
               + "我的英文名字是" + englishname + "," + "\r\n"
               + "我的性別是" + Sex + "," + "\r\n"
               + "我的星座是" + Signs + "," + "\r\n"
               + "很高興認識你。");
        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string englishname = txtEnglishName.Text;
            string Sex = txtSex.Text;
            string Signs = txtSigns.Text;
            MessageBox.Show("HI, 我是" + name + "," + "\r\n"
               + "我的英文名字是" + englishname + "," + "\r\n"
               + "我的性別是" + Sex + "," + "\r\n"
               + "我的星座是" + Signs + "," + "\r\n"
               + "很高興認識你。");
        }


    }
}
