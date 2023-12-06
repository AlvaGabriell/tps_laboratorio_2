namespace proyectoIntegrador
{
    partial class FrmCalculadora
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
            lblResultado = new Label();
            grpSistema = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            lblPrimerOperador = new Label();
            lblOperacion = new Label();
            lblSegundoOperador = new Label();
            txtPrimerOperador = new TextBox();
            btnOperar = new Button();
            txtSegundoOperador = new TextBox();
            cmbOperacion = new ComboBox();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.Black;
            lblResultado.Location = new Point(36, 35);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(147, 37);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado: ";
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grpSistema.Location = new Point(184, 95);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(202, 62);
            grpSistema.TabIndex = 7;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en: ";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(129, 24);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(69, 23);
            rdbBinario.TabIndex = 9;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Checked = true;
            rdbDecimal.Location = new Point(6, 24);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(75, 23);
            rdbDecimal.TabIndex = 8;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(36, 189);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(132, 21);
            lblPrimerOperador.TabIndex = 3;
            lblPrimerOperador.Text = "Primer operador: ";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperacion.Location = new Point(240, 189);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(85, 21);
            lblOperacion.TabIndex = 4;
            lblOperacion.Text = "Operacion:";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(393, 189);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(143, 21);
            lblSegundoOperador.TabIndex = 5;
            lblSegundoOperador.Text = "Segundo operador:";
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Location = new Point(36, 213);
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(147, 23);
            txtPrimerOperador.TabIndex = 1;
            txtPrimerOperador.TextChanged += txtPrimerOperador_TextChanged;
            // 
            // btnOperar
            // 
            btnOperar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(36, 258);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(147, 29);
            btnOperar.TabIndex = 4;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Location = new Point(393, 213);
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(143, 23);
            txtSegundoOperador.TabIndex = 3;
            txtSegundoOperador.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // cmbOperacion
            // 
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperacion.Location = new Point(220, 213);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(135, 23);
            cmbOperacion.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(205, 258);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(170, 29);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(393, 258);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(147, 29);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(544, 292);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(cmbOperacion);
            Controls.Add(txtSegundoOperador);
            Controls.Add(btnOperar);
            Controls.Add(txtPrimerOperador);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperador);
            Controls.Add(grpSistema);
            Controls.Add(lblResultado);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de : Gabriel Alva";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FrmCalculadora_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private GroupBox grpSistema;
        private RadioButton rdbDecimal;
        private RadioButton rdbBinario;
        private Label lblPrimerOperador;
        private Label lblOperacion;
        private Label lblSegundoOperador;
        private TextBox txtPrimerOperador;
        private Button btnOperar;
        private TextBox txtSegundoOperador;
        private ComboBox cmbOperacion;
        private Button btnLimpiar;
        private Button btnCerrar;
    }
}