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
    public partial class Scanning : Form
    {
        public Scanning()
        {
            InitializeComponent();
        }

        int startPoint = 0;
        int startPoint1 = 0;
        int startPoint2 = 0;
        int startPoint3 = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 2;
            gunaCircleProgressBar1.Value = startPoint;
            label10.Text = gunaCircleProgressBar1.Value.ToString() + "%";
            if (gunaCircleProgressBar1.Value == 100)
            {
                gunaPictureBox1.Visible = true;
                label5.Visible = true;
                startPoint1 += 2;
                gunaCircleProgressBar2.Value = startPoint1;
                label9.Visible = false;
                label11.Visible = true;
                label10.Text = gunaCircleProgressBar2.Value.ToString() + "%";
                
                if (gunaCircleProgressBar2.Value == 100)
                {
                    gunaPictureBox2.Visible = true;
                    label6.Visible = true;
                    startPoint2 += 2;
                    gunaCircleProgressBar3.Value = startPoint2;
                    label11.Visible = false;
                    label12.Visible = true;
                    label10.Text = gunaCircleProgressBar3.Value.ToString() + "%";
                    if (gunaCircleProgressBar3.Value == 100)
                    {
                        gunaPictureBox3.Visible = true;
                        label7.Visible = true;
                        startPoint3 += 2;
                        gunaCircleProgressBar4.Value = startPoint3;
                        label12.Visible = false;
                        label13.Visible = true;
                        label10.Text = gunaCircleProgressBar4.Value.ToString() + "%";


                        if (gunaCircleProgressBar4.Value == 100)
                        {
                            gunaPictureBox4.Visible = true;
                            label8.Visible = true;
                            label10.Visible = false;
                            label13.Visible = false;
                            label14.Visible = true;
                            
                        }
                    }
                }
            }

        }

        private void Scanning_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void gunaCircleProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {
            Form1 cat = new Form1();
            cat.Show();
            this.Hide();
        }
    }
}
