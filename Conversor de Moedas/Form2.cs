﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Conversor_de_Moedas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            btnPágConvert.Visible = false;
            label1.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void progressBar1_MouseHover(object sender, EventArgs e)
        {
            progressBar1.Value = 50;
            progressBar1.Visible = true;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 300;
            progressBar1.Value = 0;

            for (int i = 0; i <= 300; i++)
            {
                progressBar1.Value = i;

                System.Threading.Thread.Sleep(50);
            }

            progressBar1.Visible = false;
            label1.Visible = false;
            btnPágConvert.Visible = true;
        }
        private void progressBar1_MouseLeave(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
