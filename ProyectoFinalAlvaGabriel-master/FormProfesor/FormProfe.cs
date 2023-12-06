using Entidades.Excepciones;
using Entidades.Modelos;
using Entidades.GestorAdo;

namespace FormProfesor
{
    public partial class FormProfe : Form
    {
        List<ModeloProfesor> listaProfesores;
        DialogResult resultado;
        ModeloProfesor profeSeleccionado;
        private bool obtuvoUnCambio;
       
        public bool ObtuvoUnCambio
        {
            get { return this.obtuvoUnCambio; }
            set { this.obtuvoUnCambio = value; }
        }

        public FormProfe()
        {
            InitializeComponent();
        }

        private void FormProfe_Load(object sender, EventArgs e)
        {

            this.ActualizarDataGridView();
            this.dataGridProfesores.ClearSelection();
            this.btnAceptar.Hide();
        }
        private void ActualizarDataGridView()
        {
            try
            {
                this.listaProfesores = GestorSqlProfesor.ObtenerTodasLasPersonas();
                this.dataGridProfesores.DataSource = this.listaProfesores;
            }
            catch (SinConexionBaseDeDatosException ex)
            {
                MessageBox.Show(ex.Message, "Error al conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.profeSeleccionado is not null)
            {
                this.btnAceptar.Show();
            }
            else
            {
                MessageBox.Show("Selecciona item de la lista para eliminar");
            }
        }
        /// <summary>
        /// valido que el id del profesor no este asociado a ningun cliente a modo de relacionar la base de datos.
        /// si este no contiene ningun cliente, es eliminado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!GestorSqlCliente.buscarClientePorIdProfesor(this.profeSeleccionado.ID_Profesor))
            {
                this.resultado = MessageBox.Show("¿Está seguro de eliminar el cliente?", "Confirmación", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    GestorSqlProfesor.BorrarUnProfePorId(this.profeSeleccionado.ID_Profesor);
                    MessageBox.Show("Profesor eliminado");
                    this.obtuvoUnCambio = true;
                    this.btnAceptar.Hide();
                    this.dataGridProfesores.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Debes reasignar el cliente a otro profesor para eliminar este del sistema");
                this.btnAceptar.Hide();
                this.dataGridProfesores.ClearSelection();
            }
        }
        private void dataGridProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridProfesores.Rows.Count)
            {
                DataGridViewRow row = dataGridProfesores.Rows[e.RowIndex];
                this.profeSeleccionado = (ModeloProfesor)row.DataBoundItem;
            }
        }
    }
}
