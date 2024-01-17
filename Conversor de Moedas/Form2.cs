using System;
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


            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;
            progressBar1.Value = 0;

            for (int i = 0; i <= 200; i++)
            {
                progressBar1.Value = i;

                System.Threading.Thread.Sleep(50);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
