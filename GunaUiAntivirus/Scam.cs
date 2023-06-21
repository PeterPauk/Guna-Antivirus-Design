using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunaUiAntivirus
{
    public partial class Scam : Form
    {
        public Scam()
        {
            InitializeComponent();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Scam_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {
            Form1 cat = new Form1();
            cat.Show();
            this.Hide();
        }
    }
}
