namespace WinFormsApp6
{
    partial class Form3
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
            Reportes = new ListBox();
            BtnDiario = new Button();
            BtnSemanal = new Button();
            BtnMensual = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Serif HK Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 33);
            label1.Name = "label1";
            label1.Size = new Size(92, 27);
            label1.TabIndex = 0;
            label1.Text = "Reporte";
            // 
            // Reportes
            // 
            Reportes.FormattingEnabled = true;
            Reportes.ItemHeight = 15;
            Reportes.Location = new Point(78, 123);
            Reportes.Name = "Reportes";
            Reportes.Size = new Size(626, 274);
            Reportes.TabIndex = 1;
            // 
            // BtnDiario
            // 
            BtnDiario.Location = new Point(206, 87);
            BtnDiario.Name = "BtnDiario";
            BtnDiario.Size = new Size(75, 23);
            BtnDiario.TabIndex = 2;
            BtnDiario.Text = "Diario";
            BtnDiario.UseVisualStyleBackColor = true;
            // 
            // BtnSemanal
            // 
            BtnSemanal.Location = new Point(332, 87);
            BtnSemanal.Name = "BtnSemanal";
            BtnSemanal.Size = new Size(75, 23);
            BtnSemanal.TabIndex = 3;
            BtnSemanal.Text = "Semanal";
            BtnSemanal.UseVisualStyleBackColor = true;
            // 
            // BtnMensual
            // 
            BtnMensual.Location = new Point(460, 87);
            BtnMensual.Name = "BtnMensual";
            BtnMensual.Size = new Size(75, 23);
            BtnMensual.TabIndex = 4;
            BtnMensual.Text = "Mensual";
            BtnMensual.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnMensual);
            Controls.Add(BtnSemanal);
            Controls.Add(BtnDiario);
            Controls.Add(Reportes);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox Reportes;
        private Button BtnDiario;
        private Button BtnSemanal;
        private Button BtnMensual;
    }
}