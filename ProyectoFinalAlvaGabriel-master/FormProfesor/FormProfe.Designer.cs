namespace FormProfesor
{
    partial class FormProfe
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
            dataGridProfesores = new DataGridView();
            btnEliminar = new Button();
            btnAceptar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridProfesores).BeginInit();
            SuspendLayout();
            // 
            // dataGridProfesores
            // 
            dataGridProfesores.BackgroundColor = Color.WhiteSmoke;
            dataGridProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProfesores.Location = new Point(2, 2);
            dataGridProfesores.MultiSelect = false;
            dataGridProfesores.Name = "dataGridProfesores";
            dataGridProfesores.ReadOnly = true;
            dataGridProfesores.RowTemplate.Height = 25;
            dataGridProfesores.Size = new Size(574, 251);
            dataGridProfesores.TabIndex = 0;
            dataGridProfesores.CellClick += dataGridProfesores_CellClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.RosyBrown;
            btnEliminar.ForeColor = Color.WhiteSmoke;
            btnEliminar.Location = new Point(28, 259);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(235, 29);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.RosyBrown;
            btnAceptar.ForeColor = Color.WhiteSmoke;
            btnAceptar.Location = new Point(177, 294);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(199, 29);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.RosyBrown;
            btnSalir.ForeColor = Color.WhiteSmoke;
            btnSalir.Location = new Point(297, 259);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(235, 29);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormProfe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(579, 327);
            Controls.Add(btnSalir);
            Controls.Add(btnAceptar);
            Controls.Add(btnEliminar);
            Controls.Add(dataGridProfesores);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormProfe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario Profesores";
            Load += FormProfe_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridProfesores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridProfesores;
        private Button btnEliminar;
        private Button btnAceptar;
        private Button btnSalir;
    }
}