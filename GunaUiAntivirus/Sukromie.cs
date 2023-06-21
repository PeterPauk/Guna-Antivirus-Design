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
    public partial class Sukromie : Form
    {
        public Sukromie()
        {
            InitializeComponent();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Ochrana cat = new Ochrana();
            cat.Show();
            this.Hide();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Form1 cat = new Form1();
            cat.Show();
            this.Hide();
        }
    }
}
