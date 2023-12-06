using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class SistemaDecimal : Numeracion
    {
        public override double ValorNumerico()
        {
            return double.Parse(this.valor);
        }
        public SistemaDecimal(string valor) : base(valor) 
        {
            this.valor = valor;
        }

        private SistemaBinario DecimalABinario()
        {

            if (EsNumeracionValida(this.valor) && int.Parse(this.valor) > 0)
            {
                string resultado = "";
                int numeroDecimal = int.Parse(this.valor);
                while (numeroDecimal > 0)
                {
                    int residuo = numeroDecimal % 2;
                    resultado = residuo.ToString() + resultado;
                    numeroDecimal /= 2;
                }
                return new SistemaBinario(resultado);
            }
            else 
            {
                return new SistemaBinario(msgError);
            }
           
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema) 
        {
            if (ESistema.Binario == sistema)
            {
                return DecimalABinario();
            }
            else 
            {
                return this;
            }

        }

        protected override bool EsNumeracionValida(string valor)
        {
            bool aux = false;
            if (base.EsNumeracionValida(valor) && EsSistemaDecimalValido(valor))
            {
                aux = true;
            }
            return aux;
        }

        private bool EsSistemaDecimalValido(string valor) 
        {
            bool aux = false;
            if (double.TryParse(valor, out double resultado)) 
            {
                aux = true;
            }
            return aux;
        }

        public static implicit operator SistemaDecimal(double valor) 
        {
            return new SistemaDecimal(valor.ToString());
        }

        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }
    }
}
