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
        int t = 180, k = 0;
        int tm, ts;
        string[] slova_v_rtb = new string[10];
        int cv;
        int [] nom = new int[10];
       
        Random rand = new Random();

        int n, q;

        string path = Application.StartupPath + "\\Result.txt";

        public static int  vvrk(int n, RichTextBox richTextBox1)
        {
        Random rand = new Random();
            
             n = rand.Next(6, 12);
            char[,] a = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = (char)rand.Next(0x0430, 0x44F);

                    if (a[i, j].Equals('э'))
                        a[i, j] = 'є';
                    if (a[i, j].Equals('ё'))
                        a[i, j] = 'ї';
                    if (a[i, j].Equals('и'))
                        a[i, j] = 'і';
                    if (a[i, j].Equals('ъ'))
                        a[i, j] = 'а';
                    if (a[i, j].Equals('ы'))
                        a[i, j] = 'и';

                    richTextBox1.AppendText(a[i, j].ToString());

                }
            }
            return (n);
        }
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

            else
            { txttime.Text = "Stop"; timer2.Start(); string appendText = "Оберіть картинку - " + k.ToString() + Environment.NewLine;
                File.AppendAllText(path, appendText, Encoding.UTF8);
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (richTextBox1.SelectedText == slova_v_rtb[i])
                {
                    richTextBox1.SelectionFont = new Font("Verdana", 18, FontStyle.Italic);
                    k++;
                }
            }
            
        }
        int ksec = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            ksec++;
            if (ksec == 10)
            {
                Choose ff = new Choose();
                ff.Show();
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button4.Visible = false;
            richTextBox1.Clear();
            button3.Visible = true;

            string[] slova = {"собака", "бантик", "болото", "акація", "вівчар",
                "геймер", "джинса", "діяння", "долоня", "дорога", "зубець",
                "істина", "камінь", "колесо", "квітка", "клімат", "місяць",
                "палата", "патрон", "прадід", "сварка", "свічка", "силует", "трофей", "спосіб",
            "яблуко", "частка"};

            bool exit = false;
            int q = 10;
            int[] m = new int[10];
            for (int i = 0; i < q; i++)
            {
                int p = rand.Next(slova.Length);

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
                    slova_v_rtb[i] = slova[p];
                    m[i] = p;
                }
                else
                {
                    exit = false;
                    i--;
                }

            }

            cv = n * n - 6;

            for (int s = 0; s < q; s++)
            {
                if (s == 0)
                {
                    vvrk(n, richTextBox1);
                }
                else { vvrk(n, richTextBox1); }

                richTextBox1.AppendText(slova_v_rtb[s]);
                string str = richTextBox1.Text;
                for (int p = 0; p < 10; p++)
                {
                    if (str.Contains(slova_v_rtb[p]))
                        nom[p] = str.IndexOf(slova_v_rtb[p]);
                }
                richTextBox1.AppendText("пфрлрщдшорвдіраушцщгоажфпм");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
            q = 10;
            string appendText = "Увага - " + k.ToString() + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);
            Main.points += k;
            for (int s = 0; s < q; s++)
            {
                richTextBox1.Select(nom[s], slova_v_rtb[s].Length);
                richTextBox1.SelectionColor = Color.Red;
            }
        }

        
    }




}

