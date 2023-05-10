using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace HomeWork
{
    public partial class Frm08_ScreenSaver : Form
    {

        public Frm08_ScreenSaver()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            timer_ScreenSaver.Enabled = true;
            timer_ScreenSaver.Tick += new EventHandler(timer_ScreenSaver_Tick);
            this.Controls.Add(PBScreenSaver);
            PBScreenSaver.Location = new Point(0, 0);
        }

        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        int directionX = 10;
        int directionY = 10;
        private void timer_ScreenSaver_Tick(object sender, EventArgs e)
        {
            {
                PBScreenSaver.Left += directionX;
                PBScreenSaver.Top += directionY;


                if (PBScreenSaver.Left <= 0 || PBScreenSaver.Right >= Width)
                {
                    directionX = -directionX;
                }
                if (PBScreenSaver.Top <= 0 || PBScreenSaver.Bottom >= Height)
                {
                    directionY = -directionY;
                }
            }
        }

        private void Frm_ScreenSaver_MouseClick(object sender, MouseEventArgs e)
        {
            timer_ScreenSaver.Enabled = false;
            this.Close();
        }

        private void Frm_ScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            timer_ScreenSaver.Enabled = false;
            this.Close();
        }

        int mousemoveX;
        int mousemoveY;
        private void Frm_ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousemoveX == 0 && mousemoveY == 0)
            {
                mousemoveX = e.X;
                mousemoveY = e.Y;
            }
            else
            {
                int deltaX = e.X - mousemoveX;
                int deltaY = e.Y - mousemoveY;
                double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
                if (distance > 10)
                {
                    timer_ScreenSaver.Enabled = false;
                    this.Close();
                }
            }
        }
    }
}
