using Entidades;

namespace proyectoIntegrador
{
    public partial class FrmCalculadora : Form
    {
        Numeracion primerOperando;
        Numeracion segundoOperando;
        Numeracion resultado;
        Esistema sistema;
        Operacion calculadora;
        public FrmCalculadora()
        {

            InitializeComponent();

        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperacion.SelectedIndex = 0;
        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtPrimerOperador.Text)))
            {
                this.primerOperando = new Numeracion(txtPrimerOperador.Text, Esistema.Decimal);
            }
        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtSegundoOperador.Text)))
            {
                this.segundoOperando = new Numeracion(txtSegundoOperador.Text, Esistema.Decimal);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtPrimerOperador.Text)))
            {
                txtPrimerOperador.Text = "";
            }

            if (!(string.IsNullOrEmpty(txtSegundoOperador.Text)))
            {
                txtSegundoOperador.Text = "";
            }

            if (lblResultado.Text != "Resultado :")
            {
                lblResultado.Text = "Resultado :";
            }
            this.resultado = null;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrimerOperador.Text) || string.IsNullOrEmpty(txtSegundoOperador.Text))
            {
                MessageBox.Show("Debes ingresar los 2 operadores para efectuar la operacion.");
            }
            else
            {
                this.calculadora = new Operacion(this.primerOperando, this.segundoOperando);
                string? aux = cmbOperacion.SelectedItem.ToString();
                if (aux != null)
                {
                    char aux2 = aux.FirstOrDefault();
                    this.resultado = calculadora.Operar(aux2);
                    setResultado();
                }
            }
        }

        private void setResultado()
        {
            if (this.resultado is not null)
            {
                lblResultado.Text = "Resultado :" + resultado.ConvertirA(this.sistema);
            }
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            this.sistema = Esistema.Decimal;
            setResultado();
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            this.sistema = Esistema.Binario;
            double aux = double.Parse(this.resultado.Valor);
            if (aux >= 0)
            {
                setResultado();
            }
            else
            {
                MessageBox.Show("No se puede convertir numero negativo a binario.");
            }
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult botonCancelar = MessageBox.Show("Desea cerrar la calculadora ?", "Cierre", MessageBoxButtons.YesNo);
            if (botonCancelar == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}