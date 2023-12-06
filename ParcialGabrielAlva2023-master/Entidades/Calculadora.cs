using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones;
        private Numeracion primerOperando;
        private Numeracion resultado;
        private Numeracion segundoOperando;
        private static ESistema sistema;

        public static ESistema Sistema
        {
            get { return sistema; }
            set { sistema = value; }
        }

        public string NombreAlumno
        {
            get { return this.nombreAlumno; }
            set { this.nombreAlumno = value; }
        }

        public List<string> Operaciones
        {
            get { return this.operaciones; }
        }

        public Numeracion PrimerOperando
        {
            get { return this.primerOperando; }
            set { this.primerOperando = value; }
        }

        public Numeracion Resultado
        {
            get { return this.resultado; }

        }

        public Numeracion SegundoOperando
        {
            get { return this.segundoOperando; }
            set { this.segundoOperando = value; }
        }

        static Calculadora()
        {
            sistema = ESistema.Decimal;
        }

        public Calculadora()
        {
            operaciones = new List<string>();
        }


        public void Calcular()
        {

        }
    }
}
