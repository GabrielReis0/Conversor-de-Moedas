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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Euro", "Real", "Dolár Americano", "Kwanza", "Libra" });
            comboBox1.Location = new Point(99, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(124, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Euro", "Real", "Dólar Americano", "Kwanza", "Libra" });
            comboBox2.Location = new Point(478, 115);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(478, 149);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.arrowright_2_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(241, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 99);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 97);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 5;
            label1.Text = "Tipo de moeda:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(496, 97);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 6;
            label2.Text = "Tipo de moeda:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 175);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 7;
            label3.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(503, 175);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 8;
            label4.Text = "Quantidade:";
            // 
            // button1
            // 
            button1.Location = new Point(241, 220);
            button1.Name = "button1";
            button1.Size = new Size(222, 50);
            button1.TabIndex = 9;
            button1.Text = "Converter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 450);
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
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}