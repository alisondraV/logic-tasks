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

        public int attention;
        public int numbers;
        public int items;
        public int transfusion;
        public int crossing;
        public int same;
        public int words;
        public int sсhulte;

        private void pbAttention_Click(object sender, EventArgs e)
        {
            Attention attentionForm = new Attention();
            attentionForm.Show();
            this.Hide();
            attention++;
        }

        private void pbNumbers_Click(object sender, EventArgs e)
        {
            Numbers numbersForm = new Numbers();
            numbersForm.Show();
            this.Hide();
            numbers++;
        }

        private void pbdvodu_Click(object sender, EventArgs e)
        {
            Same sameForm = new Same();
            sameForm.Show();
            this.Hide();
            same++;
        }

        private void pbItems_Click(object sender, EventArgs e)
        {
            Items itemsForm = new Items();
            itemsForm.Show();
            this.Hide();
            items++;
        }

        private void pbSсhulte_Click(object sender, EventArgs e)
        {
            Schulte sсhulteForm = new Schulte();
            sсhulteForm.Show();
            this.Hide();
            sсhulte++;
        }

        private void pbWords_Click(object sender, EventArgs e)
        {
            Words frm = new Words();
            frm.Show();
            this.Hide();
            words++;
        }

        private void pbCrossing_Click(object sender, EventArgs e)
        {
            Crossing frm = new Crossing();
            frm.Show();
            this.Hide();
            crossing++;
        }

        private void pbTransfusion_Click(object sender, EventArgs e)
        {
            Transfusion frm = new Transfusion();
            frm.Show();
            this.Hide();
            transfusion++;
        }

        private void Choose_Load(object sender, EventArgs e)
        {
            if (Main.level == 2)
                pbCrossing.Visible = false;
            else if (Main.level == 1)
                pbTransfusion.Visible = false;

            if (items == 1)
                pbItems.Visible = false;
            if (numbers == 1)
                pbNumbers.Visible = false;
            if (transfusion == 1)
                pbTransfusion.Visible = false;
            if (crossing == 1)
                pbCrossing.Visible = false;
            if (same == 1)
                pbdvodu.Visible = false;
            if (sсhulte == 1)
                pbSсhulte.Visible = false;
            if (attention == 1)
                pbAttention.Visible = false;
            if (words == 1)
                pbWords.Visible = false;

            if (items + numbers + transfusion + crossing + same + sсhulte + attention + words == 8)
            {
                Last last = new Last();
                last.Show();
                this.Close();
            }
        }
    }
}
