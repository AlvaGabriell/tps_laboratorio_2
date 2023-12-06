using System.Drawing;

namespace Entidades
{
    public enum Esistema
    {
        Decimal,
        Binario
    }

    public class Numeracion
    {
        //Atributos.

        private Esistema sistema;
        private double valorNumerico;

        //Propiedades.
        public string Valor 
        {
            get 
            {
                return this.valorNumerico.ToString();
            }
        }

        public Esistema Sistema 
        {
            get 
            {
                return sistema;
            }
        }

        //Constructores{

        public Numeracion(double valor,Esistema sistema) 
        {
            this.valorNumerico = valor;
            this.sistema = sistema;
        }

        public Numeracion(string valor, Esistema sistema)
        {
            InicialziarValores(valor, sistema);
        }
        //Metodos.

        private void InicialziarValores(string valor, Esistema sistema)
        {
            if (EsBinario(valor))
            {
                this.valorNumerico = BinarioADecimal(valor);
            }
            else
            {
                if (double.TryParse(valor, out double auxValor))
                {
                    this.valorNumerico = auxValor;
                }
                else
                {
                    this.valorNumerico = Double.MinValue;
                }
            }
        }

        double BinarioADecimal(string valorIngresado)
        {
            if (EsBinario(valorIngresado) == true)
            {
                double retDecimal = 0;
                int longitud = valorIngresado.Length;
                for (int i = 0; i < longitud; i++)
                {
                    int digito = int.Parse(valorIngresado[i].ToString());

                    if (digito == 1)
                    {
                        retDecimal += (int)Math.Pow(2, longitud - i - 1);
                    }
                }
                return retDecimal;
            }
            else
            {
                return 0;
            }
        }
        private bool EsBinario(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (caracter != '0' && caracter != '1')
                {
                    return false;
                }
            }
            return true;
        }

        static string DecimalABinario(int numeroDecimal)
        {
            if (numeroDecimal == 0)
            {
                return "0";
            }

            string resultado = "";

            while (numeroDecimal > 0)
            {
                int residuo = numeroDecimal % 2;
                resultado = residuo.ToString() + resultado;
                numeroDecimal /= 2;
            }

            return resultado;
        }
        static string DecimalABinario(string numeroDecimal)
        {
            if (int.TryParse(numeroDecimal, out int resultado))
            {
                return DecimalABinario(resultado);
            }
            else
            {
                return "Numero invalido";
            }
        }

        public string ConvertirA(Esistema sistemaNum)
        {
            string aux;

            if (sistemaNum == Esistema.Decimal)
            {

                return this.valorNumerico.ToString();
            }
            else
            {
               
                return aux = DecimalABinario(this.Valor);
            }
        }

        //Sobrecargas.

        public static Numeracion operator +(Numeracion n1, Numeracion n2)
        {
            double auxiliar= double.Parse(n1.ConvertirA(Esistema.Decimal))+double.Parse(n2.ConvertirA(Esistema.Decimal));
            Numeracion aux = new Numeracion(auxiliar,Esistema.Decimal);
            return aux;
        }

        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            double auxiliar = double.Parse(n1.ConvertirA(Esistema.Decimal)) - double.Parse(n2.ConvertirA(Esistema.Decimal));
            Numeracion aux = new Numeracion(auxiliar, Esistema.Decimal);
            return aux;
        }

        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            double auxiliar = double.Parse(n1.ConvertirA(Esistema.Decimal)) * double.Parse(n2.ConvertirA(Esistema.Decimal));
            Numeracion aux = new Numeracion(auxiliar, Esistema.Decimal);
            return aux;
        }

        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            if (double.Parse(n2.ConvertirA(Esistema.Decimal))==0)
            {
                Numeracion aux1 = new Numeracion(double.MinValue, Esistema.Decimal);
                return aux1;
            }
            else 
            {
                double auxiliar = double.Parse(n1.ConvertirA(Esistema.Decimal)) / double.Parse(n2.ConvertirA(Esistema.Decimal));
                Numeracion aux2 = new Numeracion(auxiliar, Esistema.Decimal);
                return aux2;
            }
        }

        public static bool operator ==(Esistema sistema, Numeracion numeracion)
        {
            return sistema == numeracion.Sistema;
        }

        public static bool operator !=(Esistema sistema, Numeracion numeracion)
        {
            return !(sistema==numeracion.Sistema);
        }

        public static bool operator ==(Numeracion n1, Numeracion n2) 
        {
            return (n1.Sistema == n2.Sistema);
        }

        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1.Sistema == n2.Sistema);
        }
    }

}