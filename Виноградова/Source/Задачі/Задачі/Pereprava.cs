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
    public partial class Pereprava : Form
    {
        public Pereprava()
        {
            InitializeComponent();
        }

        int t = 180, k = 0;
        int tm, ts;
        Point Location = new Point();
        Point WolfLoc, SheepLoc, CabbageLoc;
        List<PictureBox> pictListLeft = new List<PictureBox>();
        List<PictureBox> pictListRight = new List<PictureBox>();
        List<PictureBox> pictListLodka = new List<PictureBox>();
        bool MovePic = true;
        int ClickCount;

        string path = Application.StartupPath + "\\Result.txt";

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
            {
                txttime.Text = "Stop";timer2.Start(); string appendText = "Оберіть картинку - " + k.ToString() + Environment.NewLine;
                File.AppendAllText(path, appendText, Encoding.UTF8);
            }

            if(pictListLeft.Contains(Wolk)&& pictListLeft.Contains(Koza)&& pictListLeft.Contains(Kapusta))
            {
                k = 40 - ClickCount;
                timer1.Stop();
                MessageBox.Show(ClickCount.ToString()+" натискань", "Перемога!");
                Koza.Enabled = false;
                Kapusta.Enabled = false;
                Wolk.Enabled = false;
                timer2.Start();
            }
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            WolfLoc = Wolk.Location;
            SheepLoc = Koza.Location;
            CabbageLoc = Kapusta.Location;
            pictureBox7.SendToBack();
            pictureBox8.SendToBack();
            pictListRight.Add(Kapusta);
            pictListRight.Add(Koza);
            pictListRight.Add(Wolk);
        }

        private void Wolk_Click(object sender, EventArgs e)
        {
            if ((pictListLeft.Contains(Koza) && pictListLeft.Contains(Kapusta))
                ||( pictListRight.Contains(Koza) && pictListRight.Contains(Kapusta)))
            {
                MessageBox.Show("Обережно! Коза з'їдає капусту!");
            }
            else
            {
                Peremeschenie(Wolk, pictureBox8, WolfLoc);
                ClickCount += 1;
            }
        }

      
        private void Koza_Click(object sender, EventArgs e)
        {
            Peremeschenie(Koza, pictureBox3, SheepLoc);
            ClickCount += 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            button4.Visible = false;
            timer1.Start();
            Wolk.Enabled = true;
            Kapusta.Enabled = true;
            Koza.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Main.bali += k;
            string appendText = "Переправа - " + k.ToString() + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);
            timer2.Start();
        }

        int ksec = 0;

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

        private void Kapusta_Click(object sender, EventArgs e)
        {
            if ((pictListLeft.Contains(Wolk) && pictListLeft.Contains(Koza))||
                (pictListRight.Contains(Wolk) && pictListRight.Contains(Koza)))
            {
                MessageBox.Show("Обережно! Вовк з'їдає козу!");
            }
            else
            {
                Peremeschenie(Kapusta, pictureBox2, CabbageLoc);
                ClickCount += 1;
            }
        }

       
        void Peremeschenie(PictureBox Picture, PictureBox PictureMove, Point Loc)
        {
         
            if (Picture.Location == Loc && pictListLodka.Count == 0)
            {
                Location = pictureBox7.Location;
                Picture.Location = Location;
                MovePic = false;
                pictListLodka.Add(Picture);
                pictListRight.Remove(Picture);

            }
            else if (Picture.Location == pictureBox7.Location && !MovePic)
            {
                Location = PictureMove.Location;
                Picture.Location = Location;
                pictListLeft.Add(Picture);
                pictListLodka.Remove(Picture);
            }
            else if (Picture.Location == pictureBox7.Location && MovePic)
            {
                Location = Loc;
                Picture.Location = Location;
                pictListLodka.Remove(Picture);
                pictListRight.Add(Picture);
            }
            else if (Picture.Location == PictureMove.Location && pictListLodka.Count==0)
            {
                Location = pictureBox7.Location;
                Picture.Location = Location;
                pictListLeft.Remove(Picture);
                pictListLodka.Add(Picture);
                MovePic = true;
            }
        } 
    }
}
