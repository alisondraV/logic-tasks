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

        int time = 180;
        int points = 0;
        int resultTime = 0;
        int minutes = 0;
        int seconds = 0;
        int repetition = 0;
        int timePassed = 0;
        int space = 220;
        int secondsLeave = 0;
        int[] wordsMix = new int[20];

        int indent = 240;
        int left = 60;
        string[] newWordMix = new string[8];
        string newWord;

        Font myFont = new Font("Times New Roman", 16, FontStyle.Strikeout);

        string resultPath = Application.StartupPath + "\\Result.txt";
        string wordsPath = Application.StartupPath + "\\Words\\";

        Label[] initialList = new Label[7];
        Label[] modifiedList = new Label[8];
        string[] wordList = new string[20];

        void Stop()
        {
            timer1.Stop();
            if (points == 0)
            {
                lblres.Text = "You haven't scored anything in this task";
            }
            else
            {
                lblres.Text = $"You scored {points.ToString()} points";
            }

            string appendText = $"Words - {points.ToString()}\n";
            File.AppendAllText(resultPath, appendText, Encoding.UTF8);
            Main.points += points;
            timer2.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer3.Start();
            btnStart.Visible = false;
            btnFinish.Visible = true;
            pbWords.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
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

        void WordListCreate()
        {
            if (Main.level == 1)
            {
                string[] lines = File.ReadAllLines(wordsPath + "1.txt", Encoding.UTF8);
                for (int i = 0; i < 20; i++)
                {
                    wordList[i] = lines[i];
                }
            }
            if (Main.level == 2)
            {
                string[] lines = File.ReadAllLines(wordsPath + "2.txt", Encoding.UTF8);
                for (int i = 0; i < 20; i++)
                {
                    wordList[i] = lines[i];
                }
            }
        }

        void MixWords()
        {
            int x, y;
            Random rand = new Random();

            for (int i = 0; i < 20; i++)
                wordsMix[i] = i;

            for (int i = 0; i < 20; i++)
            {
                x = i + rand.Next(20 - i);
                y = wordsMix[x];
                wordsMix[x] = wordsMix[i];
                wordsMix[i] = y;
            }
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

        void CreateList()
        {
            MixWords();

            for (int i = 0; i < 7; i++)
            {
                initialList[i] = new Label();
                initialList[i].BackColor = System.Drawing.Color.Transparent;
                initialList[i].AutoSize = false;
                initialList[i].TextAlign = label1.TextAlign;

                initialList[i].Width = 150;
                initialList[i].Height = 25;
                initialList[i].Left = left;
                initialList[i].Top = indent;
                indent += 46;

                initialList[i].Text = wordList[wordsMix[i]];
                newWordMix[i] = wordList[wordsMix[i]];
            }
            newWordMix[7] = wordList[wordsMix[7]];
            newWord = newWordMix[7];
            this.Controls.AddRange(this.initialList);
        }

        private void Words_Load(object sender, EventArgs e)
        {
            WordListCreate();
            CreateList();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Stop();
        }

        void Choose1()
        {
            int x, y;
            Random rand = new Random();

            for (int i = 0; i < 9; i++)
                wordsMix[i] = i;

            for (int i = 0; i < 9; i++)
            {
                x = i + rand.Next(8 - i);
                y = wordsMix[x];
                wordsMix[x] = wordsMix[i];
                wordsMix[i] = y;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timePassed++;
            if (timePassed == 10)
            {
                left += 100;
                if (repetition >= 1)
                {
                    pbWords.Width += 100;
                }
                pbWords.Visible = true;
                Choose1();
                for (int i = 0; i < 8; i++)
                {
                    modifiedList[i] = new Label();
                    modifiedList[i].BackColor = System.Drawing.Color.Transparent;
                    modifiedList[i].AutoSize = false;
                    modifiedList[i].TextAlign = label1.TextAlign;

                    modifiedList[i].Width = 150;
                    modifiedList[i].Height = 25;
                    modifiedList[i].Left = left;
                    modifiedList[i].Top = space;
                    space += 46;
                    
                    modifiedList[i].Text = newWordMix[wordsMix[i]];
                    modifiedList[i].Click += new System.EventHandler(this.labClick);
                }
                this.Controls.AddRange(this.modifiedList);
            }
        }

        void labClick(object sender, EventArgs e)
        {
            timer3.Stop();
            int index = Array.IndexOf(modifiedList, sender);
            modifiedList[index].BringToFront();
            if (modifiedList[index].Text == newWord)
            {
                modifiedList[index].Font = myFont;
                points++;
            }
            repetition++;

            if (repetition == 3)
                Stop();
            else
            {
                pbWords.Width += 100;
                timePassed = 0;
                left += 100;
                indent = 240;
                space = 220;
                CreateList();
                timer3.Start();
            }
        }
    }
}
