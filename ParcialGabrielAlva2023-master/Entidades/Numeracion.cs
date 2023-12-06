namespace Entidades
{
    internal abstract class Numeracion
    {


        protected internal static string msgError;
        protected string valor;

        public string Valor
        {
            get { return this.valor; }
        }

        public abstract double ValorNumerico();

        static Numeracion()
        {
            msgError = "Numero invalido.";
        }

        protected Numeracion(string valor)
        {
            InicializarValor(valor);
        }
        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        protected virtual bool EsNumeracionValida(string valor)
        {
            return string.IsNullOrWhiteSpace(valor);
        }

        private void InicializarValor(string valor)
        {
            if (EsNumeracionValida(valor) == true)
            {
                this.valor = valor;
            }
            else
            {
                this.valor = msgError;
            }
        }

        public static explicit operator double(Numeracion numeracion)
        {
            return double.Parse(numeracion.Valor);
        }

        public static bool operator ==(Numeracion n1, Numeracion n2)
        {

            return ((n1 is not null && n2 is not null) && n1.GetType() == n2.GetType());
        }

        public static bool operator !=(Numeracion n1, Numeracion n2)
        {

            return !(n1 == n2);
        }


    }
}