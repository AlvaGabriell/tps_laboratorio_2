using MenuListado;
using MenuAbm;
using Entidades;
using FormProfesor;
using Entidades.GestorAdo;

namespace ProyectoGym
{
    public partial class FormPrincipal : Form
    {
        Task guardarCambios;
        CancellationTokenSource cancelarHilo;
        public event DelegadoInformarCambios onInformarCambios;
        DialogResult result = DialogResult.No;
        DialogResult buscarCambios;
        string direccion = Path.Combine(Directory.GetCurrentDirectory(), "Cliente.json");

        //asocio el evento su manejador, entonces cuando se dispare el evento se ejecuta el codigo obtenido en el metodoinformarCambios
        public FormPrincipal()
        {
            InitializeComponent();
            this.onInformarCambios += this.informarCambios;
        }

        /// <summary>
        /// inicio un bucle infinito mientras la propiedad sea falsa
        /// creo un delay para que no sea tan demandante la llamada.
        /// </summary>
        private void IniciarAvisoCambios()
        {
            while (!this.cancelarHilo.IsCancellationRequested)
            {
                AvisarCambiosSinGuardar();
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// verifico si se ejecuta en un hilo que no sea el principal, creo un delegado de onda 
        /// podria haber llamado tranquilamente de nuevo al metodo
        /// begininvoke llama al metdo desde el hilo principal., por ultimo si esta en el principal modifico el label
        /// </summary>
        private void AvisarCambiosSinGuardar()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(AvisarCambiosSinGuardar);
            }
            else
            {
                switch (this.lblGuardarCambios.Text)
                {
                    case "No hay cambios realizados":
                        this.lblGuardarCambios.Text = "Tienes datos para guardar .";
                        break;
                    case "Tienes datos para guardar .":
                        this.lblGuardarCambios.Text = "Tienes datos para guardar . .";
                        break;
                    case "Tienes datos para guardar . .":
                        this.lblGuardarCambios.Text = "Tienes datos para guardar . . .";
                        break;
                    case "Tienes datos para guardar . . .":
                        this.lblGuardarCambios.Text = "Tienes datos para guardar .";
                        break;
                }
            }
        }

        /// <summary>
        /// verifico que exista un manejador asociado al evento, valido con this.buscarCambios que seria el valor obtenido del form ABM
        /// si hubo cambios guardo en archivos locales serializando en json , la ruta del archivo esta en 
        ///D:\Gabriel\TrabajosFacultad\ProyectoFinalAlvaGabriel\ProyectoGym\bin\Debug\net6.0-windows\Cliente.json
        ///pero se obtiene desde un current directory y se le asigna el nombre Cliente.json para otra pc.
        ///Llamo al evento.
        ///Si se agrego el cliente , se le dio un valor al token cancel y el condicional finaliza el hilo secundario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarArchivosLocales_Click(object sender, EventArgs e)
        {
            if (this.onInformarCambios is not null && this.buscarCambios == DialogResult.OK)
            {
                Cliente aux = new Cliente();
                aux.ImportarDatos(GestorSqlCliente.ObtenerTodasLasPersonas(), this.direccion);
                this.onInformarCambios.Invoke("Cambios guardados con exito.");
                if (this.cancelarHilo != null)
                {
                    this.cancelarHilo.Cancel();
                }
                this.lblGuardarCambios.Text = "No hay cambios realizados";
            }
            else if (this.onInformarCambios is not null && this.result == DialogResult.No)
            {
                this.onInformarCambios.Invoke("No hay cambios para guardar.");
            }
            this.result = DialogResult.No;
        }

        /// <summary>
        /// Muestro el formABM , de aca saco el valor obtuvoUnCambio
        /// Si este al cerrarse es true , genero la instancia del tokencancelation
        /// inicio la tarea en segundo plano y genero el token de cancelacion, tambien llamo al metodo.
        /// dejo el dialogresult buscarCambios en ok para que luego mi metodo guardarArchivosLocales en la condicion pase y esta pueda generar los cambios
        /// y tambien cerrar el hilo secundario que se esta corriendo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FormABM abmClientes = new FormABM();
            abmClientes.ShowDialog();
            bool aux =abmClientes.ObtuvoUnCambio;
            if (abmClientes.ObtuvoUnCambio)
            {
                this.cancelarHilo = new CancellationTokenSource();
                this.guardarCambios = Task.Run(IniciarAvisoCambios, this.cancelarHilo.Token);
                this.result = DialogResult.OK;
                this.buscarCambios = DialogResult.OK;

            }
        }
        /// <summary>
        /// asociado al delegado evento
        /// </summary>
        /// <param name="mensaje"></param>
        public void informarCambios(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
        /// <summary>
        ///  llamo form listados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListados_Click(object sender, EventArgs e)
        {
            FormSubMenuAbm subMenuListado = new FormSubMenuAbm();
            subMenuListado.ShowDialog();
        }

        /// <summary>
        /// listado profesores.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProfesor_Click(object sender, EventArgs e)
        {
            FormProfe nuevoFormProfe = new FormProfe();
            nuevoFormProfe.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.lblGuardarCambios.Text = "No hay cambios realizados";
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult botonCancelar = MessageBox.Show("  Desea salir ?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (botonCancelar == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}