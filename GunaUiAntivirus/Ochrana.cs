﻿using System;
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
    public partial class Ochrana : Form
    {
        public Ochrana()
        {
            InitializeComponent();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Form1 cat = new Form1();
            cat.Show();
            this.Hide();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            Scam cat = new Scam();
            cat.Show();
            this.Hide();
        }

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {
            Scam cat = new Scam();
            cat.Show();
            this.Hide();
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            Scam cat = new Scam();
            cat.Show();
            this.Hide();
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            Scam cat = new Scam();
            cat.Show();
            this.Hide();
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            Scam cat = new Scam();
            cat.Show();
            this.Hide();
        }

        private void gunaGradientButton5_Click(object sender, EventArgs e)
        {
            Scam cat = new Scam();
            cat.Show();
            this.Hide();
        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
            Scam cat = new Scam();
            cat.Show();
            this.Hide();
        }

        private void gunaGradientButton7_Click(object sender, EventArgs e)
        {
            Scam cat = new Scam();
            cat.Show();
            this.Hide();
        }

        private void gunaGradientButton8_Click(object sender, EventArgs e)
        {
            Scam cat = new Scam();
            cat.Show();
            this.Hide();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Sukromie cat = new Sukromie();
            cat.Show();
            this.Hide();
        }
    }
}
