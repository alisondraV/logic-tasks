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
    public partial class Last : Form
    {
        public Last()
        {
            InitializeComponent();
        }

        private void Last_Load(object sender, EventArgs e)
        {
            string[] rez = File.ReadAllLines("Result.txt");
            int [] sum = new int[10];
            name.Text = rez[0];
            klas.Text = rez[1];
            //foreach (string st in rez)
            //    rezz.Text = st;
            for (int i = 2; i < rez.Length; i++)
            {
                Label label = new Label();
                label.Name = "label" + (i+4).ToString();
                label.Text = rez[i];
                label.BackColor = Color.Transparent;
                label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                label.Font = new Font("Times New Roman", 16);
                label.Size = new System.Drawing.Size(460, 25);
                label.Location = new System.Drawing.Point(400, 190 + 40 * i);
                this.Controls.Add(label);
            }
            bal.Text = Main.bali.ToString();
        }

        private void Last_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
