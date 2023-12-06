using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface ImodelarArchivos
    {
        public void ImportarDatos<T>(List<T> lista, string path) where T : class;
        public List<T> ExportarDatos<T>(List<T> lista, string path) where T : class;
    }
}
