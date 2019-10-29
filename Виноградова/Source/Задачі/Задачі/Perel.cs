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
  
    public partial class Perel : Form
    {
        public Perel()
        {
            InitializeComponent();
        }



        int t = 180;
        int tm, ts;
        int p1h, p1w, p2h, p2w, p3h, p3w;
        int k = 0;
        int v1 = 8, v2 = 3, v3 = 5;
        int v01 = 8, v02 = 0, v03 = 0;
        


        private void pictureBox2_Click(object sender, EventArgs e)
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
                MessageBox.Show("Вітаю!");
                Main.bali += 10;
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

        private void pc5litr_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
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
                MessageBox.Show("Вітаю!");

        }
        int selected=0;   
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
            Main.bali += k;

            string appendText = "Переливання - " + k.ToString() + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);
        }

        int ksec;

        private void timer2_Tick(object sender, EventArgs e)
        {
            ksec++;
            if (ksec == 3)
            {
                Choose ff = new Choose();
                ff.Show();
                this.Close();
            }
        }

        SolidBrush brush = new SolidBrush(Color.Aqua);
        Graphics gr, gr1, gr2;

      

        private void button4_Click(object sender, EventArgs e)
        {
            Start.Visible = false;
            pc3litr.Enabled = true;
            pc5litr.Enabled = true;
            pc8litr.Enabled = true;
            timer1.Start();
            Finish.Visible = true;
            gr = pc8litr.CreateGraphics();
            gr1 = pc3litr.CreateGraphics();
            gr2 = pc5litr.CreateGraphics();
        
            p1h = pc8litr.Height;
            p2h = pc3litr.Height;
            p3h = pc5litr.Height;
            p1w = pc8litr.Width;
            p2w = pc3litr.Width;
            p3w = pc5litr.Width;

            v01 = v1;
            v02 = 0;
            v03 = 0;
            selected = 0;
            draw_box();
        }

        string path = Application.StartupPath + "\\Result.txt";

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t > 0)
            {
                t--;
                tm = t / 60;
                ts = t % 60;
                if (ts >= 10)
                    txttime.Text = tm.ToString() + ":" + ts.ToString();
                else
                    txttime.Text = tm.ToString() + ":0" + ts.ToString();
            }
            else { txttime.Text = "Stop"; timer2.Start(); string appendText = "Оберіть картинку - " + k.ToString() + Environment.NewLine;
                File.AppendAllText(path, appendText, Encoding.UTF8);
            }
        }

    }
    }

