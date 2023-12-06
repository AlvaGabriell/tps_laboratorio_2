using Entidades.Interfaces;
using System.Text.Json;

namespace Entidades
{
    public class Profesor : ImodelarArchivos
    {
        private string nombreProfesor;
        private string apellidoProfesor;
        private float sueldoProfesor;
        private string enseniaDisciplina;


        public Profesor(string nombreProfesor, string apellidoProfesor, float sueldoProfesor, string enseniaDisciplina)
        {
            this.nombreProfesor = nombreProfesor;
            this.apellidoProfesor = apellidoProfesor;
            this.sueldoProfesor = sueldoProfesor;
            this.enseniaDisciplina = enseniaDisciplina;
        }

        public string NombreProfesor
        {
            get { return this.nombreProfesor; }
            set { this.nombreProfesor = value; }
        }
        
        public string ApellidoProfesor
        {
            get { return this.apellidoProfesor; }
            set { this.apellidoProfesor = value; }
        }

        public float SueldoProfesor
        {
            get { return this.sueldoProfesor; }
            set { this.sueldoProfesor = value; }
        }
        public string EnseniaDisciplina
        {
            get { return this.enseniaDisciplina; }
            set { this.enseniaDisciplina = value; }
        }

        public void ImportarDatos<T>(List<T> lista, string path) where T : class
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                string listaJson = JsonSerializer.Serialize(lista);
                sw.WriteLine(listaJson);
            }
        }
        public List<T> ExportarDatos<T>(List<T> lista, string path) where T : class
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string listaJson = sr.ReadToEnd();
                    lista = JsonSerializer.Deserialize<List<T>>(listaJson);
                }
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("No se obtuvieron datos");
            }

        }
    }
}