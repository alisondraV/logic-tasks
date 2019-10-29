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
    public partial class Shulte : Form
    {
        public Shulte()
        {
            InitializeComponent();
        }

        int n = 5, l = 0, tres = 0, tm = 0, ts = 0, p = 0, t = 0, ind1 = 0, ind2 = 0, click = 0, nom1 = 0, nom2 = 0, k = 0;
        int[] q = new int[49];
        Label[] labels = new Label[49];

        private void Shulte_Load(object sender, EventArgs e)
        {
            if (Main.klas == 7)
            {
                r1 = 36;
                r2 = 6;
                panel1.Width -= 85;
                panel1.Height -= 85;
            }
            else if (Main.klas == 8)
            {
                r1 = 49;
                r2 = 7;
            }
        }

        string path = Application.StartupPath + "\\Result.txt";
        public int r1 = 0, r2 = 0;

        void Stop()
        {
            panel1.Visible = false;
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
                        lblres.Text = "За цю задачу ви набрали " + ((k + 1) / 2).ToString() + " балів";
                }
            }
            lblres.Text = "За це завдання ви отримали " + ((k + 1) / 2).ToString() + " балів";
            timer1.Stop();
            timer2.Start();
            Main.bali += ((k + 1) / 2);
            string appendText = "Таблиця Шульте - " + ((k + 1)/2).ToString() + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);
        }

        void LblCreate()
        {
            for (int i = 0; i < r1; i++)
            {
                labels[i] = new Label();
                labels[i].AutoSize = false;
                labels[i].Width = 80;
                labels[i].Height = 80;

                labels[i].TextAlign = label2.TextAlign;
                labels[i].BackColor = System.Drawing.Color.FloralWhite;
                labels[i].Click += new System.EventHandler(this.labClick);
            }

            for (int i = 0; i < r2; i++)
            {
                l = 5;
                for (int j = 0; j < r2; j++)
                {
                    labels[p].Top = n;
                    labels[p].Left = l;
                    l += 85;
                    p++;
                }
                n += 85;
            }

            this.panel1.Controls.AddRange(this.labels);
        }

        void labClick(object sender, EventArgs e)
        {
            int index = Array.IndexOf(labels, sender);
            click++;
            if (click == 1)
            {
                nom1 = Convert.ToInt32(labels[index].Tag);
                ind1 = index;
                if (nom1 == 1)
                {
                    labels[index].BackColor = Color.PeachPuff;
                    k++;
                }
                else
                    click = 0;
            }
            else
            {
                nom2 = Convert.ToInt32(labels[index].Tag);
                ind2 = index;

                if (nom2 == nom1 + 1)
                {
                    labels[index].BackColor = Color.PeachPuff;
                    ind1 = ind2;
                    ind2 = 0;
                    nom1 = nom2;
                    k++;
                }
                else
                    k--;
            }
            if (nom2 == r1)
                Stop();
        }

        void Choose()
        {
            int x, y;
            Random rand = new Random();

            for (int i = 1; i <= r1; i++)
            {
                q[i - 1] = i;
            }

            for (int i = 0; i < r1; i++)
            {
                x = i + rand.Next(r1 - i);
                y = q[x];
                q[x] = q[i];
                q[i] = y;
            }
        }

        void Fill()
        {
            Random rnd = new Random();
            for (int i = 0; i < r1; i++)
            {
                labels[i].Tag = q[i];
                labels[i].Text = q[i].ToString();
                labels[i].ForeColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LblCreate();
            Choose();
            Fill();
            button2.Visible = true;
            timer1.Start();
            button1.Visible = false;
            panel1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;
            tm = t / 60;
            ts = t % 60;
            if (ts >= 10)
                lbltime.Text = tm.ToString() + ":" + ts.ToString();
            else
                lbltime.Text = tm.ToString() + ":0" + ts.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tres = t;
            Stop();
        }

        int ksec = 0;

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
    }
}
