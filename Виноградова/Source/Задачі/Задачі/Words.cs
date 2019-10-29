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
    public partial class Words : Form
    {
        public Words()
        {
            InitializeComponent();
        }

        int t = 180, k = 0, tres = 0, tm = 0, ts = 0;
        string path = Application.StartupPath + "\\Result.txt";
        string path1 = Application.StartupPath + "\\Words\\";

        Label[] texts = new Label[7];
        Label[] texts1 = new Label[8];
        string[] nazva = new string[20];

        void Stop()
        {
            timer1.Stop();
            if (k == 0)
                lblres.Text = "За цю задачу ви не набрали жодного балу";
            if (k == 1)
                lblres.Text = "За цю задачу ви набрали " + k.ToString() + " бал";
            if (k == 2 || k == 3 || k == 4)
                lblres.Text = "За цю задачу ви набрали " + k.ToString() + " бали";
            if (k == 5)
                lblres.Text = "За цю задачу ви набрали " + k.ToString() + " балів";

            string appendText = "Слова - " + k.ToString() + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);
            Main.bali += k;
            timer2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer3.Start();
            button1.Visible = false;
            button2.Visible = true;
            pictureBox1.Visible = false;
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

        void NazCreate()
        {
            if (Main.klas == 7)
            {
                string[] lines = File.ReadAllLines(path1 + "7.txt", Encoding.UTF8);
                for (int i = 0; i < 20; i++)
                    nazva[i] = lines[i];
            }
            if (Main.klas == 8)
            {
                string[] lines = File.ReadAllLines(path1 + "8.txt", Encoding.UTF8);
                for (int i = 0; i < 20; i++)
                    nazva[i] = lines[i];
            }
        }

        int[] q = new int[20];

        void Choose()
        {
            int x, y;
            Random rand = new Random();

            for (int i = 0; i < 20; i++)
                q[i] = i;

            for (int i = 0; i < 20; i++)
            {
                x = i + rand.Next(20 - i);
                y = q[x];
                q[x] = q[i];
                q[i] = y;
            }
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

        int sh = 240, left = 60;
        string[] nazva1 = new string[8];
        string odd;

        void Vipoln()
        {
            Choose();

            for (int i = 0; i < 7; i++)
            {
                texts[i] = new Label();
                texts[i].BackColor = System.Drawing.Color.Transparent;
                texts[i].AutoSize = false;
                texts[i].TextAlign = label1.TextAlign;

                texts[i].Width = 150;
                texts[i].Height = 25;
                texts[i].Left = left;
                texts[i].Top = sh;
                sh += 46;

                texts[i].Text = nazva[q[i]];
                nazva1[i] = nazva[q[i]];
            }
            nazva1[7] = nazva[q[7]];
            odd = nazva1[7];
            this.Controls.AddRange(this.texts);
        }

        private void Words_Load(object sender, EventArgs e)
        {
            NazCreate();
            Vipoln();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Stop();
        }

        int pr = 0, sh1 = 220;

        void Choose1()
        {
            int x, y;
            Random rand = new Random();

            for (int i = 0; i < 9; i++)
                q[i] = i;

            for (int i = 0; i < 9; i++)
            {
                x = i + rand.Next(8 - i);
                y = q[x];
                q[x] = q[i];
                q[i] = y;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pr++;
            if (pr == 10)
            {
                left += 100;
                if (raz >= 1)
                    pictureBox1.Width += 100;
                pictureBox1.Visible = true;
                Choose1();
                for (int i = 0; i < 8; i++)
                {
                    texts1[i] = new Label();
                    texts1[i].BackColor = System.Drawing.Color.Transparent;
                    texts1[i].AutoSize = false;
                    texts1[i].TextAlign = label1.TextAlign;

                    texts1[i].Width = 150;
                    texts1[i].Height = 25;
                    texts1[i].Left = left;
                    texts1[i].Top = sh1;
                    sh1 += 46;
                    
                    texts1[i].Text = nazva1[q[i]];
                    texts1[i].Click += new System.EventHandler(this.labClick);
                }
                this.Controls.AddRange(this.texts1);
            }
        }

        Font myFont = new Font("Times New Roman", 16, FontStyle.Strikeout);

        int raz = 0;

        void labClick(object sender, EventArgs e)
        {
            timer3.Stop();
            int index = Array.IndexOf(texts1, sender);
            texts1[index].BringToFront();
            if (texts1[index].Text == odd)
            {
                texts1[index].Font = myFont;
                k++;
            }
            raz++;

            if (raz == 3)
                Stop();
            else
            {
                pictureBox1.Width += 100;
                pr = 0;
                left += 100;
                sh = 240;
                sh1 = 220;
                Vipoln();
                timer3.Start();
            }
        }
    }
}
