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
    public partial class Schulte : Form
    {
        public Schulte()
        {
            InitializeComponent();
        }

        int top = 5;
        int left = 0;
        int minutes = 0;
        int seconds = 0;
        int endSeconds = 0;

        int lblCount = 0;
        int time = 0;
        int prevIndex = 0;
        int nextIndex = 0;
        int click = 0;
        int prevNumber = 0;
        int nextNumber = 0;
        int points = 0;
        int[] swapped = new int[49];
        Label[] labels = new Label[49];
        
        string resultPath = Application.StartupPath + "\\Result.txt";
        public int numbers = 0;
        public int size = 0;
        const int OFFSET = 85;

        private void Shulte_Load(object sender, EventArgs e)
        {
            if (Main.level == 1)
            {
                size = 6;
                pnlNumbers.Width -= 85;
                pnlNumbers.Height -= 85;
            }
            else if (Main.level == 2)
            {
                size = 7;
            }
            numbers = size * size;
        }

        void Stop()
        {
            pnlNumbers.Visible = false;
            timer1.Stop();
            if (points == 0)
            {
                lblres.Text = "You haven't scored anything in this task";
            }
            else
            {
                lblres.Text = $"You scored {points.ToString()} point(s)";
            }

            string appendText = $"Schulte - {points.ToString()}\n";
            File.AppendAllText(resultPath, appendText, Encoding.UTF8);
            Main.points += points;
            timer2.Start();
            Main.points += ((points + 1) / 2);
        }

        void LblCreate()
        {
            for (int i = 0; i < numbers; i++)
            {
                labels[i] = new Label();
                labels[i].AutoSize = false;
                labels[i].Width = 80;
                labels[i].Height = 80;

                labels[i].TextAlign = label2.TextAlign;
                labels[i].BackColor = System.Drawing.Color.FloralWhite;
                labels[i].Click += new System.EventHandler(this.labClick);
            }

            for (int i = 0; i < size; i++)
            {
                left = 5;
                for (int j = 0; j < size; j++)
                {
                    labels[lblCount].Top = top;
                    labels[lblCount].Left = left;
                    left += OFFSET;
                    lblCount++;
                }
                top += OFFSET;
            }

            this.pnlNumbers.Controls.AddRange(this.labels);
        }

        void labClick(object sender, EventArgs e)
        {
            int index = Array.IndexOf(labels, sender);
            click++;
            if (click == 1)
            {
                prevNumber = Convert.ToInt32(labels[index].Tag);
                prevIndex = index;
                if (prevNumber == 1)
                {
                    labels[index].BackColor = Color.PeachPuff;
                    points++;
                }
                else
                    click = 0;
            }
            else
            {
                nextNumber = Convert.ToInt32(labels[index].Tag);
                nextIndex = index;

                if (nextNumber == prevNumber + 1)
                {
                    labels[index].BackColor = Color.PeachPuff;
                    prevIndex = nextIndex;
                    nextIndex = 0;
                    prevNumber = nextNumber;
                    points++;
                }
                else
                    points--;
            }
            if (nextNumber == numbers)
                Stop();
        }

        void Choose()
        {
            int x, y;
            Random rand = new Random();

            for (int i = 1; i <= numbers; i++)
            {
                swapped[i - 1] = i;
            }

            for (int i = 0; i < numbers; i++)
            {
                x = i + rand.Next(numbers - i);
                y = swapped[x];
                swapped[x] = swapped[i];
                swapped[i] = y;
            }
        }

        void Fill()
        {
            Random rand = new Random();
            for (int i = 0; i < numbers; i++)
            {
                labels[i].Tag = swapped[i];
                labels[i].Text = swapped[i].ToString();
                labels[i].ForeColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            LblCreate();
            Choose();
            Fill();
            btnFinish.Visible = true;
            timer1.Start();
            btnStart.Visible = false;
            pnlNumbers.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            minutes = time / 60;
            seconds = time % 60;
            if (seconds >= 10)
                lbltime.Text = minutes.ToString() + ":" + seconds.ToString();
            else
                lbltime.Text = minutes.ToString() + ":0" + seconds.ToString();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            endSeconds++;
            if (endSeconds == 3)
            {
                Choose choose = new Choose();
                choose.Show();
                this.Close();
            }
        }
    }
}
