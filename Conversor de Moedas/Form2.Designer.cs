namespace Conversor_de_Moedas
{
    partial class Form2
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
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            btnPágConvert = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(120, 654);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1271, 23);
            progressBar1.TabIndex = 1;
            progressBar1.Click += progressBar1_Click;
            progressBar1.MouseLeave += progressBar1_MouseLeave;
            progressBar1.MouseHover += progressBar1_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(120, 626);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 2;
            label1.Text = "Carregando";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1304, 79);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 3;
            label2.Text = "Utilizador";
            label2.Click += label2_Click;
            // 
            // btnPágConvert
            // 
            btnPágConvert.Location = new Point(643, 468);
            btnPágConvert.Name = "btnPágConvert";
            btnPágConvert.Size = new Size(214, 137);
            btnPágConvert.TabIndex = 4;
            btnPágConvert.Text = "Página Converções";
            btnPágConvert.UseVisualStyleBackColor = true;
            btnPágConvert.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1295, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 50);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1475, 847);
            Controls.Add(pictureBox1);
            Controls.Add(btnPágConvert);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private Button btnPágConvert;
        private PictureBox pictureBox1;
    }
}