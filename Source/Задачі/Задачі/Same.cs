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

namespace Задачі
{
    public partial class Same : Form
    {
        public Same()
        {
            InitializeComponent();
        }

        int k = 0, tres = 0, tm = 0, ts = 0, n = 5, l = 0, p = 0, click = 0, ind1 = 0, ind2 = 0, ind3 = 0, j = 0;
        string nom1 = "", nom2 = "";
        int t = 240;
        int[] q = new int[12];
        int[] w = new int[12];
        PictureBox[] pictures = new PictureBox[24];
        string path = Application.StartupPath + "\\Pict\\";
        string path1 = Application.StartupPath + "\\Result.txt";
        void PictCreate()
        {
            for (int i = 0; i < 24; i++)
            {
                pictures[i] = new PictureBox();
                pictures[i].Width = 150;
                pictures[i].Height = 150;
                pictures[i].Load(path + "pp.png");
                pictures[i].Click += new System.EventHandler(this.pictClick);
            }

            for (int i = 0; i < 4; i++)
            {
                l = 5;
                for (int j = 0; j < 6; j++)
                {
                    pictures[p].Top = n;
                    pictures[p].Left = l;
                    l += 155;
                    p++;
                }
                n += 155;
            }

            this.panel1.Controls.AddRange(this.pictures);
        }

        void Choose()
        {
            int x, y, x1, y1;
            Random rand = new Random();

            for (int i = 1; i < 13; i++)
            {
                q[i - 1] = i;
                w[i - 1] = i;
            }

            for (int i = 0; i < 12; i++)
            {
                x = i + rand.Next(12 - i);
                y = q[x];
                q[x] = q[i];
                q[i] = y;

                x1 = i + rand.Next(12 - i);
                y1 = w[x1];
                w[x1] = w[i];
                w[i] = y1;
            }
        }

        void FillTag()
        {
            for (int i = 0; i < 12; i++)
                pictures[i].Tag = q[i];
            for (int i = 12; i < 24; i++)
                pictures[i].Tag = w[23 - i];
        }
        
        void pictClick(object sender, EventArgs e)
        {
            int index = Array.IndexOf(pictures, sender);
            pictures[index].Load(path + pictures[index].Tag + ".jpg");
            click++;
            if (click == 1)
            {
                 nom1 = pictures[index].Tag.ToString() ;
                 ind1 = index;
            }

            if (click == 2)
            {
               
                nom2 = pictures[index].Tag.ToString();
                ind2 = index;

                if (nom1 == nom2)
                {
                    click = 0;
                    ind1 = 0;
                    ind2 = 0;
                    j++;

                    if (j == 12)
                        Stop();
                }
                else
                {
                    ind3 = ind1;
                    click = 0;
                    timer2.Start();
                    ind1 = 0;
                }
            }

            k++;
            lbln.Text = k.ToString();
        }

        void Stop()
        {
            if (k % 10 == 1 || k == 1)
                lblres.Text = "За цю задачу ви набрали " + k.ToString() + " бал";
            else
            {
                if ((k % 10 == 2 || k % 10 == 3 || k % 10 == 4 || k == 2 || k == 3 || k == 4) && k != 11 && k != 12 && k != 13 && k != 14)
                    lblres.Text = "За цю задачу ви набрали " + k.ToString() + " бали";
                else
                {
                    if (k == 0)
                        lblres.Text = "За цю задачу ви не набрали жодного балу";
                    else
                        lblres.Text = "За цю задачу ви набрали " + (80 - k).ToString() + " балів";
                }
            }

            string appendText = "Дві однакові - " + (80-k).ToString() + Environment.NewLine;
            File.AppendAllText(path1, appendText, Encoding.UTF8);
            Main.points += (80 -k);
            timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t > 0)
            {
                t--;
                tm = t / 60;
                ts = t % 60;
                if (ts >= 10)
                    lbltime.Text = tm.ToString() + ":" + ts.ToString();
                else
                    lbltime.Text = tm.ToString() + ":0" + ts.ToString();
            }
            else
                Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictCreate();
            Choose();
            FillTag();
            timer1.Start();
            panel1.Visible = true;
            label3.Visible = true;
            lbln.Visible = true;
            button2.Visible = true;
            button1.Visible = false;
        }

        int ksec = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            ksec++;
            if (ksec == 1)
            {
                ksec = 0;
                pictures[ind3].Load(path + "pp.png");
                pictures[ind2].Load(path + "pp.png");
                ind3 = 0;
                ind2 = 0;
                timer2.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            timer1.Stop();
            tres = 360 - t;
  
            Stop();
        }

        int sec = 0;

        private void timer3_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec == 3)
            {
                Choose ff = new Choose();
                ff.Show();
                this.Close();
            }
        }
    }
}
