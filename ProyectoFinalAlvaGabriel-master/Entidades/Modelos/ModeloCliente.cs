using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class ModeloCliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Edisciplinas Disciplinas { get; set; }
        public string CuotaAbonada { get; set; }
        public int IdProfesor { get; set; }

        public override string ToString()
        {
            return $"{this.IdCliente},{this.Nombre},{this.Apellido},{this.Disciplinas},{this.CuotaAbonada},{this.IdProfesor}";
        }

    }
}
