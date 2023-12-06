namespace ProyectoGym
{
    partial class FormPrincipal
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
            btnProfesor = new Button();
            btnListados = new Button();
            btnAgregarCliente = new Button();
            lblGuardarCambios = new Label();
            btnGuardarArchivosLocales = new Button();
            SuspendLayout();
            // 
            // btnProfesor
            // 
            btnProfesor.BackColor = Color.RosyBrown;
            btnProfesor.Location = new Point(14, 58);
            btnProfesor.Name = "btnProfesor";
            btnProfesor.Size = new Size(171, 40);
            btnProfesor.TabIndex = 1;
            btnProfesor.Text = "Profesor";
            btnProfesor.UseVisualStyleBackColor = false;
            btnProfesor.Click += btnProfesor_Click;
            // 
            // btnListados
            // 
            btnListados.BackColor = Color.RosyBrown;
            btnListados.Location = new Point(14, 104);
            btnListados.Name = "btnListados";
            btnListados.Size = new Size(171, 40);
            btnListados.TabIndex = 2;
            btnListados.Text = "Listados";
            btnListados.UseVisualStyleBackColor = false;
            btnListados.Click += btnListados_Click;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.BackColor = Color.RosyBrown;
            btnAgregarCliente.Location = new Point(12, 12);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(171, 40);
            btnAgregarCliente.TabIndex = 4;
            btnAgregarCliente.Text = "ABM Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // lblGuardarCambios
            // 
            lblGuardarCambios.AutoSize = true;
            lblGuardarCambios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGuardarCambios.ForeColor = SystemColors.ButtonFace;
            lblGuardarCambios.Location = new Point(14, 159);
            lblGuardarCambios.Name = "lblGuardarCambios";
            lblGuardarCambios.Size = new Size(0, 21);
            lblGuardarCambios.TabIndex = 5;
            // 
            // btnGuardarArchivosLocales
            // 
            btnGuardarArchivosLocales.BackColor = Color.RosyBrown;
            btnGuardarArchivosLocales.Location = new Point(12, 215);
            btnGuardarArchivosLocales.Name = "btnGuardarArchivosLocales";
            btnGuardarArchivosLocales.Size = new Size(171, 40);
            btnGuardarArchivosLocales.TabIndex = 6;
            btnGuardarArchivosLocales.Text = "Guardar en archivos locales";
            btnGuardarArchivosLocales.UseVisualStyleBackColor = false;
            btnGuardarArchivosLocales.Click += btnGuardarArchivosLocales_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(507, 271);
            Controls.Add(btnGuardarArchivosLocales);
            Controls.Add(lblGuardarCambios);
            Controls.Add(btnAgregarCliente);
            Controls.Add(btnListados);
            Controls.Add(btnProfesor);
            ForeColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gym";
            FormClosing += FormPrincipal_FormClosing;
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnProfesor;
        private Button btnListados;
        private Button btnAgregarCliente;
        private Label lblGuardarCambios;
        private Button btnGuardarArchivosLocales;
    }
}