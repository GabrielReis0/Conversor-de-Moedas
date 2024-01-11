namespace Conversor_de_Moedas
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(166, 176);
            button1.Name = "button1";
            button1.Size = new Size(222, 50);
            button1.TabIndex = 19;
            button1.Text = "Converter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 118);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 18;
            label4.Text = "Quantidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 118);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 17;
            label3.Text = "Quantidade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 40);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 16;
            label2.Text = "Tipo de moeda:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 40);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 15;
            label1.Text = "Tipo de moeda:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.arrowright_2_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(166, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 99);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(403, 92);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Euro", "Real", "Dólar Americano", "Kwanza", "Libra", "Iene Japonês", "Peso colombiano", "Rúpia Indiana", "Dolár Canadense", "Libra egípcia", "Franco suíço" });
            comboBox2.Location = new Point(403, 58);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Euro", "Real", "Dolár Americano", "Kwanza", "Libra", "Iene Japonês", "Peso colombiano", "Rúpia Indiana", "Dolár Canadense", "Libra egípcia", "Franco suíço" });
            comboBox1.Location = new Point(28, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(120, 23);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(403, 136);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(121, 114);
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(28, 136);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(121, 114);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 262);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}