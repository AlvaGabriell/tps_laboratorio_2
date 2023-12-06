using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class ModeloProfesor
    {
        public int ID_Profesor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public float Sueldo { get; set; }
        public string Disciplina { get; set; }
    }

}
