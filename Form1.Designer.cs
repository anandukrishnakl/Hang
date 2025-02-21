namespace Hang
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 221);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 1;
            label1.Text = "6 Chances ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 305);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 2;
            label2.Text = "word :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 315);
            label3.Name = "label3";
            label3.Size = new Size(19, 25);
            label3.TabIndex = 3;
            label3.Text = "_";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 315);
            label4.Name = "label4";
            label4.Size = new Size(19, 25);
            label4.TabIndex = 4;
            label4.Text = "_";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(279, 315);
            label5.Name = "label5";
            label5.Size = new Size(19, 25);
            label5.TabIndex = 5;
            label5.Text = "_";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(305, 315);
            label6.Name = "label6";
            label6.Size = new Size(19, 25);
            label6.TabIndex = 6;
            label6.Text = "_";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(331, 315);
            label7.Name = "label7";
            label7.Size = new Size(19, 25);
            label7.TabIndex = 7;
            label7.Text = "_";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(357, 315);
            label8.Name = "label8";
            label8.Size = new Size(19, 25);
            label8.TabIndex = 8;
            label8.Text = "_";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(382, 315);
            label9.Name = "label9";
            label9.Size = new Size(19, 25);
            label9.TabIndex = 9;
            label9.Text = "_";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(149, 255);
            label10.Name = "label10";
            label10.Size = new Size(0, 25);
            label10.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(252, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 152);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 375);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}
