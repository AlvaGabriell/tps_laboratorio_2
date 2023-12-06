namespace SubMenuAbm
{
    partial class FormSubMenuAbm
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
            label1 = new Label();
            txtBnombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBapellido = new TextBox();
            cmbDisciplina = new ComboBox();
            cmbCuotaAbonada = new ComboBox();
            cmbProfesor = new ComboBox();
            btnAceptarAbm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtBnombre
            // 
            txtBnombre.Location = new Point(122, 11);
            txtBnombre.Name = "txtBnombre";
            txtBnombre.Size = new Size(100, 23);
            txtBnombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 94);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 3;
            label3.Text = "Disciplina";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 131);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 4;
            label4.Text = "Cuota Abonada";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(12, 168);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 5;
            label5.Text = "Profesor";
            // 
            // txtBapellido
            // 
            txtBapellido.Location = new Point(122, 51);
            txtBapellido.Name = "txtBapellido";
            txtBapellido.Size = new Size(100, 23);
            txtBapellido.TabIndex = 6;
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.Items.AddRange(new object[] { "box", "crossfit" });
            cmbDisciplina.Location = new Point(122, 86);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(100, 23);
            cmbDisciplina.TabIndex = 10;
            // 
            // cmbCuotaAbonada
            // 
            cmbCuotaAbonada.FormattingEnabled = true;
            cmbCuotaAbonada.Items.AddRange(new object[] { "si", "no" });
            cmbCuotaAbonada.Location = new Point(122, 123);
            cmbCuotaAbonada.Name = "cmbCuotaAbonada";
            cmbCuotaAbonada.Size = new Size(100, 23);
            cmbCuotaAbonada.TabIndex = 11;
            // 
            // cmbProfesor
            // 
            cmbProfesor.FormattingEnabled = true;
            cmbProfesor.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbProfesor.Location = new Point(122, 160);
            cmbProfesor.Name = "cmbProfesor";
            cmbProfesor.Size = new Size(100, 23);
            cmbProfesor.TabIndex = 12;
            // 
            // btnAceptarAbm
            // 
            btnAceptarAbm.Location = new Point(36, 199);
            btnAceptarAbm.Name = "btnAceptarAbm";
            btnAceptarAbm.Size = new Size(177, 23);
            btnAceptarAbm.TabIndex = 13;
            btnAceptarAbm.Text = "Aceptar";
            btnAceptarAbm.UseVisualStyleBackColor = true;
            btnAceptarAbm.Click += btnAceptarAbm_Click;
            // 
            // FormSubMenuAbm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(245, 234);
            Controls.Add(btnAceptarAbm);
            Controls.Add(cmbProfesor);
            Controls.Add(cmbCuotaAbonada);
            Controls.Add(cmbDisciplina);
            Controls.Add(txtBapellido);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBnombre);
            Controls.Add(label1);
            Name = "FormSubMenuAbm";
            Text = "ABM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBnombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBapellido;
        private ComboBox cmbDisciplina;
        private ComboBox cmbCuotaAbonada;
        private ComboBox cmbProfesor;
        private Button btnAceptarAbm;
    }
}