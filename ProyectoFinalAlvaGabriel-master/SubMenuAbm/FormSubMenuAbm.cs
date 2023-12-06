
using Entidades;
namespace SubMenuAbm
{
    public partial class FormSubMenuAbm : Form
    {
        Cliente nuevoCliente;
        public FormSubMenuAbm()
        {
            InitializeComponent();
        }

        public bool validarString(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                return false;
            }
            return true;
        }

        private void btnAceptarAbm_Click(object sender, EventArgs e)
        {
            if (validarString(this.txtBnombre.Text) && validarString(this.txtBapellido.Text) && this.cmbDisciplina.Text != null && this.cmbCuotaAbonada.Text != null && this.cmbProfesor.Text != null)
            {
                this.nuevoCliente = new Cliente();
                this.nuevoCliente.Nombre = this.txtBnombre.Text;
                this.nuevoCliente.Apellido = this.txtBapellido.Text;
                this.nuevoCliente.Disciplinas = this.cmbDisciplina.Text;
                this.nuevoCliente.CuotaAbonada = this.cmbCuotaAbonada.Text;
                this.nuevoCliente.IdProfesor = this.cmbProfesor.SelectedIndex;
                ModeloCliente aux = new ModeloCliente();
                aux = Cliente.PasarAinstanciaModeloCliente(this.nuevoCliente);
                GestorSql.AgregarNuevoCliente(aux);
            }
        }
    }
}