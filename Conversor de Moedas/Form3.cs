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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
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
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 5)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 145.45;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 2)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.0069;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 5)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 159.52;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 0)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.0063;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 1)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.0034;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 5)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 29.72;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 3)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 5.79;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 5)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.17;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 5)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 185.32;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 4)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.0053;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 6)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 4326.09;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 0)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.00023;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 6)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 806.025;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 1)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.0012;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 6)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 3944.12;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 2)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.00025;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 6)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 4.667;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 3)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.21;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 4)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.00019;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 6)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 5029.49;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 6)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 27.10;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 5)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.0368;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 7)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 91.14;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 7 && comboBox2.SelectedIndex == 0)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.0010;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 7)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 16.96;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 7 && comboBox2.SelectedIndex == 1)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.05;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 7)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 83.02;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 7 && comboBox2.SelectedIndex == 2)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.012;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 7)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.098;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 7 && comboBox2.SelectedIndex == 3)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 10.15;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 7 && comboBox2.SelectedIndex == 4)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.0094;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 7)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 105.93;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 7)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.57;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 7 && comboBox2.SelectedIndex == 5)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 1.75;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 7 && comboBox2.SelectedIndex == 6)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 47.47;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 7)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.021;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 8)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 1.46;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 8 && comboBox2.SelectedIndex == 0)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.68;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 8)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.27;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 8 && comboBox2.SelectedIndex == 1)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 3.65;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 8)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 83.02;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 8 && comboBox2.SelectedIndex == 2)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.74;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 8)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 1.33;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 8 && comboBox2.SelectedIndex == 3)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 10.15;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 8 && comboBox2.SelectedIndex == 4)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.585;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 8)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 1.70;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 8)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.0091;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 8 && comboBox2.SelectedIndex == 5)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 108.766;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 8 && comboBox2.SelectedIndex == 6)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 2948.58;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 8)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.00033;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 7 && comboBox2.SelectedIndex == 8)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.0161;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 8 && comboBox2.SelectedIndex == 7)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 62.11;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 9)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 33.93;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 9 && comboBox2.SelectedIndex == 0)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.029;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 9)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 6.31;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 9 && comboBox2.SelectedIndex == 1)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.15;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 9)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 30.89;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 9 && comboBox2.SelectedIndex == 2)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.032;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 9)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.036;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 9 && comboBox2.SelectedIndex == 3)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 27.29;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 9 && comboBox2.SelectedIndex == 4)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.025;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 9)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 39.44;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 9)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 4.704;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 9 && comboBox2.SelectedIndex == 5)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.212;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 9 && comboBox2.SelectedIndex == 6)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 127.55;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 9)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.0078;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 7 && comboBox2.SelectedIndex == 9)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.372;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 9 && comboBox2.SelectedIndex == 7)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 2.68;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 9 && comboBox2.SelectedIndex == 8)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.043;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 8 && comboBox2.SelectedIndex == 9)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 23.11;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 10)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.93;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 10 && comboBox2.SelectedIndex == 0)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 1.07;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 10)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.17;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 10 && comboBox2.SelectedIndex == 1)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 5.75;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 10)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.85;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 10 && comboBox2.SelectedIndex == 2)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 1.17;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 10)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.0010;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 10 && comboBox2.SelectedIndex == 3)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 991.03;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 10)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 1.086;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 10 && comboBox2.SelectedIndex == 4)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.920;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 10)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.0058;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 10 && comboBox2.SelectedIndex == 5)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 170.92;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 10)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.00021;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 10 && comboBox2.SelectedIndex == 6)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 4.632;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 7 && comboBox2.SelectedIndex == 10)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.0102;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 10 && comboBox2.SelectedIndex == 7)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 97.58;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 8 && comboBox2.SelectedIndex == 10)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.636;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 10 && comboBox2.SelectedIndex == 8)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 1.571;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 9 && comboBox2.SelectedIndex == 10)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 0.027;
                textBox2.Text = Convert.ToString(num);
            }
            if (comboBox1.SelectedIndex == 10 && comboBox2.SelectedIndex == 9)
            {
                double num = Convert.ToDouble(textBox1.Text);
                num = num * 36.32;
                textBox2.Text = Convert.ToString(num);
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
               
            }
        }
    }
}

