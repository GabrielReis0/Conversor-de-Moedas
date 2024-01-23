namespace Conversor_de_Moedas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            txtNome = new TextBox();
            txtGmail = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBoxPassword = new CheckBox();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(914, 527);
            button1.Name = "button1";
            button1.Size = new Size(231, 124);
            button1.TabIndex = 0;
            button1.Text = "Resgistar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(857, 294);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(350, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(857, 377);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(350, 23);
            txtGmail.TabIndex = 2;
            txtGmail.TextChanged += txtGmail_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(857, 459);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(350, 23);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(857, 263);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(857, 349);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 5;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(857, 428);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 6;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // checkBoxPassword
            // 
            checkBoxPassword.AutoSize = true;
            checkBoxPassword.BackColor = Color.Transparent;
            checkBoxPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxPassword.Location = new Point(1087, 433);
            checkBoxPassword.Name = "checkBoxPassword";
            checkBoxPassword.Size = new Size(120, 19);
            checkBoxPassword.TabIndex = 7;
            checkBoxPassword.Text = "Mostrar Password";
            checkBoxPassword.UseVisualStyleBackColor = false;
            checkBoxPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources._360_F_355607062_zYMS8jaz4SfoykpWz5oViRVKL32IabTP;
            ClientSize = new Size(1478, 754);
            Controls.Add(checkBoxPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtGmail);
            Controls.Add(txtNome);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private TextBox txtNome;
        private TextBox txtGmail;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBoxPassword;
    }
}