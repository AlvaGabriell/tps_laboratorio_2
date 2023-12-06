namespace MenuListado
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
            dataGridListados = new DataGridView();
            btnMostrarClientesZumba = new Button();
            btnMostrarClientesMusc = new Button();
            btnMostrarDeudores = new Button();
            btnSalir = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridListados).BeginInit();
            SuspendLayout();
            // 
            // dataGridListados
            // 
            dataGridListados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridListados.Location = new Point(2, 2);
            dataGridListados.MultiSelect = false;
            dataGridListados.Name = "dataGridListados";
            dataGridListados.ReadOnly = true;
            dataGridListados.RowTemplate.Height = 25;
            dataGridListados.Size = new Size(625, 284);
            dataGridListados.TabIndex = 0;
            // 
            // btnMostrarClientesZumba
            // 
            btnMostrarClientesZumba.BackColor = Color.RosyBrown;
            btnMostrarClientesZumba.ForeColor = SystemColors.ButtonFace;
            btnMostrarClientesZumba.Location = new Point(633, 12);
            btnMostrarClientesZumba.Name = "btnMostrarClientesZumba";
            btnMostrarClientesZumba.Size = new Size(163, 41);
            btnMostrarClientesZumba.TabIndex = 1;
            btnMostrarClientesZumba.Text = "Clientes zumba";
            btnMostrarClientesZumba.UseVisualStyleBackColor = false;
            btnMostrarClientesZumba.Click += btnMostrarClientesZumba_Click;
            // 
            // btnMostrarClientesMusc
            // 
            btnMostrarClientesMusc.BackColor = Color.RosyBrown;
            btnMostrarClientesMusc.ForeColor = SystemColors.ButtonFace;
            btnMostrarClientesMusc.Location = new Point(633, 70);
            btnMostrarClientesMusc.Name = "btnMostrarClientesMusc";
            btnMostrarClientesMusc.Size = new Size(163, 41);
            btnMostrarClientesMusc.TabIndex = 2;
            btnMostrarClientesMusc.Text = "Clientes Musculacion";
            btnMostrarClientesMusc.UseVisualStyleBackColor = false;
            btnMostrarClientesMusc.Click += btnMostrarClientesMusc_Click;
            // 
            // btnMostrarDeudores
            // 
            btnMostrarDeudores.BackColor = Color.RosyBrown;
            btnMostrarDeudores.ForeColor = SystemColors.ButtonFace;
            btnMostrarDeudores.Location = new Point(633, 127);
            btnMostrarDeudores.Name = "btnMostrarDeudores";
            btnMostrarDeudores.Size = new Size(163, 41);
            btnMostrarDeudores.TabIndex = 3;
            btnMostrarDeudores.Text = "Mostrar Deudores";
            btnMostrarDeudores.UseVisualStyleBackColor = false;
            btnMostrarDeudores.Click += btnMostrarDeudores_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.RosyBrown;
            btnSalir.ForeColor = SystemColors.ButtonFace;
            btnSalir.Location = new Point(633, 236);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(163, 41);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(633, 184);
            button1.Name = "button1";
            button1.Size = new Size(163, 34);
            button1.TabIndex = 5;
            button1.Text = "Comprobar Listado Local";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormSubMenuAbm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(799, 287);
            Controls.Add(button1);
            Controls.Add(btnSalir);
            Controls.Add(btnMostrarDeudores);
            Controls.Add(btnMostrarClientesMusc);
            Controls.Add(btnMostrarClientesZumba);
            Controls.Add(dataGridListados);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormSubMenuAbm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listados";
            ((System.ComponentModel.ISupportInitialize)dataGridListados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridListados;
        private Button btnMostrarClientesZumba;
        private Button btnMostrarClientesMusc;
        private Button btnMostrarDeudores;
        private Button btnSalir;
        private Button button1;
    }
}