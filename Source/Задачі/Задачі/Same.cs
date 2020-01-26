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

        int points = 0;
        int minutes = 0;
        int seconds = 0;
        int endSeconds = 0;
        int second = 0;
        int time = 240;

        const int OFFSET = 155;
        int top = 5;
        int left = 0;
        int pictNum = 0;
        int click = 0;
        int prevIndex = 0;
        int nextIndex = 0;
        int renewIndex = 0;
        int success = 0;

        string prevPictTag = "";
        string nextPictTag = "";
        int[] fillFirst = new int[12];
        int[] fillSecond = new int[12];
        PictureBox[] pictures = new PictureBox[24];
        string path = Application.StartupPath + "\\Pict\\";
        string resultPath = Application.StartupPath + "\\Result.txt";
        
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
                left = 5;
                for (int j = 0; j < 6; j++)
                {
                    pictures[pictNum].Top = top;
                    pictures[pictNum].Left = left;
                    left += OFFSET;
                    pictNum++;
                }
                top += OFFSET;
            }

            this.pnlPictures.Controls.AddRange(this.pictures);
        }

        void Choose()
        {
            int x, y, x1, y1;
            Random rand = new Random();

            for (int i = 1; i < 13; i++)
            {
                fillFirst[i - 1] = i;
                fillSecond[i - 1] = i;
            }

            for (int i = 0; i < 12; i++)
            {
                x = i + rand.Next(12 - i);
                y = fillFirst[x];
                fillFirst[x] = fillFirst[i];
                fillFirst[i] = y;

                x1 = i + rand.Next(12 - i);
                y1 = fillSecond[x1];
                fillSecond[x1] = fillSecond[i];
                fillSecond[i] = y1;
            }
        }

        void FillTag()
        {
            for (int i = 0; i < 12; i++)
                pictures[i].Tag = fillFirst[i];
            for (int i = 12; i < 24; i++)
                pictures[i].Tag = fillSecond[23 - i];
        }
        
        void pictClick(object sender, EventArgs e)
        {
            int index = Array.IndexOf(pictures, sender);
            pictures[index].Load(path + pictures[index].Tag + ".jpg");
            click++;
            if (click == 1)
            {
                 prevPictTag = pictures[index].Tag.ToString() ;
                 prevIndex = index;
            }

            if (click == 2)
            {
               
                nextPictTag = pictures[index].Tag.ToString();
                nextIndex = index;

                if (prevPictTag == nextPictTag)
                {
                    click = 0;
                    prevIndex = 0;
                    nextIndex = 0;
                    success++;

                    if (success == 12)
                        Stop();
                }
                else
                {
                    renewIndex = prevIndex;
                    click = 0;
                    timer2.Start();
                    prevIndex = 0;
                }
            }

            points++;
            lblNumberTurns.Text = points.ToString();
        }

        void Stop()
        {
            timer1.Stop();
            if (points == 0)
            {
                lblres.Text = "You haven't scored anything in this task";
            }
            else
            {
                lblres.Text = $"You scored {points.ToString()} point(s)";
            }

            string appendText = $"Same - {(80 - points).ToString()}\n";
            File.AppendAllText(resultPath, appendText, Encoding.UTF8);
            Main.points += (80 - points);
            timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                minutes = time / 60;
                seconds = time % 60;
                if (seconds >= 10)
                    lbltime.Text = minutes.ToString() + ":" + seconds.ToString();
                else
                    lbltime.Text = minutes.ToString() + ":0" + seconds.ToString();
            }
            else
                Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            PictCreate();
            Choose();
            FillTag();
            timer1.Start();
            pnlPictures.Visible = true;
            lblTurns.Visible = true;
            lblNumberTurns.Visible = true;
            btnFinish.Visible = true;
            btnStart.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            second++;
            if (second == 1)
            {
                second = 0;
                pictures[renewIndex].Load(path + "pp.png");
                pictures[nextIndex].Load(path + "pp.png");
                renewIndex = 0;
                nextIndex = 0;
                timer2.Stop();
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Stop();
        }
        
        private void timer3_Tick(object sender, EventArgs e)
        {
            endSeconds++;
            if (endSeconds == 3)
            {
                Choose seconds = new Choose();
                seconds.Show();
                this.Close();
            }
        }
    }
}
