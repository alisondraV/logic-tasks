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

        int index = 0;
        public static int level = 0;
        public static int points = 0;

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text == "" || txtFirstName.Text == "")
                MessageBox.Show("Please enter your full name", "Error");
            else
            {
                StreamWriter sw = File.CreateText("Result.txt");
                sw.WriteLine(txtLastName.Text + " " + txtFirstName.Text);
                index = cbLevel.SelectedIndex;
                if (index == 0)
                {
                    sw.WriteLine("1st level");
                    level = 1;
                }
                else
                {
                    sw.WriteLine("2nd level");
                    level = 2;
                }

                Choose choose = new Choose();
                choose.Show();
                this.Hide();
                sw.Close();
            }
        }
    }
}
