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
    public partial class Attention : Form
    {
        public Attention()
        {
            InitializeComponent();
        }
        int time = 180;
        int secondsLeave = 0;

        int points = 0;
        int timeMinutes;
        int timeSeconds;
        string[] wordsInRTB = new string[10];
        int [] number = new int[10];
        const int numberOfWords = 10;
        bool exit = false;
        int[] m = new int[10];

        Random rand = new Random();
        string resultPath = Application.StartupPath + "\\Result.txt";
        string wordsPath = Application.StartupPath + "\\Words\\2.txt";
        string[] wordList;

        public void AddWords(int n, RichTextBox rtbWords)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                timeMinutes = time / 60;
                timeSeconds = time % 60;
                if (timeSeconds >= 10)
                    txttime.Text = timeMinutes.ToString() + ":" + timeSeconds.ToString();
                else
                    txttime.Text = timeMinutes.ToString() + ":0" + timeSeconds.ToString();
            }
            else
            {
                Stop();
            }
        }

        private void rbtWords_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (rtbWords.SelectedText == wordsInRTB[i])
                {
                    rtbWords.SelectionFont = new Font("Verdana", 18, FontStyle.Italic);
                    points++;
                }
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnStart.Visible = false;
            rtbWords.Clear();
            btnFinish.Visible = true;

            wordList = File.ReadAllLines(wordsPath);
            for (int i = 0; i < numberOfWords; i++)
            {
                int p = rand.Next(wordList.Length);

                if (i > 0)
                {
                    for (int j = 0; j < i; j++)
                        if (m[j] == p)
                        {
                            exit = true;
                            break;
                        }
                }
                if (exit == false)
                {
                    wordsInRTB[i] = wordList[p];
                    m[i] = p;
                }
                else
                {
                    exit = false;
                    i--;
                }
            }

            for (int i = 0; i < numberOfWords; i++)
            {
                int randLetters = rand.Next(70, 80);
                for (int j = 0; j < randLetters; j++)
                {
                    int a = rand.Next(0, 26);
                    char ch = (char)('a' + a);
                    rtbWords.AppendText(ch.ToString());
                }

                rtbWords.AppendText(wordsInRTB[i]);
                string str = rtbWords.Text;
                for (int j = 0; j < 10; j++)
                {
                    if (str.Contains(wordsInRTB[j]))
                        number[j] = str.IndexOf(wordsInRTB[j]);
                }
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Stop();
        }

        void Stop()
        {
            timer1.Stop();
            string appendText = $"Words - {points.ToString()}\n";
            File.AppendAllText(resultPath, appendText);
            Main.points += points;
            timer2.Start();

            for (int i = 0; i < numberOfWords; i++)
            {
                rtbWords.Select(number[i], wordsInRTB[i].Length);
                rtbWords.SelectionColor = Color.Red;
            }
        }
    }
}

