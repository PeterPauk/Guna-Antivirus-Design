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
            if(gunaCircleProgressBar1.Value == 100)
            {
                startPoint1 += 2;
                gunaCircleProgressBar2.Value = startPoint1;
                if(gunaCircleProgressBar2.Value == 100)
                {
                    startPoint2 += 2;
                    gunaCircleProgressBar3.Value = startPoint2;
                    if(gunaCircleProgressBar3.Value == 100)
                    {
                        startPoint3 += 2;
                        gunaCircleProgressBar4.Value = startPoint3;
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
    }
}
