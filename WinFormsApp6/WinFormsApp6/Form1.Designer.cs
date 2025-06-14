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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            comboBox1 = new ComboBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 0, 192);
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1382, 76);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 192);
            label2.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(426, 41);
            label2.TabIndex = 2;
            label2.Text = "ARTURUS MATUS HOTEL'S";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(0, 0, 192);
            pictureBox2.Location = new Point(-10, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(138, 695);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1157, 149);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(954, 21);
            button1.Name = "button1";
            button1.Size = new Size(169, 29);
            button1.TabIndex = 5;
            button1.Text = "Politicas de Privacidad";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Cyan;
            label3.Location = new Point(552, 25);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 6;
            label3.Text = "+(80)  000 0000";
            // 
            // button2
            // 
            button2.ForeColor = Color.FromArgb(0, 192, 192);
            button2.Location = new Point(12, 100);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(108, 48);
            button2.TabIndex = 7;
            button2.Text = "Reservación ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ForeColor = Color.FromArgb(0, 192, 192);
            button3.Location = new Point(12, 198);
            button3.Name = "button3";
            button3.Size = new Size(108, 42);
            button3.TabIndex = 8;
            button3.Text = "Room";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(757, 22);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 9;
            button4.Text = "Servicios";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.ForeColor = Color.FromArgb(0, 192, 192);
            button5.Location = new Point(12, 285);
            button5.Name = "button5";
            button5.Size = new Size(108, 42);
            button5.TabIndex = 10;
            button5.Text = "Huésped";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.ForeColor = Color.FromArgb(0, 192, 192);
            button6.Location = new Point(12, 369);
            button6.Name = "button6";
            button6.Size = new Size(108, 40);
            button6.TabIndex = 11;
            button6.Text = "Employee";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.ForeColor = Color.FromArgb(0, 192, 192);
            button7.Location = new Point(12, 466);
            button7.Name = "button7";
            button7.Size = new Size(108, 41);
            button7.TabIndex = 12;
            button7.Text = "Factura";
            button7.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "hotelbienestar@gmail.com" });
            comboBox1.Location = new Point(1209, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(97, 28);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "Contacto";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.R;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(126, 71);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1254, 666);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 737);
            Controls.Add(comboBox1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label1;
        private Button button1;
        private Label label3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private ComboBox comboBox1;
        private PictureBox pictureBox3;
    }
}
