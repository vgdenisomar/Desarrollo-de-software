﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hermanas_nazario
{
    public partial class Carga : Form
    {
        public Carga()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

        }

        public void probar()
        {
            progressBar1.Increment(1);
            label1.Text = progressBar1.Value.ToString() +"%";
            if(progressBar1.Value==progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                Login a = new Login();
                a.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            probar();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
