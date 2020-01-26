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

        public static bool attention = true;
        public static bool numbers = true;
        public static bool items = true;
        public static bool transfusion = true;
        public static bool crossing = true;
        public static bool same = true;
        public static bool words = true;
        public static bool sсhulte = true;
        private int gamesCount;

        private void pbAttention_Click(object sender, EventArgs e)
        {
            Attention attentionForm = new Attention();
            attentionForm.Show();
            this.Hide();
            attention = false;
            gamesCount++;
        }

        private void pbNumbers_Click(object sender, EventArgs e)
        {
            Numbers numbersForm = new Numbers();
            numbersForm.Show();
            this.Hide();
            numbers = false;
            gamesCount++;
        }

        private void pbSame_Click(object sender, EventArgs e)
        {
            Same sameForm = new Same();
            sameForm.Show();
            this.Hide();
            same = false;
            gamesCount++;
        }

        private void pbItems_Click(object sender, EventArgs e)
        {
            Items itemsForm = new Items();
            itemsForm.Show();
            this.Hide();
            items = false;
            gamesCount++;
        }

        private void pbSсhulte_Click(object sender, EventArgs e)
        {
            Schulte sсhulteForm = new Schulte();
            sсhulteForm.Show();
            this.Hide();
            sсhulte = false;
            gamesCount++;
        }

        private void pbWords_Click(object sender, EventArgs e)
        {
            Words frm = new Words();
            frm.Show();
            this.Hide();
            words = false;
            gamesCount++;
        }

        private void pbCrossing_Click(object sender, EventArgs e)
        {
            Crossing frm = new Crossing();
            frm.Show();
            this.Hide();
            crossing = false;
            gamesCount++;
        }

        private void pbTransfusion_Click(object sender, EventArgs e)
        {
            Transfusion frm = new Transfusion();
            frm.Show();
            this.Hide();
            transfusion = false;
            gamesCount++;
        }

        private void Choose_Load(object sender, EventArgs e)
        {
            if (Main.level == 2)
                pbCrossing.Visible = false;
            else if (Main.level == 1)
                pbTransfusion.Visible = false;
            
            pbItems.Visible = items;
            pbNumbers.Visible = numbers;
            pbTransfusion.Visible = transfusion;
            pbCrossing.Visible = crossing;
            pbSame.Visible = same;
            pbSсhulte.Visible = sсhulte;
            pbAttention.Visible = attention;
            pbWords.Visible = words;

            if (gamesCount == 8)
            {
                Last last = new Last();
                last.Show();
                this.Close();
            }
        }
    }
}
