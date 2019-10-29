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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        int n = 0;
        public static int klas = 0, bali = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpr.Text == "" || txtim.Text == "")
                MessageBox.Show("Введіть своє прізвище та ім'я!", "Помилка");
            else
            {
                StreamWriter sw = File.CreateText("Result.txt");
                sw.WriteLine(txtpr.Text + " " + txtim.Text);
                n = comboBox1.SelectedIndex;
                if (n == 0)
                {
                    sw.WriteLine("7 клас");
                    klas = 7;
                }
                else
                {
                    sw.WriteLine("8 клас");
                    klas = 8;
                }

                Choose frm = new Choose();
                frm.Show();
                this.Hide();
                sw.Close();
            }
        }
    }
}
