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
                num = num * 0.19;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == comboBox2.SelectedIndex)
            {
                MessageBox.Show("Não escolha o mesmo tipo de moeda.");
            }

            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 5.35;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.91;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 1.09;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.20;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 4.90;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 3)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 920.44;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 0)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.0011;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 3)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 842.20;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 2)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.0012;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 3)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 172.33;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 1)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.0058;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 4)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.86;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 0)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 1.16;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 4)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.16;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 1)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 6.23;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 4)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.79;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 2)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 1.27;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 4)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.00093;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 3)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 1072.47;
                textBox2.Text = Convert.ToString(num);
            }

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}