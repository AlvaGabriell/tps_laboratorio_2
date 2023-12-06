using System;
using System.Collections.Generic;
using Entidades.Modelos;

namespace Entidades.Extension
{
    public static class ExtensionCliente
    {
        public static int ContarClienteIngresado(this List<ModeloCliente> listaClientes, string nombre, string apellido)
        {
            int contador = 0;
            foreach(ModeloCliente cliente in listaClientes) 
            {
                if (cliente.Nombre == nombre && cliente.Apellido == apellido) 
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}

/*using System;
using System.Collections.Generic;

namespace Entidades.Extension
{
    public static class ExtensionCliente
    {
        public static int ContarClienteIngresado(this List<ModeloCliente> listaClientes, string nombre, string apellido)
        {
            Func<ModeloCliente, string, string, bool> DelegadoComprobarCliente = EsClienteBuscado;
            return ContarClientesConCondicion(listaClientes, EsClienteBuscado, nombre, apellido);
        }

        public static bool EsClienteBuscado(ModeloCliente cliente, string nombreBuscado, string apellidoBuscado)
        {
            return cliente.Nombre == nombreBuscado && cliente.Apellido == apellidoBuscado;
        }

        private static int ContarClientesConCondicion(List<ModeloCliente> listaClientes, Func<ModeloCliente, string, string, bool> DelegadoComprobar, string nombre, string apellido)
        {
            int cantidad = 0;
            foreach (ModeloCliente cliente in listaClientes)
            {
                if (DelegadoComprobar(cliente, nombre, apellido))
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
    }
}*/