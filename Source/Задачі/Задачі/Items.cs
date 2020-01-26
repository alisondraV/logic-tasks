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

        int curtainWidth;
        int points = 0;
        int minutes = 0;
        int seconds = 0;
        int secondsLeave = 0;
        int time = 240;
        int offset = 228;
        int[] chosen = new int[10];
        Font myFont = new Font("Times New Roman", 16, FontStyle.Strikeout);

        string resultPath = Application.StartupPath + "\\Result.txt";
        Label[] objects = new Label[10];
        Label[] texts = new Label[5];
        string[] names = new string[10];

        void ObjCreation()
        {
            for (int i = 0; i < 10; i++)
            {
                objects[i] = new Label();
                objects[i].AutoSize = false;
            }

            objects[0].Width = 81;
            objects[0].Height = 28;
            objects[0].Left = 184;
            objects[0].Top = 284;

            objects[1].Width = 24;
            objects[1].Height = 28;
            objects[1].Left = 612;
            objects[1].Top = 394;

            objects[2].Width = 57;
            objects[2].Height = 42;
            objects[2].Left = 239;
            objects[2].Top = 558;

            objects[3].Width = 37;
            objects[3].Height = 25;
            objects[3].Left = 707;
            objects[3].Top = 365;

            objects[4].Width = 24;
            objects[4].Height = 28;
            objects[4].Left = 668;
            objects[4].Top = 260;

            objects[5].Width = 59;
            objects[5].Height = 18;
            objects[5].Left = 663;
            objects[5].Top = 473;

            objects[6].Width = 30;
            objects[6].Height = 21;
            objects[6].Left = 306;
            objects[6].Top = 457;

            objects[7].Width = 90;
            objects[7].Height = 36;
            objects[7].Left = 470;
            objects[7].Top = 377;

            objects[8].Width = 24;
            objects[8].Height = 28;
            objects[8].Left = 759;
            objects[8].Top = 267;

            objects[9].Width = 99;
            objects[9].Height = 64;
            objects[9].Left = 288;
            objects[9].Top = 171;

            for (int i = 0; i < 10; i++)
            {
                objects[i].BackColor = System.Drawing.Color.Transparent;
                objects[i].Enabled = false;
                objects[i].Click += new System.EventHandler(this.labClick);
            }

            this.Controls.AddRange(this.objects);
        }

        void NamesCreation()
        {
            names[0] = "Ship";
            names[1] = "Cup of coffee";
            names[2] = "Headphones";
            names[3] = "Glasses";
            names[4] = "Flowers in a vase";
            names[5] = "Butterfly";
            names[6] = "Bicycle bell";
            names[7] = "Tennis racket";
            names[8] = "Hat";
            names[9] = "Map";
        }
    
        void Choose()
        {
            int x, y;
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
                chosen[i] = i;

            for (int i = 0; i < 10; i++)
            {
                x = i + rand.Next(10 - i);
                y = chosen[x];
                chosen[x] = chosen[i];
                chosen[i] = y;
            }
        }

        void labClick(object sender, EventArgs e)
        {
            int index = Array.IndexOf(objects, sender);
            objects[index].BorderStyle = BorderStyle.FixedSingle;
            for (int i = 0; i < 5; i++)
            {
                if (texts[i].Text == names[index])
                    texts[i].Font = myFont;
            }
            points++;
            if (points == 5)
                Stop();

            objects[index].Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            btnStart.Visible = false;
            btnFinish.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (curtainWidth >= 0)
            {
                curtainWidth = pbCurtain.Width;
                curtainWidth -= 50;
                pbCurtain.Width = curtainWidth;
            }
            else pbCurtain.Visible = false;
        }

        void Stop()
        {
            timer2.Stop();
            pbCurtain.Visible = true;
            if (points == 0)
            {
                lblres.Text = "You haven't scored anything in this task";
            }
            else
            {
                lblres.Text = $"You scored {points.ToString()} point(s)";
            }

            string appendText = $"Items - {points.ToString()}\n";
            File.AppendAllText(resultPath, appendText, Encoding.UTF8);
            Main.points += points;
            timer3.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                minutes = time / 60;
                seconds = time % 60;
                if (seconds >= 10)
                    lblTime.Text = minutes.ToString() + ":" + seconds.ToString();
                else
                    lblTime.Text = minutes.ToString() + ":0" + seconds.ToString();
            }
            else
                Stop();
        }
        
        private void Items_Load(object sender, EventArgs e)
        {
            ObjCreation();
            NamesCreation();
            Choose();

            for (int i = 0; i < 5; i++)
                objects[chosen[i]].Enabled = true;

            for (int i = 0; i < 5; i++)
            {
                texts[i] = new Label();
                texts[i].BackColor = System.Drawing.Color.Transparent;
                texts[i].AutoSize = false;
                texts[i].TextAlign = label1.TextAlign;

                texts[i].Width = 232;
                texts[i].Height = 25;
                texts[i].Left = 982;
                texts[i].Top = offset;
                offset += 46;

                texts[i].Text = names[chosen[i]];
            }
            this.Controls.AddRange(this.texts);
        }
        
        private void btnFinish_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            secondsLeave++;
            if (secondsLeave == 3)
            {
                Choose choose = new Choose();
                choose.Show();
                this.Close();
            }
        }
    }
}
