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
    public partial class Titulka : Form
    {
        public Titulka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main ff = new Main();
            ff.Show();
            this.Hide();
        }

       
    }
}
