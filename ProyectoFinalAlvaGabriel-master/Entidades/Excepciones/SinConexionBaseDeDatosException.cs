using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class SinConexionBaseDeDatosException : Exception
    {
        public SinConexionBaseDeDatosException(string? message) : base(message)
        {

        }

        public SinConexionBaseDeDatosException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
