using Entidades.Excepciones;
using Entidades.GestorAdo;
using Entidades.Modelos;
using Entidades;

namespace MenuListado
{
    public partial class FormSubMenuAbm : Form
    {
        List<ModeloCliente> listaModeloClientes;
        public FormSubMenuAbm()
        {
            InitializeComponent();
        }

        private void btnMostrarClientesZumba_Click(object sender, EventArgs e)
        {
            this.listaModeloClientes = GestorSqlCliente.buscarClienteClase("zumba");
            this.ActualizarDataGridView();
        }

        private void ActualizarDataGridView()
        {
            this.dataGridListados.DataSource = this.listaModeloClientes;
        }

        private void btnMostrarClientesMusc_Click(object sender, EventArgs e)
        {
            this.listaModeloClientes = GestorSqlCliente.buscarClienteClase("musculacion");
            this.ActualizarDataGridView();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrarDeudores_Click(object sender, EventArgs e)
        {
            try
            {
                this.listaModeloClientes = GestorSqlCliente.buscarClienteDeudor();
                this.ActualizarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente aux = new Cliente();
            try
            {
                string direccion = Path.Combine(Directory.GetCurrentDirectory(), "asd.json");
                this.listaModeloClientes = aux.ExportarDatos(this.listaModeloClientes, direccion);
                this.dataGridListados.DataSource = this.listaModeloClientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se encontro el archivo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}