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
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        public static int u, n, i, ob, pl, pp, s, v, w, sh;


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Uvaga frm = new Uvaga();
            frm.Show();
            this.Hide();
            u++;
        }

        private void pbchru_Click(object sender, EventArgs e)
        {
            Numbers frm = new Numbers();
            frm.Show();
            this.Hide();
            n++;
        }

        private void pbdvodu_Click(object sender, EventArgs e)
        {
            Same frm = new Same();
            frm.Show();
            this.Hide();
            s++;
        }

        private void pbznpru_Click(object sender, EventArgs e)
        {
            Items frm = new Items();
            frm.Show();
            this.Hide();
            i++;
        }

        private void pbtshu_Click(object sender, EventArgs e)
        {
            Shulte frm = new Shulte();
            frm.Show();
            this.Hide();
            sh++;
        }

        private void pbsl_Click(object sender, EventArgs e)
        {
            Words frm = new Words();
            frm.Show();
            this.Hide();
            w++;
        }

        private void pbobku_Click(object sender, EventArgs e)
        {
            Ober_kartinku frm = new Ober_kartinku();
            frm.Show();
            this.Hide();
            ob++;
        }

        private void pbvstsl_Click(object sender, EventArgs e)
        {
            Vstav_slv frm = new Vstav_slv();
            frm.Show();
            this.Hide();
            v++;
        }

        private void pbperu_Click(object sender, EventArgs e)
        {
            Pereprava frm = new Pereprava();
            frm.Show();
            this.Hide();
            pp++;
        }

        private void pbperel_Click(object sender, EventArgs e)
        {
            Perel frm = new Perel();
            frm.Show();
            this.Hide();
            pl++;
        }

        private void Choose_Load(object sender, EventArgs e)
        {
            if (Main.klas == 8)
                pbperu.Visible = false;
            else if (Main.klas == 7)
                pbperel.Visible = false;

            if (i == 1)
                pbznpru.Visible = false;
            if (n == 1)
                pbchru.Visible = false;
            if (ob == 1)
                pbobku.Visible = false;
            if (pl == 1)
                pbperel.Visible = false;
            if (pp == 1)
                pbperu.Visible = false;
            if (s == 1)
                pbdvodu.Visible = false;
            if (sh == 1)
                pbtshu.Visible = false;
            if (u == 1)
                pbuvu.Visible = false;
            if (v == 1)
                pbvstsl.Visible = false;
            if (w == 1)
                pbsl.Visible = false;

            if (i + n + ob + pl + pp + s + sh + u + v + w == 9)
            {
                Last frm = new Last();
                frm.Show();
                this.Close();
            }
        }
    }
}
