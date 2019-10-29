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
    public partial class Vstav_slv : Form
    {
        public Vstav_slv()
        {
            InitializeComponent();
        }
        int t = 180;
        int tm, ts;
        int k = 0;
        Random rand = new Random();
        string[] slova = { "ЗВИ(...)КА", "МІ(...)ОЛАД", "ПРИК(...)АН", "ЗВІРО(...)КА", "ПІ(...)ОК", "ТРИ(...)ИЛО",
             "ГА(...)АРОНИ", "БУК(...)ОП", "СА(...)ОН", "ПАСА(...)АФА", "Г(...)ЕТА", "КАБ(...)ОШКО",
            "ЧОЛО(...)НО", "ГА(...)АКА", "ГОСПО(...)УНОК","БАМ(...)ЕТ"};

        int n;

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
            else { txttime.Text = "Stop"; timer2.Start(); string appendText = "Оберіть картинку - " + k.ToString() + Environment.NewLine;
                File.AppendAllText(path, appendText, Encoding.UTF8);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Main.bali += k;
            string appendText = "Вставте слово - " + k.ToString() + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);
            timer2.Start();

            label15.Visible = true;
            kk.Visible = true;
            label16.Visible = true;
            n = slova.Length;

            if (textBox1.Text == "чай" || textBox1.Text == "ЧАЙ" & label2.Text == "ЗВИ(...)КА")
            {
                k += 5;
            }
            if (textBox1.Text == "шок" || textBox1.Text == "ШОК" & label2.Text == "МІ(...)ОЛАД")
            {
                k += 5;
              
            }

            if (textBox1.Text == "лад" || textBox1.Text == "ЛАД" & label2.Text == "ПРИК(...)АН")
            {
                k += 5;
              
            }

            if (textBox1.Text == "бій" || textBox1.Text == "БІЙ" & label2.Text == "ЗВІРО(...)КА")
            {
                k += 5;
              
            }



            if (textBox2.Text == "лот" || textBox2.Text == "ЛОТ" & label3.Text == "ПІ(...)ОК")
            {
                k += 5;
           
            }
            if (textBox2.Text == "зуб" || textBox2.Text == "МАК" & label3.Text == "ТРИ(...)ИЛО")
            {
                k += 5;
               
            }
            if (textBox2.Text == "мак" || textBox2.Text == "МАК" & label3.Text == "ГА(...)АРО­НИ")
            {
                k += 5;
               
            }
            if (textBox2.Text == "сир" || textBox2.Text == "СИР" & label3.Text == "БУК(...)ОП")
            {
                k += 5;
             
            }



            if (textBox3.Text == "рай" || textBox3.Text == "РАЙ" & label4.Text == "СА(...)ОН")
            {
                k += 5;
              
            }
            if (textBox3.Text == "жир" || textBox3.Text == "ЖИР" & label4.Text == "ПА­СА(...)АФА")
            {
                k += 5;
                
            }
            if (textBox3.Text == "рак" || textBox3.Text == "РАК" & label4.Text == "Г(...)ЕТА")
            {
                k += 5;
             
            }
            if (textBox3.Text == "лук" || textBox3.Text == "ЛУК" & label4.Text == "КАБ(...)ОШКО")
            {
                k += 5;
               
            }



            if (textBox4.Text == "вік" || textBox4.Text == "ВІК" & label5.Text == "ЧОЛО(...)НО")
            {
                k += 5;
                
            }
            if (textBox4.Text == "мак" || textBox4.Text == "МАК" & label5.Text == "ГА(...)АКА")
            {
                k += 5;
               
            }
            if (textBox4.Text == "дар" || textBox4.Text == "ДАР" & label5.Text == "ГОС­ПО(...)УНОК")
            {
                k += 5;
                
            }
            if (textBox4.Text == "бук" || textBox4.Text == "БУК" & label5.Text == "БАМ(...)ЕТ")
            {
                k += 5;
                
            }
            kk.Text = k.ToString();

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

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            button5.Visible = false;
            timer1.Start();
         
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            int n = slova.Length;
            label2.Text = slova[rand.Next(0, n / 4)];
            label3.Text = slova[rand.Next(n / 4, n / 2)];
            label4.Text = slova[rand.Next(n / 2, 3 * n / 4)];
            label5.Text = slova[rand.Next(3 * n / 4, n - 1)];
        }

    }
}
