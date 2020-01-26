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
    public partial class Crossing : Form
    {
        public Crossing()
        {
            InitializeComponent();
        }

        int time = 180;
        int points = 0;
        int minutes;
        int seconds;
        int secondsLeave = 0;

        Point Location = new Point();
        Point WolfLoc, SheepLoc, CabbageLoc;
        List<PictureBox> pictListLeft = new List<PictureBox>();
        List<PictureBox> pictListRight = new List<PictureBox>();
        List<PictureBox> pictListShuttle = new List<PictureBox>();
        bool MovePic = true;
        int ClickCount;

        string resultPath = Application.StartupPath + "\\Result.txt";

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                minutes = time / 60;
                seconds = time % 60;
                if (seconds >= 10)
                    txttime.Text = minutes.ToString() + ":" + seconds.ToString();
                else
                    txttime.Text = minutes.ToString() + ":0" + seconds.ToString();
            }
            else
            {
                txttime.Text = "Stop";
                Stop();
            }

            if(pictListLeft.Contains(pbWolf)&& pictListLeft.Contains(pbGoat)&& pictListLeft.Contains(pbCabbage))
            {
                points = 40 - ClickCount;
                timer1.Stop();
                MessageBox.Show(ClickCount.ToString() +" clicks", "Victory!");
                pbGoat.Enabled = false;
                pbCabbage.Enabled = false;
                pbWolf.Enabled = false;
                timer2.Start();
            }
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            WolfLoc = pbWolf.Location;
            SheepLoc = pbGoat.Location;
            CabbageLoc = pbCabbage.Location;
            pbShuttle.SendToBack();
            pbPlaceOne.SendToBack();
            pictListRight.Add(pbCabbage);
            pictListRight.Add(pbGoat);
            pictListRight.Add(pbWolf);
        }

        private void pbWolf_Click(object sender, EventArgs e)
        {
            if ((pictListLeft.Contains(pbGoat) && pictListLeft.Contains(pbCabbage))
                ||( pictListRight.Contains(pbGoat) && pictListRight.Contains(pbCabbage)))
            {
                MessageBox.Show("Be careful! Goat is gonna eat the cabbage!");
            }
            else
            {
                Moving(pbWolf, pbPlaceOne, WolfLoc);
                ClickCount += 1;
            }
        }

        private void pbGoat_Click(object sender, EventArgs e)
        {
            Moving(pbGoat, pbPlaceThree, SheepLoc);
            ClickCount += 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnFinish.Visible = true;
            btnStart.Visible = false;
            timer1.Start();
            pbWolf.Enabled = true;
            pbCabbage.Enabled = true;
            pbGoat.Enabled = true;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Stop();
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

        private void pbCabbage_Click(object sender, EventArgs e)
        {
            if ((pictListLeft.Contains(pbWolf) && pictListLeft.Contains(pbGoat))||
                (pictListRight.Contains(pbWolf) && pictListRight.Contains(pbGoat)))
            {
                MessageBox.Show("Be careful! Wolf's gonna eat the goat!");
            }
            else
            {
                Moving(pbCabbage, pbPlaceTwo, CabbageLoc);
                ClickCount += 1;
            }
        }
               
        void Moving(PictureBox Picture, PictureBox PictureMove, Point Loc)
        {
         
            if (Picture.Location == Loc && pictListShuttle.Count == 0)
            {
                Location = pbShuttle.Location;
                Picture.Location = Location;
                MovePic = false;
                pictListShuttle.Add(Picture);
                pictListRight.Remove(Picture);

            }
            else if (Picture.Location == pbShuttle.Location && !MovePic)
            {
                Location = PictureMove.Location;
                Picture.Location = Location;
                pictListLeft.Add(Picture);
                pictListShuttle.Remove(Picture);
            }
            else if (Picture.Location == pbShuttle.Location && MovePic)
            {
                Location = Loc;
                Picture.Location = Location;
                pictListShuttle.Remove(Picture);
                pictListRight.Add(Picture);
            }
            else if (Picture.Location == PictureMove.Location && pictListShuttle.Count==0)
            {
                Location = pbShuttle.Location;
                Picture.Location = Location;
                pictListLeft.Remove(Picture);
                pictListShuttle.Add(Picture);
                MovePic = true;
            }
        }

        void Stop()
        {
            timer1.Stop();

            string appendText = $"Crossing - {points.ToString()}\n";
            File.AppendAllText(resultPath, appendText, Encoding.UTF8);
            Main.points += points;
            timer2.Start();
        }
    }
}
