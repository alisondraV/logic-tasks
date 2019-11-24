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
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

        int a, k = 0, tres = 0, tm = 0, ts = 0; 
        int t = 240;
        Font myFont = new Font("Times New Roman", 16, FontStyle.Strikeout);

        string path = Application.StartupPath + "\\Result.txt";
        Label[] labels = new Label[10];
        Label[] texts = new Label[5];
        string[] nazva = new string[10];

        void LblCreate()
        {
            for (int i = 0; i < 10; i++)
            {
                labels[i] = new Label();
                labels[i].AutoSize = false;
            }

            labels[0].Width = 81;
            labels[0].Height = 28;
            labels[0].Left = 184;
            labels[0].Top = 284;

            labels[1].Width = 24;
            labels[1].Height = 28;
            labels[1].Left = 612;
            labels[1].Top = 394;

            labels[2].Width = 57;
            labels[2].Height = 42;
            labels[2].Left = 239;
            labels[2].Top = 558;

            labels[3].Width = 37;
            labels[3].Height = 25;
            labels[3].Left = 707;
            labels[3].Top = 365;

            labels[4].Width = 24;
            labels[4].Height = 28;
            labels[4].Left = 668;
            labels[4].Top = 260;

            labels[5].Width = 59;
            labels[5].Height = 18;
            labels[5].Left = 663;
            labels[5].Top = 473;

            labels[6].Width = 30;
            labels[6].Height = 21;
            labels[6].Left = 306;
            labels[6].Top = 457;

            labels[7].Width = 90;
            labels[7].Height = 36;
            labels[7].Left = 470;
            labels[7].Top = 377;

            labels[8].Width = 24;
            labels[8].Height = 28;
            labels[8].Left = 759;
            labels[8].Top = 267;

            labels[9].Width = 99;
            labels[9].Height = 64;
            labels[9].Left = 288;
            labels[9].Top = 171;

            for (int i = 0; i < 10; i++)
            {
                labels[i].BackColor = System.Drawing.Color.Transparent;
                labels[i].Enabled = false;
                labels[i].Click += new System.EventHandler(this.labClick);
            }

            this.Controls.AddRange(this.labels);
        }

        void NazCreate()
        {
            nazva[0] = "Корабель";
            nazva[1] = "Чашка кави";
            nazva[2] = "Навушники";
            nazva[3] = "Окуляри";
            nazva[4] = "Квіти у вазі";
            nazva[5] = "Метелик";
            nazva[6] = "Велосипедний дзвоник";
            nazva[7] = "Тенісна ракетка";
            nazva[8] = "Капелюх";
            nazva[9] = "Мапа";
        }

        int []q=new int[10];

        void Choose()
        {
            int x, y;
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
                q[i] = i;

            for (int i = 0; i < 10; i++)
            {
                x = i + rand.Next(10 - i);
                y = q[x];
                q[x] = q[i];
                q[i] = y;
            }
        }

        void labClick(object sender, EventArgs e)
        {
            int index = Array.IndexOf(labels, sender);
            labels[index].BorderStyle = BorderStyle.FixedSingle;
            for (int i = 0; i < 5; i++)
            {
                if (texts[i].Text == nazva[index])
                    texts[i].Font = myFont;
            }
            k++;
            if (k == 5)
                Stop();

            labels[index].Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            button1.Visible = false;
            button2.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a >= 0)
            {
                a = pictureBox1.Width;
                a -= 50;
                pictureBox1.Width = a;
            }
            else pictureBox1.Visible = false;
        }

        void Stop()
        {
            timer2.Stop();
            pictureBox1.Visible = true;
            if (k == 0)
                lblres.Text = "За цю задачу ви не набрали жодного балу";
            if (k == 1)
                lblres.Text = "За цю задачу ви набрали " + k.ToString() + " бал";
            if (k == 2 || k == 3 || k == 4)
                lblres.Text = "За цю задачу ви набрали " + k.ToString() + " бали";
            if (k == 5)
                lblres.Text = "За цю задачу ви набрали " + k.ToString() + " балів";

            string appendText = "Знайди предмети - " + k.ToString() + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);
            Main.points += k;
            timer3.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
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

        int sh = 228;

        private void Items_Load(object sender, EventArgs e)
        {
            LblCreate();
            NazCreate();
            Choose();

            for (int i = 0; i < 5; i++)
                labels[q[i]].Enabled = true;

            for (int i = 0; i < 5; i++)
            {
                texts[i] = new Label();
                texts[i].BackColor = System.Drawing.Color.Transparent;
                texts[i].AutoSize = false;
                texts[i].TextAlign = label1.TextAlign;

                texts[i].Width = 232;
                texts[i].Height = 25;
                texts[i].Left = 982;
                texts[i].Top = sh;
                sh += 46;

                texts[i].Text = nazva[q[i]];
            }
            this.Controls.AddRange(this.texts);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            Stop();
        }

        int ksec = 0;

        private void timer3_Tick(object sender, EventArgs e)
        {
            ksec++;
            if (ksec == 3)
            {
                Choose ff = new Choose();
                ff.Show();
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }
    }
}
