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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {
            if(gunaTextBox1.Text == "admin" || gunaTextBox2.Text == "admin")
            {
                Form1 cat = new Form1();
                cat.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Zadali ste nesprávne heslo alebo meno!");
            }
        }
    }
}
