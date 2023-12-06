using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal  class SistemaBinario : Numeracion
    {
        public SistemaBinario(string valor) : base(valor)
        {
            this.valor = valor;
        }

        public override double ValorNumerico()
        {
            return double.Parse(BinarioADecimal().Valor);
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                return BinarioADecimal();
            }
            else 
            {
                return this;
            }
        }

        protected override bool EsNumeracionValida(string valor)
        {
            bool aux = false;
            if (base.EsNumeracionValida(valor) && EsSistemBinarioValido(valor))
            {
                aux = true;
            }
            return aux;
        }


        private bool EsSistemBinarioValido(string valor)
        {
            foreach (char caracter in valor)
            {
                if (caracter != '0' && caracter != '1')
                {
                    return false;
                }
            }
            return true;
        }

        private SistemaDecimal BinarioADecimal()
        {
            if (EsSistemBinarioValido(this.valor))
            {
                double retDecimal = 0;
                int longitud = this.valor.Length;
                for (int i = 0; i < longitud; i++)
                {
                    int digito = int.Parse(this.valor[i].ToString());

                    if (digito == 1)
                    {
                        retDecimal += (int)Math.Pow(2, longitud - i - 1);
                    }
                }
                return new SistemaDecimal(retDecimal.ToString());
            }
            else
            {
                return new SistemaDecimal(double.MinValue.ToString());
            }
        }

        public static implicit operator SistemaBinario(string valor)
        {
            return new SistemaBinario(valor);
        }
    }
}
