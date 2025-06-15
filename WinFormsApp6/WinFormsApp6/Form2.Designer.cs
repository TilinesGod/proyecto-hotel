namespace WinFormsApp6
{
    partial class Creaciondeperfil
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtIdCliente = new TextBox();
            TxtNombreCliente = new TextBox();
            TxtGmailCliente = new TextBox();
            TxtTelefonoCliente = new TextBox();
            TxtDireccionCliente = new TextBox();
            BTNguardar = new Button();
            BTNmostrar = new Button();
            BtnModificar = new Button();
            BTNeliminar = new Button();
            MostrarDatos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 44);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "ID unica";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 102);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre completo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 155);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Gmail";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 211);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(140, 272);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 4;
            label5.Text = "Direccion";
            label5.Click += label5_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(396, 37);
            txtIdCliente.Margin = new Padding(3, 4, 3, 4);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(183, 27);
            txtIdCliente.TabIndex = 5;
            // 
            // TxtNombreCliente
            // 
            TxtNombreCliente.Location = new Point(396, 99);
            TxtNombreCliente.Margin = new Padding(3, 4, 3, 4);
            TxtNombreCliente.Name = "TxtNombreCliente";
            TxtNombreCliente.Size = new Size(629, 27);
            TxtNombreCliente.TabIndex = 6;
            // 
            // TxtGmailCliente
            // 
            TxtGmailCliente.Location = new Point(396, 148);
            TxtGmailCliente.Margin = new Padding(3, 4, 3, 4);
            TxtGmailCliente.Name = "TxtGmailCliente";
            TxtGmailCliente.Size = new Size(629, 27);
            TxtGmailCliente.TabIndex = 7;
            // 
            // TxtTelefonoCliente
            // 
            TxtTelefonoCliente.Location = new Point(396, 204);
            TxtTelefonoCliente.Margin = new Padding(3, 4, 3, 4);
            TxtTelefonoCliente.Name = "TxtTelefonoCliente";
            TxtTelefonoCliente.Size = new Size(304, 27);
            TxtTelefonoCliente.TabIndex = 8;
            // 
            // TxtDireccionCliente
            // 
            TxtDireccionCliente.Location = new Point(396, 265);
            TxtDireccionCliente.Margin = new Padding(3, 4, 3, 4);
            TxtDireccionCliente.Name = "TxtDireccionCliente";
            TxtDireccionCliente.Size = new Size(629, 27);
            TxtDireccionCliente.TabIndex = 9;
            // 
            // BTNguardar
            // 
            BTNguardar.Location = new Point(1211, 44);
            BTNguardar.Margin = new Padding(3, 4, 3, 4);
            BTNguardar.Name = "BTNguardar";
            BTNguardar.Size = new Size(86, 31);
            BTNguardar.TabIndex = 10;
            BTNguardar.Text = "Guardar";
            BTNguardar.UseVisualStyleBackColor = true;
            BTNguardar.Click += BtnGuardar_Click;
            // 
            // BTNmostrar
            // 
            BTNmostrar.Location = new Point(1211, 127);
            BTNmostrar.Margin = new Padding(3, 4, 3, 4);
            BTNmostrar.Name = "BTNmostrar";
            BTNmostrar.Size = new Size(86, 31);
            BTNmostrar.TabIndex = 11;
            BTNmostrar.Text = "Mostrar";
            BTNmostrar.UseVisualStyleBackColor = true;
            BTNmostrar.Click += BtnMostrar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(1211, 290);
            BtnModificar.Margin = new Padding(3, 4, 3, 4);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(86, 31);
            BtnModificar.TabIndex = 12;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // BTNeliminar
            // 
            BTNeliminar.Location = new Point(1211, 202);
            BTNeliminar.Margin = new Padding(3, 4, 3, 4);
            BTNeliminar.Name = "BTNeliminar";
            BTNeliminar.Size = new Size(86, 31);
            BTNeliminar.TabIndex = 13;
            BTNeliminar.Text = "Eliminar";
            BTNeliminar.UseVisualStyleBackColor = true;
            // 
            // MostrarDatos
            // 
            MostrarDatos.FormattingEnabled = true;
            MostrarDatos.Location = new Point(69, 350);
            MostrarDatos.Margin = new Padding(3, 4, 3, 4);
            MostrarDatos.Name = "MostrarDatos";
            MostrarDatos.Size = new Size(1279, 244);
            MostrarDatos.TabIndex = 14;
            // 
            // Creaciondeperfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(1408, 658);
            Controls.Add(MostrarDatos);
            Controls.Add(BTNeliminar);
            Controls.Add(BtnModificar);
            Controls.Add(BTNmostrar);
            Controls.Add(BTNguardar);
            Controls.Add(TxtDireccionCliente);
            Controls.Add(TxtTelefonoCliente);
            Controls.Add(TxtGmailCliente);
            Controls.Add(TxtNombreCliente);
            Controls.Add(txtIdCliente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Creaciondeperfil";
            Text = "Creación de perfil";
            Load += ReservacionClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIdCliente;
        private TextBox TxtNombreCliente;
        private TextBox TxtGmailCliente;
        private TextBox TxtTelefonoCliente;
        private TextBox TxtDireccionCliente;
        private Button BTNguardar;
        private Button BTNmostrar;
        private Button BtnModificar;
        private Button BTNeliminar;
        private ListBox MostrarDatos;
    }
}