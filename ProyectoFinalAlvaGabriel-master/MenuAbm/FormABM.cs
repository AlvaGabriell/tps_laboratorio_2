using Entidades;
using Entidades.Excepciones;
using Entidades.Extension;
using Entidades.GestorAdo;
using Entidades.Modelos;

namespace MenuAbm
{
    public partial class FormABM : Form
    {
        Edisciplinas disciplina;
        DialogResult resultado;
        ModeloCliente clienteSeleccionado;
        List<ModeloCliente> listaClientes;
        private bool obtuvoUnCambio;
        public bool ObtuvoUnCambio
        {
            get { return this.obtuvoUnCambio; }
            set { this.obtuvoUnCambio = value; }
        }

        public FormABM()
        {
            InitializeComponent();
        }
        /// <summary>
        /// La idea es que no pueda agregar datos si no esta conectado a la base de datos para transmitir la informacion.
        /// Se llama ActualizarDataGridView() y se modifican los dialogresult para comprobar que este conectada.
        /// Una vez pasa la validacion se pasa el tipo de dato a modelocliente para ver las listas llamadas desde ADO
        /// Se comprueba que no este en la lista con la misma disciplina cargada, puede estar anotado en mas de una clase.
        /// Si pasa las validaciones se agrega la persona y se modifica el atributo obtuvouncambio para luego utilizarlo en 
        /// el form principal y que pueda guardar los cambios.
        /// se utiliza un metodo de extension para contar la cantidad de veces que se encuentra en la lista y 
        /// si pasa por prinera vez se le otorga la presencia par el ingreso.
        /// Se lanza excepcion si no completo los datos en los cmb y txtbox o algo sucedio al actualizar datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="FaltaIngresarDatosException"></exception>
        private void btnAgregarCliiente_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.resultado == DialogResult.Retry)
                {
                    throw new SinConexionBaseDeDatosException("No hay una conexion a la base de datos para cargar datos.");
                }
                else
                {
                    if (Cliente.ValidarString(this.txtBnombre.Text) && Cliente.ValidarString(this.txtBapellido.Text) && this.cmbDisciplina.SelectedItem != null && this.cmbCuotaAbonada.SelectedItem != null &&
                        this.cmbProfesor.SelectedItem != null)
                    {
                        resultado = MessageBox.Show("¿Está seguro de agregar el cliente?", "Confirmación", MessageBoxButtons.OKCancel);
                        if (resultado == DialogResult.OK)
                        {
                            Cliente nuevoCliente = new Cliente();
                            ModeloCliente auxModelo = new ModeloCliente();
                            nuevoCliente.Nombre = this.txtBnombre.Text;
                            nuevoCliente.Apellido = this.txtBapellido.Text;
                            if (Enum.TryParse(this.cmbDisciplina.Text, out this.disciplina))
                            {
                                nuevoCliente.Disciplinas = this.disciplina;
                            }
                            nuevoCliente.CuotaAbonada = this.cmbCuotaAbonada.Text;
                            nuevoCliente.IdProfesor = int.Parse(this.cmbProfesor.Text);
                            auxModelo = Cliente.PasarAinstanciaModeloCliente(nuevoCliente);
                            if (GestorSqlCliente.comprobarExistente(auxModelo))
                            {
                                MessageBox.Show("La persona ya está ingresada con la misma disciplina");
                            }
                            else
                            {
                                GestorSqlCliente.AgregarNuevoCliente(auxModelo);
                                this.obtuvoUnCambio = true;
                                this.ActualizarDataGridView();
                                if (this.listaClientes.ContarClienteIngresado(auxModelo.Nombre, auxModelo.Apellido) == 1)
                                {
                                    MessageBox.Show("Primer ingreso, no olvide dar la presencia para el ingreso al predio");
                                }
                            }
                        }
                    }
                    else
                    {
                        throw new FaltaIngresarDatosException("Completar los campos requeridos para hacer el alta.");
                    }
                }
            }
            catch (SinConexionBaseDeDatosException ex)
            {
                MessageBox.Show(ex.Message, "Error.-", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Se oculta el boton para "aceptar eliminar" si este estuviera invocado y que solo quede el boton correspondiente para el evento click 
        /// del boton que alla sido apretado.
        /// valida que no sea null el cliente invocado desde el evento cellclick.
        /// muestro los datos obtenidos desde el datagridview y los mando al textbox y cmb correspondientes , muestro el boton aceptar cambios para 
        /// una confirmacion de los mismos y ahi resuelvo la modificacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            this.btnEliminarOculto.Hide();
            if (this.clienteSeleccionado is not null)
            {
                this.txtBnombre.Text = this.clienteSeleccionado.Nombre;
                this.txtBapellido.Text = this.clienteSeleccionado.Apellido;
                this.cmbDisciplina.Text = this.clienteSeleccionado.Disciplinas.ToString();
                this.cmbCuotaAbonada.Text = this.clienteSeleccionado.CuotaAbonada;
                this.cmbProfesor.Text = this.clienteSeleccionado.IdProfesor.ToString();
                this.btnAceptarCambios.Show();
            }
            else
            {
                MessageBox.Show("Seleccionar item de la lista para modificar.");
            }
        }
        /// <summary>
        /// Valida que los datos ingresados sean correctos , manda msj para comprobar la modificacion
        /// convierte el dato obtenido en el texto al tipo enum disciplinas
        /// llama al metodo en ado , actualizarCliente , y paso por parametros el objeto y su atributo id.
        /// actualizo los datos de la lista para que sean visibles en el momento, 
        /// obtuvo un cambio pasa a ser true de nuevo contemplando tambien las modificaciones para luego guardarse como los alta.
        ///se limpia la seleccion del datagridview y se oculta el boton aceptar cambios para que no vuelva a apretarlo con los mismos datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptarCambios_Click(object sender, EventArgs e)
        {
            if (Cliente.ValidarString(this.txtBnombre.Text) && Cliente.ValidarString(this.txtBapellido.Text) && this.cmbDisciplina.SelectedItem != null && this.cmbCuotaAbonada.SelectedItem != null &&
                    this.cmbProfesor.SelectedItem != null)
            {
                this.resultado = MessageBox.Show("¿Está seguro de modificar el cliente?", "Confirmación", MessageBoxButtons.OKCancel);
                if (this.resultado == DialogResult.OK)
                {
                    this.clienteSeleccionado.Nombre = this.txtBnombre.Text;
                    this.clienteSeleccionado.Apellido = this.txtBapellido.Text;
                    if (Enum.TryParse(this.cmbDisciplina.Text, out this.disciplina))
                    {
                        this.clienteSeleccionado.Disciplinas = this.disciplina;
                    }
                    this.clienteSeleccionado.CuotaAbonada = this.cmbCuotaAbonada.Text;
                    this.clienteSeleccionado.IdProfesor = int.Parse(this.cmbProfesor.Text);
                    GestorSqlCliente.ActualizarClientePorId(this.clienteSeleccionado, this.clienteSeleccionado.IdCliente);
                    this.ActualizarDataGridView();
                    this.obtuvoUnCambio = true;
                    this.dataGridCliente.ClearSelection();
                    this.btnAceptarCambios.Hide();
                }
            }
            else 
            {
                MessageBox.Show("faltan ingresar datos.");
            }
        }

        /// <summary>
        ///se utiliza el evento para que haga click donde se le cante pero que le tome el objeto entero que quiere modificar 
        ///asi no esta apretando siempre en el id
        ///el condicional valida si el indice donde hizo click (e.rowindex) esta dentro del rango valido de las filas.
        /// Si el índice de fila es válido, se obtiene la fila correspondiente al índice
        /// almacena en row la fila que selecciono en el indice.
        /// la propiedad databoundItem devuelve el objeto enlazado a la fila seleccionada.
        /// se espera que el tipo de dato obtenido sea de tipo ModeloCliente y se hace la conversion explicita.
        /// si el objeto recibido no es de tipo modeloCliente rompe en ejecucion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridCliente.Rows.Count)
            {
                DataGridViewRow row = dataGridCliente.Rows[e.RowIndex];
                this.clienteSeleccionado = (ModeloCliente)row.DataBoundItem;
            }
        }


        /// <summary>
        /// IMisma implementacion que modificar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            this.btnAceptarCambios.Hide();
            if (this.clienteSeleccionado is not null)
            {
                this.txtBnombre.Text = this.clienteSeleccionado.Nombre;
                this.txtBapellido.Text = this.clienteSeleccionado.Apellido;
                this.cmbDisciplina.Text = this.clienteSeleccionado.Disciplinas.ToString();
                this.cmbCuotaAbonada.Text = this.clienteSeleccionado.CuotaAbonada;
                this.cmbProfesor.Text = this.clienteSeleccionado.IdProfesor.ToString();
                this.btnEliminarOculto.Show();
            }
            else
            {
                MessageBox.Show("Seleccionar item de la lista para eliminar.");
            }
        }

        /// <summary>
        /// misma implementacion que aceptar cambios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarOculto_Click(object sender, EventArgs e)
        {
            resultado = MessageBox.Show("¿Está seguro de eliminar el cliente?", "Confirmación", MessageBoxButtons.OKCancel);
            if (resultado == DialogResult.OK)
            {
                GestorSqlCliente.BorrarUnClientePorId(this.clienteSeleccionado.IdCliente);
                this.btnEliminarOculto.Hide();
                MessageBox.Show("Eliminacion exitosa.");
                this.obtuvoUnCambio = true;
                this.ActualizarDataGridView();
                this.dataGridCliente.ClearSelection();
                this.btnEliminarOculto.Hide();
            }
        }
        /// <summary>
        /// cierro el formulario para acceder al principal nuevamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// escondo por default los botones aceptar y eliminar cambios, actualizo el datagrid para ver los datos ante una posible modificacion
        /// o eliminacion y tambien forzar una posible excepcion
        /// si es que esta se da y no pueda agregar datos, modificar y eliminar ya que los metodos se basan en la recepcion de informacion mediante la BD
        /// limpio la seleccion del datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormABM_Load(object sender, EventArgs e)
        {
            this.btnAceptarCambios.Hide();
            this.btnEliminarOculto.Hide();
            this.ActualizarDataGridView();
            this.dataGridCliente.ClearSelection();
        }

        /// <summary>
        /// llamo a mi gestorADO para obtener todas las personas y mostrarlas en el datagrid.
        /// asocio el datagrid con la lista de clientes obtenida por el gestor y de no ser posible lanzo excepcion.
        /// </summary>
        private void ActualizarDataGridView()
        {
            try
            {
                this.listaClientes = GestorSqlCliente.ObtenerTodasLasPersonas();
                this.dataGridCliente.DataSource = this.listaClientes;
            }
            catch (SinConexionBaseDeDatosException ex)
            {
                MessageBox.Show(ex.Message, "Error ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.resultado = DialogResult.Retry;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.resultado = DialogResult.Retry;
            }
        }
    }
}