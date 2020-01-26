using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace Задачі
{
  
    public partial class Transfusion : Form
    {
        public Transfusion()
        {
            InitializeComponent();
        }



        int t = 180;
        int minutes;
        int seconds;
        int secondsLeave;
        int p1h, p1w, p2h, p2w, p3h, p3w;
        int points = 0;
        int selected = 0;
        int v1 = 8, v2 = 3, v3 = 5;
        int v01 = 8, v02 = 0, v03 = 0;
        
        SolidBrush brush = new SolidBrush(Color.Aqua);
        Graphics gr, gr1, gr2;

        string resultPath = Application.StartupPath + "\\Result.txt";

        private void pbThreeL_Click(object sender, EventArgs e)
        {
            if (selected == 0)
            {
                selected = 2;
                draw_box();
                return;
            }
            if (selected == 2)
            {
                selected = 0;
                draw_box();
                return;
            }
            int vo = v2 - v02;
            int vi = 0;
            if (selected == 1) vi = v01;
            if (selected == 3) vi = v03;

            if (vi < vo) vo = vi;

            v02 += vo;

            if (selected == 1) v01 -= vo;
            if (selected == 3) v03 -= vo;

            selected = 0;
            draw_box();
            if (v01 == 4||v03 == 4)
            {
                timer1.Stop();
                MessageBox.Show("Congratulations!");
                Main.points += 10;
            }
                
        }

        private void draw_box()
        {
            gr.FillRectangle(Brushes.White, 0, 0, p1w, (v1 - v01) * 60);
            gr.FillRectangle(brush, 0, (v1 - v01) * 60, p1w, v1 * 60);
            gr1.FillRectangle(Brushes.White, 0, 0, p2w, (v2 - v02) * 60);
            gr1.FillRectangle(brush, 0, (v2 - v02) * 60, p2w, v2 * 60);
            gr2.FillRectangle(Brushes.White, 0, 0, p3w, (v3 - v03) * 60);
            gr2.FillRectangle(brush, 0, (v3 - v03) * 60, p3w, v3 * 60);

        }

        private void pbFiveL_Click(object sender, EventArgs e)
        {
            if (selected == 0)
            {
                selected = 3;
                draw_box();
                return;
            }
            if (selected == 3)
            {
                selected = 0;
                draw_box();
                return;
            }
            int vo = v3 - v03;
            int vi = 0;
            if (selected == 1) vi = v01;
            if (selected == 2) vi = v02;

            if (vi < vo) vo = vi;

            v03 += vo;

            if (selected == 1) v01 -= vo;
            if (selected == 2) v02 -= vo;

            selected = 0;
            draw_box();
            if (v03 == 4||v01 == 4)
                MessageBox.Show("Вітаю!");
        }

        private void pbEightL_Click(object sender, EventArgs e)
        {
            if (selected == 0)
            {
                selected = 1;
                draw_box();
                return;
            }
            if (selected == 1)
            {
                selected = 0;
                draw_box();
                return;
            }
            int vo = v1 - v01;
            int vi = 0;
            if (selected == 2) vi = v02;
            if (selected == 3) vi = v03;

            if (vi < vo) vo = vi;

            v01 += vo;

            if (selected == 2) v02 -= vo;
            if (selected == 3) v03 -= vo;
            selected = 0;

            draw_box();
            if (v03 == 4 || v01 == 4)
                MessageBox.Show("Congratulations!");

        }
         
        private void btnFinish_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            secondsLeave++;
            if (secondsLeave == 3)
            {
                Choose choose = new Choose();
                choose.Show();
                this.Close();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            pbThreeL.Enabled = true;
            pbFiveL.Enabled = true;
            pbEightL.Enabled = true;
            timer1.Start();
            btnFinish.Visible = true;
            gr = pbEightL.CreateGraphics();
            gr1 = pbThreeL.CreateGraphics();
            gr2 = pbFiveL.CreateGraphics();
        
            p1h = pbEightL.Height;
            p2h = pbThreeL.Height;
            p3h = pbFiveL.Height;
            p1w = pbEightL.Width;
            p2w = pbThreeL.Width;
            p3w = pbFiveL.Width;

            v01 = v1;
            v02 = 0;
            v03 = 0;
            selected = 0;
            draw_box();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t > 0)
            {
                t--;
                minutes = t / 60;
                seconds = t % 60;
                if (seconds >= 10)
                    lblTime.Text = minutes.ToString() + ":" + seconds.ToString();
                else
                    lblTime.Text = minutes.ToString() + ":0" + seconds.ToString();
            }
            else {
                lblTime.Text = "Stop";
                Stop();
            }
        }

        void Stop()
        {
            timer1.Stop();

            string appendText = $"Transfusion - {points.ToString()}\n";
            File.AppendAllText(resultPath, appendText, Encoding.UTF8);
            Main.points += points;
            timer2.Start();
        }
    }
}