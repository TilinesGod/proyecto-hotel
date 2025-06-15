namespace WinFormsApp6
{
    partial class Reservación
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            BtnAgregar = new Button();
            BtnCancelar = new Button();
            BtnMostrar = new Button();
            BtnGuardar = new Button();
            TxtNombre = new TextBox();
            TxtNumPersonas = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 0, 64);
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 53);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(213, 9);
            label1.Name = "label1";
            label1.Size = new Size(274, 37);
            label1.TabIndex = 1;
            label1.Text = "Booking/Reservación";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.Hotel_Booking;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Cursor = Cursors.IBeam;
            pictureBox3.Location = new Point(89, 41);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(353, 273);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(192, 192, 0);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 321);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(801, 128);
            dataGridView1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(504, 210);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 7;
            label5.Text = "Num. Personas";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(505, 174);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 6;
            label4.Text = "Habitacion";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(512, 138);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 5;
            label3.Text = "Fecha";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(512, 102);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 282);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 15;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(104, 263);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(94, 29);
            BtnAgregar.TabIndex = 16;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(213, 263);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(94, 29);
            BtnCancelar.TabIndex = 17;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnMostrar
            // 
            BtnMostrar.Location = new Point(322, 263);
            BtnMostrar.Name = "BtnMostrar";
            BtnMostrar.Size = new Size(94, 29);
            BtnMostrar.TabIndex = 18;
            BtnMostrar.Text = "Mostrar";
            BtnMostrar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(12, 263);
            BtnGuardar.Margin = new Padding(3, 4, 3, 4);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(86, 31);
            BtnGuardar.TabIndex = 19;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(611, 101);
            TxtNombre.Margin = new Padding(3, 4, 3, 4);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(114, 27);
            TxtNombre.TabIndex = 20;
            // 
            // TxtNumPersonas
            // 
            TxtNumPersonas.Location = new Point(611, 209);
            TxtNumPersonas.Margin = new Padding(3, 4, 3, 4);
            TxtNumPersonas.Name = "TxtNumPersonas";
            TxtNumPersonas.Size = new Size(114, 27);
            TxtNumPersonas.TabIndex = 23;
            // 
            // Reservación
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(BtnGuardar);
            Controls.Add(TxtNumPersonas);
            Controls.Add(BtnMostrar);
            Controls.Add(dataGridView1);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAgregar);
            Controls.Add(TxtNombre);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Name = "Reservación";
            Text = "wa";
            Load += Reservación_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox3;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Button BtnAgregar;
        private Button BtnCancelar;
        private Button BtnMostrar;
        private Button BtnGuardar;
        private TextBox TxtNombre;
        private TextBox TxtNumPersonas;
    }
}