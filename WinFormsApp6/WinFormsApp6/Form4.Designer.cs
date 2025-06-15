namespace WinFormsApp6
{
    partial class Form4
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(245, 309);
            button1.Name = "button1";
            button1.Size = new Size(185, 29);
            button1.TabIndex = 0;
            button1.Text = "No estoy de acuerdo";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(733, 304);
            button2.Name = "button2";
            button2.Size = new Size(159, 29);
            button2.TabIndex = 1;
            button2.Text = "Estoy de acuerdo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1161, 628);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
        }
        private Button button1;
        private Button button2;

        #endregion

        // private Nueva_politica nueva_politica1;
        // private Label label2;
        // private PictureBox pictureBox4;
        //private PictureBox pictureBox3;
        // private PictureBox pictureBox2;
        // private PictureBox pictureBox1;
    }
}