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
    public partial class Ober_kartinku : Form
    {
        public Ober_kartinku()
        {
            InitializeComponent();
        }
        int t = 180;
        int tm, ts;
        int k = 0;
        int a = 0;

        string path = Application.StartupPath + "\\Result.txt";

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            label2.Enabled = false;
            label7.Enabled = false;
            label3.Enabled = false;
            label5.Enabled = false;
            label4.Enabled = false;
            label6.Enabled = false;
            if (label7.Enabled == false && label10.Enabled == false)
            {
                timer1.Stop();
                string appendText = "Оберіть картинку - " + k.ToString() + Environment.NewLine;
                File.AppendAllText(path, appendText, Encoding.UTF8);
             
                Main.bali += k;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_DoubleClick(object sender, EventArgs e)
        {
            label2.Enabled = false;
            label7.Enabled = false;
            label3.Enabled = false;
            label5.Enabled = false;
            label4.Enabled = false;
            label6.Enabled = false;
            if (label7.Enabled == false && label10.Enabled == false)
            {
                timer1.Stop();
                string appendText = "Оберіть картинку - " + k.ToString() + Environment.NewLine;
                File.AppendAllText(path, appendText, Encoding.UTF8);
              
                Main.bali += k;
            }
            k +=7;
            kk.Text = k.ToString();
           
        }

        private void label10_DoubleClick(object sender, EventArgs e)
        {
            label10.Enabled = false;
            label14.Enabled = false;
            label13.Enabled = false;
            label12.Enabled = false;
            label9.Enabled = false;
            label11.Enabled = false;
            if (label7.Enabled == false && label10.Enabled == false)
            {
                timer1.Stop();
                string appendText = "Оберіть картинку - " + k.ToString() + Environment.NewLine;
                File.AppendAllText(path, appendText, Encoding.UTF8);
              
                Main.bali += k;
            }
            k +=8;
            kk.Text = k.ToString();
           
        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            label2.Enabled = false;
            label7.Enabled = false;
            label3.Enabled = false;
            label5.Enabled = false;
            label4.Enabled = false;
            label6.Enabled = false;
            if (label7.Enabled == false && label10.Enabled == false)
            {
                timer1.Stop();
                string appendText = "Оберіть картинку - " + k.ToString() + Environment.NewLine;
                File.AppendAllText(path, appendText, Encoding.UTF8);
              
                Main.bali += k;
            }
        }

       

        private void label5_DoubleClick(object sender, EventArgs e)
        {
            label2.Enabled = false;
            label7.Enabled = false;
            label3.Enabled = false;
            label5.Enabled = false;
            label4.Enabled = false;
            label6.Enabled = false;
            if (label7.Enabled == false && label10.Enabled == false)
            {
                timer1.Stop();
                string appendText = "Оберіть картинку - " + k.ToString() + Environment.NewLine;
                File.AppendAllText(path, appendText, Encoding.UTF8);
                timer3.Start();
                Main.bali += k;
            }
        }

        private void label14_DoubleClick(object sender, EventArgs e)
        {
            label10.Enabled = false;
            label14.Enabled = false;
            label13.Enabled = false;
            label12.Enabled = false;
            label9.Enabled = false;
            label11.Enabled = false;
            if (label7.Enabled == false && label10.Enabled == false)
            {
                timer1.Stop();
                string appendText = "Оберіть картинку - " + k.ToString() + Environment.NewLine;
                File.AppendAllText(path, appendText, Encoding.UTF8);
          
                Main.bali += k;
            }
        }

        private void label13_DoubleClick(object sender, EventArgs e)
        {
            label10.Enabled = false;
            label14.Enabled = false;
            label13.Enabled = false;
            label12.Enabled = false;
            label9.Enabled = false;
            label11.Enabled = false;
            if (label7.Enabled == false && label10.Enabled == false)
            {
                timer1.Stop();
                string appendText = "Оберіть картинку - " + k.ToString() + Environment.NewLine;
                File.AppendAllText(path, appendText, Encoding.UTF8);
             
                Main.bali += k;
            }
        }

        private void label12_DoubleClick(object sender, EventArgs e)
        {
            label10.Enabled = false;
            label14.Enabled = false;
            label13.Enabled = false;
            label12.Enabled = false;
            label9.Enabled = false;
            label11.Enabled = false;
            if (label7.Enabled == false && label10.Enabled == false)
            {
                timer1.Stop();
                string appendText = "Оберіть картинку - " + k.ToString() + Environment.NewLine;
                File.AppendAllText(path, appendText, Encoding.UTF8);
              
                Main.bali += k;
            }
        }

        private void label9_DoubleClick(object sender, EventArgs e)
        {
            label10.Enabled = false;
            label14.Enabled = false;
            label13.Enabled = false;
            label12.Enabled = false;
            label9.Enabled = false;
            label11.Enabled = false;
            if (label7.Enabled == false && label10.Enabled == false)
            {
                timer1.Stop();
                string appendText = "Оберіть картинку - " + k.ToString() + Environment.NewLine;
                File.AppendAllText(path, appendText, Encoding.UTF8);
                
                Main.bali += k;
            }
        }

        private void label11_DoubleClick(object sender, EventArgs e)
        {
            label10.Enabled = false;
            label14.Enabled = false;
            label13.Enabled = false;
            label12.Enabled = false;
            label9.Enabled = false;
            label11.Enabled = false;
            if (label7.Enabled == false && label10.Enabled == false)
            {
                timer1.Stop();
                string appendText = "Оберіть картинку - " + k.ToString() + Environment.NewLine;
                File.AppendAllText(path, appendText, Encoding.UTF8);
              
                Main.bali += k;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            a = pictureBox1.Width;
            a -= 50;
            pictureBox1.Width = a;
        }
        
        private void label4_DoubleClick(object sender, EventArgs e)
        {
            label2.Enabled = false;
            label7.Enabled = false;
            label3.Enabled = false;
            label5.Enabled = false;
            label4.Enabled = false;
            label6.Enabled = false;
            if (label7.Enabled == false && label10.Enabled == false)
            {
                timer1.Stop();
                string appendText = "Оберіть картинку - " + k.ToString() + Environment.NewLine;
                File.AppendAllText(path, appendText, Encoding.UTF8);

                Main.bali += k;
            }
        }

        private void label6_DoubleClick(object sender, EventArgs e)
        {
            label2.Enabled = false;
            label7.Enabled = false;
            label3.Enabled = false;
            label5.Enabled = false;
            label4.Enabled = false;
            label6.Enabled = false;
            if (label7.Enabled == false && label10.Enabled == false)
            {
                timer1.Stop();
                string appendText = "Оберіть картинку - " + k.ToString() + Environment.NewLine;
                File.AppendAllText(path, appendText, Encoding.UTF8);
                Main.bali += k;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button3.Visible = true;
            timer1.Start();
            button3.Visible = true;
            timer2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            string appendText = "Оберіть картинку - " + k.ToString() + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);
            timer3.Start();
            Main.bali += k;
        }

        int ksec = 0;

        private void timer3_Tick(object sender, EventArgs e)
        {
            ksec++;
            if (ksec == 3)
            {
                Choose ff = new Choose();
                ff.Show();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t > 0)
            {
                t--;
                tm = t / 60;
                ts = t % 60;
                if (ts >= 10)
                    label8.Text = tm.ToString() + ":" + ts.ToString();
                else
                    label8.Text = tm.ToString() + ":0" + ts.ToString();
            }
            else
            {
             
                timer3.Start();
                string appendText = "Оберіть картинку - " + k.ToString() + Environment.NewLine;
                File.AppendAllText(path, appendText, Encoding.UTF8);
                timer1.Stop();
               
            }
        }
        }


    }

