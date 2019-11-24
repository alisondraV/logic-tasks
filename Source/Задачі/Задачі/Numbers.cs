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
    public partial class Numbers : Form
    {
        public Numbers()
        {
            InitializeComponent();
        }

        int k = 0, tm = 0, ts = 0;
        int t = 240;
        string path = Application.StartupPath + "\\Result.txt";

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
                        lblres.Text = "За цю задачу ви набрали " + k.ToString() + " балів";
                }
            }
            string appendText = "Числові ряди - " + k.ToString() + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);
            Main.points += k;
            timer2.Start();
        }

        void Check()
        {
            if (txt11.Text == "19")
                k++;
            if (txt12.Text == "22")
                k++;
            if (txt21.Text == "2")
                k++;
            if (txt22.Text == "2")
                k++;
            if (txt31.Text == "19")
                k++;
            if (txt32.Text == "20")
                k++;
            if (txt41.Text == "49")
                k++;
            if (txt42.Text == "64")
                k++;
            if (txt51.Text == "718")
                k++;
            if (txt52.Text == "192")
                k++;
            if (txt61.Text == "9")
                k++;
            if (txt62.Text == "16")
                k++;
            if (txt71.Text == "191")
                k++;
            if (txt72.Text == "383")
                k++;
            if (txt81.Text == "-720")
                k++;
            if (txt82.Text == "5040")
                k++;
            if (txt91.Text == "8")
                k++;
            if (txt92.Text == "32")
                k++;
            if (txt101.Text == "7")
                k++;
            if (txt102.Text == "94")
                k++;

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
            {
                Check();
                Stop();
                timer1.Stop();

            }
               
        }

        void Start()
        {
            panel1.Visible = true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Start();
            button1.Visible = false;
            button2.Visible = true;
            if (Main.level == 7)
            {
                k += 6;
                lbl3.Left += 200;
                txt31.Left += 200;
                txt32.Left += 200;
                lbl5.Visible = false;
                txt51.Visible = false;
                txt52.Visible = false;
                lbl8.Visible = false;
                txt81.Visible = false;
                txt82.Visible = false;
                lbl10.Visible = false;
                txt101.Visible = false;
                txt102.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            Check();
            Stop();
            timer1.Stop();
        }

       
        int ksec;

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
