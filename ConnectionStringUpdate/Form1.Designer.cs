namespace ConnectionStringUpdate
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
            radioDev = new RadioButton();
            radioProd = new RadioButton();
            radioTest = new RadioButton();
            btnConvert = new Button();
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // radioDev
            // 
            radioDev.AutoSize = true;
            radioDev.Location = new Point(3, 25);
            radioDev.Name = "radioDev";
            radioDev.Size = new Size(96, 19);
            radioDev.TabIndex = 2;
            radioDev.TabStop = true;
            radioDev.Text = "Development";
            radioDev.UseVisualStyleBackColor = true;
            // 
            // radioProd
            // 
            radioProd.AutoSize = true;
            radioProd.Location = new Point(126, 25);
            radioProd.Name = "radioProd";
            radioProd.Size = new Size(84, 19);
            radioProd.TabIndex = 3;
            radioProd.TabStop = true;
            radioProd.Text = "Production";
            radioProd.UseVisualStyleBackColor = true;
            // 
            // radioTest
            // 
            radioTest.AutoSize = true;
            radioTest.Location = new Point(232, 25);
            radioTest.Name = "radioTest";
            radioTest.Size = new Size(45, 19);
            radioTest.TabIndex = 4;
            radioTest.TabStop = true;
            radioTest.Text = "Test";
            radioTest.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(305, 28);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(271, 38);
            btnConvert.TabIndex = 5;
            btnConvert.Text = "Çevir";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioTest);
            panel1.Controls.Add(radioDev);
            panel1.Controls.Add(radioProd);
            panel1.Location = new Point(7, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 61);
            panel1.TabIndex = 6;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 44);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(569, 232);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(3, 319);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(569, 240);
            richTextBox2.TabIndex = 8;
            richTextBox2.Text = "";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(richTextBox1);
            panel2.Controls.Add(richTextBox2);
            panel2.Location = new Point(4, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 619);
            panel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 291);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 10;
            label2.Text = "Yeni Dosya İçeriği";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 13);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 9;
            label1.Text = "Değiştirilen Dosya İçeriği";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 701);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnConvert);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtFileName;
        private Button btnFileSelect;
        private RadioButton radioDev;
        private RadioButton radioProd;
        private RadioButton radioTest;
        private Button btnConvert;
        private Panel panel1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Panel panel2;
        private Label label1;
        private Label label2;
    }
}