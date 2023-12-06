using Entidades.Interfaces;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : ImodelarArchivos
    {
        private string nombre;
        private string apellido;
        private Edisciplinas disciplina;
        private string cuotaAbonada;
        private int idProfesor;

        public Cliente()
        {


        }

        public Cliente(string nombre, string apellido, Edisciplinas disciplina, string cuotaAbonada, int idProfesor)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.disciplina = disciplina;
            this.cuotaAbonada = cuotaAbonada;
            this.idProfesor = idProfesor;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public Edisciplinas Disciplinas
        {
            get { return this.disciplina; }
            set { this.disciplina = value; }
        }

        public string CuotaAbonada
        {
            get { return this.cuotaAbonada; }
            set { this.cuotaAbonada = value; }
        }


        public int IdProfesor
        {
            get { return this.idProfesor; }
            set { this.idProfesor = value; }
        }

        public void ImportarDatos<T>(List<T> lista, string path) where T : class
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;
                string listaJson = JsonSerializer.Serialize(lista, options);
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


        public static ModeloCliente PasarAinstanciaModeloCliente(Cliente cliente)
        {
            ModeloCliente aux = new ModeloCliente();
            aux.Nombre = cliente.Nombre;
            aux.Apellido = cliente.Apellido;
            aux.Disciplinas = cliente.Disciplinas;
            aux.CuotaAbonada = cliente.CuotaAbonada;
            aux.IdProfesor = cliente.IdProfesor;
            return aux;
        }
        public static bool ValidarString(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor) || valor.Any(char.IsDigit) || valor.Contains(" "))
            {
                return false;
            }
            return true;
        }
    }
}