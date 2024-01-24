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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            progressBar1 = new ProgressBar();
            label2 = new Label();
            btnPágConvert = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(23, 466);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(609, 23);
            progressBar1.TabIndex = 1;
            progressBar1.Click += progressBar1_Click;
            progressBar1.MouseEnter += progressBar1_MouseHover;
            progressBar1.MouseLeave += progressBar1_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1771, 126);
            label2.Name = "label2";
            label2.Size = new Size(105, 30);
            label2.TabIndex = 3;
            label2.Text = "Utilizador";
            label2.Click += label2_Click;
            // 
            // btnPágConvert
            // 
            btnPágConvert.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnPágConvert.Location = new Point(241, 207);
            btnPágConvert.Name = "btnPágConvert";
            btnPágConvert.Size = new Size(175, 106);
            btnPágConvert.TabIndex = 4;
            btnPágConvert.Text = " Converções";
            btnPágConvert.UseVisualStyleBackColor = true;
            btnPágConvert.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 407);
            label3.Name = "label3";
            label3.Size = new Size(255, 28);
            label3.TabIndex = 6;
            label3.Text = "Deslizar o ponteiro na barra";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(1771, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 85);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(117, 104);
            label4.Name = "label4";
            label4.Size = new Size(0, 45);
            label4.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(654, 519);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnPágConvert);
            Controls.Add(label2);
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
        private Label label2;
        private Button btnPágConvert;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
    }
}