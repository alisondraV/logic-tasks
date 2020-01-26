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

        int points = 0;
        int minutes = 0;
        int seconds = 0;
        int timeTotal = 240;
        int numberOfSeconds;
        string resultPath = Application.StartupPath + "\\Result.txt";

        void Stop()
        {
            panel1.Visible = false;

            timer1.Stop();
            if (points == 0)
            {
                lblres.Text = "You haven't scored anything in this task";
            }
            else
            {
                lblres.Text = $"You scored {points.ToString()} points";
            }

            string appendText = $"Numbers - {points.ToString()}\n";
            File.AppendAllText(resultPath, appendText, Encoding.UTF8);
            Main.points += points;
            timer2.Start();
        }

        void Check()
        {
            if (txt11.Text == "19")
                points++;
            if (txt12.Text == "22")
                points++;
            if (txt21.Text == "2")
                points++;
            if (txt22.Text == "2")
                points++;
            if (txt31.Text == "19")
                points++;
            if (txt32.Text == "20")
                points++;
            if (txt41.Text == "49")
                points++;
            if (txt42.Text == "64")
                points++;
            if (txt51.Text == "718")
                points++;
            if (txt52.Text == "192")
                points++;
            if (txt61.Text == "9")
                points++;
            if (txt62.Text == "16")
                points++;
            if (txt71.Text == "191")
                points++;
            if (txt72.Text == "383")
                points++;
            if (txt81.Text == "-720")
                points++;
            if (txt82.Text == "5040")
                points++;
            if (txt91.Text == "8")
                points++;
            if (txt92.Text == "32")
                points++;
            if (txt101.Text == "7")
                points++;
            if (txt102.Text == "94")
                points++;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeTotal > 0)
            {
                timeTotal--;
                minutes = timeTotal / 60;
                seconds = timeTotal % 60;
                if (seconds >= 10)
                    lbltime.Text = minutes.ToString() + ":" + seconds.ToString();
                else
                    lbltime.Text = minutes.ToString() + ":0" + seconds.ToString();
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
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            Start();
            timer1.Start();
            btnStart.Visible = false;
            btnFinish.Visible = true;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            btnFinish.Enabled = false;
            Check();
            Stop();
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            numberOfSeconds++;
            if (numberOfSeconds == 3)
            {
                Choose choose = new Choose();
                choose.Show();
                this.Close();
            }
        }
    }
}
