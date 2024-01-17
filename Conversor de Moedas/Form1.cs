namespace Conversor_de_Moedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtGmail.Text;
            string password = txtPassword.Text;

            if (nome == "" && email == "" && password == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nome == "" && email == "")
            {
                MessageBox.Show("Por favor, preencha o Nome e Email.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (nome == "" && password == "")
            {
                MessageBox.Show("Por favor, preencha o Nome e Password.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (email == "" && password == "")
            {
                MessageBox.Show("Por favor, preencha o Email e Password.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (nome == "")
            {
                MessageBox.Show("Por favor, preencha o Nome.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (email == "")
            {
                MessageBox.Show("Por favor, preencha o Email.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (password == "")
            {
                MessageBox.Show("Por favor, preencha a Password.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Utilizador.Registar(nome, email, password);

                MessageBox.Show("Utilizador Registado!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNome.Clear();
                txtGmail.Clear();
                txtPassword.Clear();


                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                this.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }
    }
}