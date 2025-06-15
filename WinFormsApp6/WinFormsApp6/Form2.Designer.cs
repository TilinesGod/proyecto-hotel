namespace WinFormsApp6
{
    partial class ReservacionClientes
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
            BtnGuardar = new Button();
            BtnMostrar = new Button();
            BtnModificar = new Button();
            BtnCancelar = new Button();
            MostrarDatos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 33);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "ID unica";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 74);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 119);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Gmail";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 164);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 210);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Direccion";
            label5.Click += label5_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(200, 33);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(100, 23);
            txtIdCliente.TabIndex = 5;
            // 
            // TxtNombreCliente
            // 
            TxtNombreCliente.Location = new Point(200, 74);
            TxtNombreCliente.Name = "TxtNombreCliente";
            TxtNombreCliente.Size = new Size(100, 23);
            TxtNombreCliente.TabIndex = 6;
            // 
            // TxtGmailCliente
            // 
            TxtGmailCliente.Location = new Point(200, 116);
            TxtGmailCliente.Name = "TxtGmailCliente";
            TxtGmailCliente.Size = new Size(100, 23);
            TxtGmailCliente.TabIndex = 7;
            // 
            // TxtTelefonoCliente
            // 
            TxtTelefonoCliente.Location = new Point(200, 156);
            TxtTelefonoCliente.Name = "TxtTelefonoCliente";
            TxtTelefonoCliente.Size = new Size(100, 23);
            TxtTelefonoCliente.TabIndex = 8;
            // 
            // TxtDireccionCliente
            // 
            TxtDireccionCliente.Location = new Point(200, 202);
            TxtDireccionCliente.Name = "TxtDireccionCliente";
            TxtDireccionCliente.Size = new Size(100, 23);
            TxtDireccionCliente.TabIndex = 9;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(59, 244);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(75, 23);
            BtnGuardar.TabIndex = 10;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnMostrar
            // 
            BtnMostrar.Location = new Point(140, 244);
            BtnMostrar.Name = "BtnMostrar";
            BtnMostrar.Size = new Size(75, 23);
            BtnMostrar.TabIndex = 11;
            BtnMostrar.Text = "Mostrar";
            BtnMostrar.UseVisualStyleBackColor = true;
            BtnMostrar.Click += BtnMostrar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(140, 282);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(75, 23);
            BtnModificar.TabIndex = 12;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(59, 282);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 13;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // MostrarDatos
            // 
            MostrarDatos.FormattingEnabled = true;
            MostrarDatos.ItemHeight = 15;
            MostrarDatos.Location = new Point(353, 33);
            MostrarDatos.Name = "MostrarDatos";
            MostrarDatos.Size = new Size(435, 349);
            MostrarDatos.TabIndex = 14;
            // 
            // ReservacionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MostrarDatos);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnModificar);
            Controls.Add(BtnMostrar);
            Controls.Add(BtnGuardar);
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
            Name = "ReservacionClientes";
            Text = "Reservacion de clientes";
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
        private Button BtnGuardar;
        private Button BtnMostrar;
        private Button BtnModificar;
        private Button BtnCancelar;
        private ListBox MostrarDatos;
    }
}