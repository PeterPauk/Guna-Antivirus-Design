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
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                timer1.Stop();
            else
                Opacity += 0.05;
        }

        int startPoint = 0;
        int startPoint1 = 0;
        int startPoint2 = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 2;
            gunaCircleProgressBar1.Value = startPoint;
            label2.Text = gunaCircleProgressBar1.Value.ToString() + "%";
            if (gunaCircleProgressBar1.Value == 100)
            {
                label1.Visible = true;
                gunaLabel2.Visible = true;
                label3.Visible = true;
                gunaCircleProgressBar2.Visible = true;
                label6.Visible = true;

                if (gunaCircleProgressBar2.Visible = true)
                {
                    startPoint1 += 2;
                    gunaCircleProgressBar2.Value = startPoint1;
                    label6.Text = gunaCircleProgressBar2.Value.ToString() + "%";

                    if(gunaCircleProgressBar2.Value == 100)
                    {
                        label5.Visible = true;
                        gunaLabel3.Visible = true;
                        label4.Visible = true;
                        gunaCircleProgressBar3.Visible = true;
                        label7.Visible = true;

                        if (gunaCircleProgressBar3.Visible = true)
                        {
                            startPoint2 += 2;
                            gunaCircleProgressBar3.Value = startPoint2;
                            label7.Text = gunaCircleProgressBar3.Value.ToString() + "%";

                            if( gunaCircleProgressBar3.Value == 100)
                            {
                                label8.Visible = true;
                                gunaLabel4.Visible = true;
                                label9.Visible = true;
                                gunaGradientTileButton1.Visible = true;
                            }
                        }
                    }
                }
            }
           
        }

        private void Control_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void gunaCircleProgressBar1_Click(object sender, EventArgs e)
        {

        }

    }
}
