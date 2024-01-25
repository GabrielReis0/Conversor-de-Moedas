using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_Moedas
{
    public partial class PáginaInicial : Form
    {
        public PáginaInicial()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            PáginaRegisto form1 = new PáginaRegisto();
            form1.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
