using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задачі
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Font myFont = new Font("Times New Roman", 16, FontStyle.Strikeout);


        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            timer1.Start();
        }

        private void lblk_MouseClick(object sender, MouseEventArgs e)
        {
            lblkava.Font = myFont;
        }

        private void lblv_MouseClick(object sender, MouseEventArgs e)
        {
            lblkv.Font = myFont;
        }

        private void lblkvp_MouseClick(object sender, MouseEventArgs e)
        {
            lblkor.Font = myFont;
        }

        private void lblnau_MouseClick(object sender, MouseEventArgs e)
        {
            lblnav.Font = myFont;
        }

        private void lblt_MouseClick(object sender, MouseEventArgs e)
        {
            lblten.Font = myFont;
        }

        private void lblo_MouseClick(object sender, MouseEventArgs e)
        {
            lblok.Font = myFont;
        }

        private void lblmet_MouseClick(object sender, MouseEventArgs e)
        {
            lblm.Font = myFont;
        }

        private void lblvz_MouseClick(object sender, MouseEventArgs e)
        {
            lblvel.Font = myFont;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
