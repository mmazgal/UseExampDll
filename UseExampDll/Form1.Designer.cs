namespace UseExampDll
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
            buttonKareHesapla = new Button();
            buttonKupHesapla = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // buttonKareHesapla
            // 
            buttonKareHesapla.Location = new Point(82, 113);
            buttonKareHesapla.Name = "buttonKareHesapla";
            buttonKareHesapla.Size = new Size(175, 29);
            buttonKareHesapla.TabIndex = 0;
            buttonKareHesapla.Text = "Kare Hesapla";
            buttonKareHesapla.UseVisualStyleBackColor = true;
            buttonKareHesapla.Click += buttonKareHesapla_Click;
            // 
            // buttonKupHesapla
            // 
            buttonKupHesapla.Location = new Point(319, 113);
            buttonKupHesapla.Name = "buttonKupHesapla";
            buttonKupHesapla.Size = new Size(175, 29);
            buttonKupHesapla.TabIndex = 1;
            buttonKupHesapla.Text = "Küp Hesapla";
            buttonKupHesapla.UseVisualStyleBackColor = true;
            buttonKupHesapla.Click += buttonKupHesapla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 315);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 2;
            label1.Text = "Sonuç :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(288, 308);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(218, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 412);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(buttonKupHesapla);
            Controls.Add(buttonKareHesapla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonKareHesapla;
        private Button buttonKupHesapla;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
