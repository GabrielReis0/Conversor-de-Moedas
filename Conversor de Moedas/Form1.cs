namespace Conversor_de_Moedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.1667;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == comboBox2.SelectedIndex)
            {
                MessageBox.Show("Não escolha o mesmo tipo de moeda.");
            }
        }
    }
}