namespace WinFormsApp6
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
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            comboBox1 = new ComboBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 192);
            label2.Font = new Font("Palatino Linotype", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(43, 60);
            label2.Name = "label2";
            label2.Size = new Size(605, 58);
            label2.TabIndex = 2;
            label2.Text = "ARTURUS MATUS HOTEL'S";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1157, 149);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // button2
            // 
            button2.ForeColor = Color.FromArgb(0, 192, 192);
            button2.Location = new Point(82, 215);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(107, 48);
            button2.TabIndex = 7;
            button2.Text = "Reservación ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Baskerville Old Face", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.Location = new Point(1142, 692);
            button4.Name = "button4";
            button4.Size = new Size(252, 46);
            button4.TabIndex = 9;
            button4.Text = "Creación de perfil";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.ForeColor = Color.FromArgb(0, 192, 192);
            button5.Location = new Point(82, 376);
            button5.Name = "button5";
            button5.Size = new Size(107, 43);
            button5.TabIndex = 10;
            button5.Text = "Huésped";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.ForeColor = Color.FromArgb(0, 192, 192);
            button6.Location = new Point(82, 513);
            button6.Name = "button6";
            button6.Size = new Size(107, 40);
            button6.TabIndex = 11;
            button6.Text = "Employee";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.ForeColor = Color.FromArgb(0, 192, 192);
            button7.Location = new Point(82, 682);
            button7.Name = "button7";
            button7.Size = new Size(107, 41);
            button7.TabIndex = 12;
            button7.Text = "Factura";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "hotelbienestar@gmail.com" });
            comboBox1.Location = new Point(1350, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(97, 28);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "Contacto";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.R;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(274, 149);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1254, 667);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumBlue;
            ClientSize = new Size(1527, 818);
            Controls.Add(comboBox1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Name = "Form1";
            Text = "FormPrincipal";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label3;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private ComboBox comboBox1;
        private PictureBox pictureBox3;
    }
}
