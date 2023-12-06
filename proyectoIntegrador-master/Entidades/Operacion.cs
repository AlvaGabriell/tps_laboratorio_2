using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Numeracion PrimerOperando
        {
            get
            {
                return this.primerOperando;
            }
            set
            {
                this.primerOperando = value;
            }
        }

        public Numeracion SegundoOperando
        {
            get
            {
                return this.segundoOperando;
            }
            set
            {
                this.segundoOperando = value;
            }
        }


        public Operacion(Numeracion primerOperando, Numeracion segundoOperando) 
        {
           this.primerOperando = primerOperando;
           this.segundoOperando = segundoOperando;
        }

        public Numeracion Operar(char operador) 
        {
            double aux2;
            switch (operador)
            {
                case '/':
                    aux2 = double.Parse((this.primerOperando / this.segundoOperando).Valor);
                    break;
                case '*':
                    aux2 = double.Parse((this.primerOperando * this.segundoOperando).Valor);
                    break;
                case '-':
                    aux2 = double.Parse((this.primerOperando - this.segundoOperando).Valor);
                    break;
                default:
                    aux2 = double.Parse((this.primerOperando + this.segundoOperando).Valor);
                    break;
             }
            return new Numeracion(aux2, Esistema.Decimal);
         }
    }
}
