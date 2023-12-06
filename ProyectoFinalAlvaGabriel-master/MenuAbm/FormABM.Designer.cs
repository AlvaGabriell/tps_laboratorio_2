namespace MenuAbm
{
    partial class FormABM
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
            btnAgregarCliiente = new Button();
            btnModificarCliente = new Button();
            btnEliminarCliente = new Button();
            btnSalirCliente = new Button();
            lblNombre = new Label();
            txtBnombre = new TextBox();
            cmbDisciplina = new ComboBox();
            lblApellido = new Label();
            txtBapellido = new TextBox();
            lblDisciplina = new Label();
            cmbCuotaAbonada = new ComboBox();
            cmbProfesor = new ComboBox();
            lblCuotaAbonada = new Label();
            lblProfesorId = new Label();
            btnAceptarCambios = new Button();
            btnEliminarOculto = new Button();
            dataGridCliente = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridCliente).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarCliiente
            // 
            btnAgregarCliiente.BackColor = Color.RosyBrown;
            btnAgregarCliiente.ForeColor = Color.WhiteSmoke;
            btnAgregarCliiente.Location = new Point(357, 352);
            btnAgregarCliiente.Name = "btnAgregarCliiente";
            btnAgregarCliiente.Size = new Size(240, 35);
            btnAgregarCliiente.TabIndex = 0;
            btnAgregarCliiente.Text = "Agregar Cliente";
            btnAgregarCliiente.UseVisualStyleBackColor = false;
            btnAgregarCliiente.Click += btnAgregarCliiente_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.BackColor = Color.RosyBrown;
            btnModificarCliente.ForeColor = SystemColors.ButtonFace;
            btnModificarCliente.Location = new Point(46, 393);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(240, 35);
            btnModificarCliente.TabIndex = 1;
            btnModificarCliente.Text = "Modificar Cliente";
            btnModificarCliente.UseVisualStyleBackColor = false;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.BackColor = Color.RosyBrown;
            btnEliminarCliente.ForeColor = Color.WhiteSmoke;
            btnEliminarCliente.Location = new Point(357, 393);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(240, 35);
            btnEliminarCliente.TabIndex = 2;
            btnEliminarCliente.Text = "Eliminar Cliente";
            btnEliminarCliente.UseVisualStyleBackColor = false;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnSalirCliente
            // 
            btnSalirCliente.BackColor = Color.RosyBrown;
            btnSalirCliente.ForeColor = SystemColors.ButtonFace;
            btnSalirCliente.Location = new Point(46, 352);
            btnSalirCliente.Name = "btnSalirCliente";
            btnSalirCliente.Size = new Size(240, 35);
            btnSalirCliente.TabIndex = 4;
            btnSalirCliente.Text = "Salir";
            btnSalirCliente.UseVisualStyleBackColor = false;
            btnSalirCliente.Click += btnSalirCliente_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = SystemColors.ButtonFace;
            lblNombre.Location = new Point(647, 79);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // txtBnombre
            // 
            txtBnombre.Location = new Point(746, 71);
            txtBnombre.Name = "txtBnombre";
            txtBnombre.Size = new Size(136, 23);
            txtBnombre.TabIndex = 7;
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.Items.AddRange(new object[] { "box", "crossfit", "musculacion", "zumba" });
            cmbDisciplina.Location = new Point(746, 154);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(136, 23);
            cmbDisciplina.TabIndex = 8;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.ForeColor = SystemColors.ButtonFace;
            lblApellido.Location = new Point(647, 121);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 9;
            lblApellido.Text = "Apellido";
            // 
            // txtBapellido
            // 
            txtBapellido.Location = new Point(746, 113);
            txtBapellido.Name = "txtBapellido";
            txtBapellido.Size = new Size(136, 23);
            txtBapellido.TabIndex = 10;
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.ForeColor = SystemColors.ButtonFace;
            lblDisciplina.Location = new Point(647, 162);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(58, 15);
            lblDisciplina.TabIndex = 11;
            lblDisciplina.Text = "Disciplina";
            // 
            // cmbCuotaAbonada
            // 
            cmbCuotaAbonada.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCuotaAbonada.FormattingEnabled = true;
            cmbCuotaAbonada.Items.AddRange(new object[] { "si", "no" });
            cmbCuotaAbonada.Location = new Point(746, 195);
            cmbCuotaAbonada.Name = "cmbCuotaAbonada";
            cmbCuotaAbonada.Size = new Size(136, 23);
            cmbCuotaAbonada.TabIndex = 12;
            // 
            // cmbProfesor
            // 
            cmbProfesor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProfesor.FormattingEnabled = true;
            cmbProfesor.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbProfesor.Location = new Point(746, 236);
            cmbProfesor.Name = "cmbProfesor";
            cmbProfesor.Size = new Size(136, 23);
            cmbProfesor.TabIndex = 13;
            // 
            // lblCuotaAbonada
            // 
            lblCuotaAbonada.AutoSize = true;
            lblCuotaAbonada.ForeColor = SystemColors.ButtonFace;
            lblCuotaAbonada.Location = new Point(647, 203);
            lblCuotaAbonada.Name = "lblCuotaAbonada";
            lblCuotaAbonada.Size = new Size(90, 15);
            lblCuotaAbonada.TabIndex = 14;
            lblCuotaAbonada.Text = "Cuota Abonada";
            // 
            // lblProfesorId
            // 
            lblProfesorId.AutoSize = true;
            lblProfesorId.ForeColor = SystemColors.ButtonFace;
            lblProfesorId.Location = new Point(647, 244);
            lblProfesorId.Name = "lblProfesorId";
            lblProfesorId.Size = new Size(75, 15);
            lblProfesorId.TabIndex = 15;
            lblProfesorId.Text = "Profesores id";
            // 
            // btnAceptarCambios
            // 
            btnAceptarCambios.BackColor = Color.RosyBrown;
            btnAceptarCambios.ForeColor = SystemColors.ButtonFace;
            btnAceptarCambios.Location = new Point(690, 284);
            btnAceptarCambios.Name = "btnAceptarCambios";
            btnAceptarCambios.Size = new Size(163, 23);
            btnAceptarCambios.TabIndex = 16;
            btnAceptarCambios.Text = "Modificar Cambios";
            btnAceptarCambios.UseVisualStyleBackColor = false;
            btnAceptarCambios.Click += btnAceptarCambios_Click;
            // 
            // btnEliminarOculto
            // 
            btnEliminarOculto.BackColor = Color.RosyBrown;
            btnEliminarOculto.ForeColor = SystemColors.ButtonFace;
            btnEliminarOculto.Location = new Point(690, 323);
            btnEliminarOculto.Name = "btnEliminarOculto";
            btnEliminarOculto.Size = new Size(163, 23);
            btnEliminarOculto.TabIndex = 17;
            btnEliminarOculto.Text = "Eliminar Cliente";
            btnEliminarOculto.UseVisualStyleBackColor = false;
            btnEliminarOculto.Click += btnEliminarOculto_Click;
            // 
            // dataGridCliente
            // 
            dataGridCliente.AllowUserToAddRows = false;
            dataGridCliente.AllowUserToDeleteRows = false;
            dataGridCliente.BackgroundColor = Color.WhiteSmoke;
            dataGridCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCliente.Location = new Point(2, 2);
            dataGridCliente.MultiSelect = false;
            dataGridCliente.Name = "dataGridCliente";
            dataGridCliente.ReadOnly = true;
            dataGridCliente.RowTemplate.Height = 25;
            dataGridCliente.Size = new Size(639, 344);
            dataGridCliente.TabIndex = 18;
            dataGridCliente.CellClick += dataGridCliente_CellClick;
            // 
            // FormABM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(888, 436);
            Controls.Add(dataGridCliente);
            Controls.Add(btnEliminarOculto);
            Controls.Add(btnAceptarCambios);
            Controls.Add(lblProfesorId);
            Controls.Add(lblCuotaAbonada);
            Controls.Add(cmbProfesor);
            Controls.Add(cmbCuotaAbonada);
            Controls.Add(lblDisciplina);
            Controls.Add(txtBapellido);
            Controls.Add(lblApellido);
            Controls.Add(cmbDisciplina);
            Controls.Add(txtBnombre);
            Controls.Add(lblNombre);
            Controls.Add(btnSalirCliente);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnModificarCliente);
            Controls.Add(btnAgregarCliiente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormABM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Submenu ABM";
            Load += FormABM_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarCliiente;
        private Button btnModificarCliente;
        private Button btnEliminarCliente;
        private Button btnSalirCliente;
        private Label lblNombre;
        private TextBox txtBnombre;
        private ComboBox cmbDisciplina;
        private Label lblApellido;
        private TextBox txtBapellido;
        private Label lblDisciplina;
        private ComboBox cmbCuotaAbonada;
        private ComboBox cmbProfesor;
        private Label lblCuotaAbonada;
        private Label lblProfesorId;
        private Button btnAceptarCambios;
        private Button btnEliminarOculto;
        private DataGridView dataGridCliente;
    }
}