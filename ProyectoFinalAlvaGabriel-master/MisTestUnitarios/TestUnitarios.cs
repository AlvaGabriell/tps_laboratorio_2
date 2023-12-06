using Entidades;
using Entidades.Modelos;

namespace MisTestUnitarios
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        public void AlRecibirUnClienteSeEsperaObtenerSuEquivalenteEnLaClaseModelo()
        {
            // Arrange
            Cliente cliente = new Cliente
            {
                // Inicializa propiedades del cliente
                Nombre = "Elton",
                Apellido = "Jhon",
                Disciplinas = Edisciplinas.crossfit,
                CuotaAbonada = "si",
                IdProfesor = 123
            };
            ModeloCliente clienteModelo;
            // Act 
            clienteModelo = Cliente.PasarAinstanciaModeloCliente(cliente);

            // Assert
            Assert.AreEqual(cliente.Nombre, clienteModelo.Nombre);
            Assert.AreEqual(cliente.Apellido, clienteModelo.Apellido);
            Assert.AreEqual(cliente.Disciplinas, clienteModelo.Disciplinas);
            Assert.AreEqual(cliente.CuotaAbonada, clienteModelo.CuotaAbonada);
            Assert.AreEqual(cliente.IdProfesor, clienteModelo.IdProfesor);
        }


        [TestMethod]
        public void ValidarString_DeberiaDevolverTrue_CuandoStringNoContieneEspaciosONumerosONoEsNull()
        {
            // Arrange
            string valorPrueba = "PruebaTestUnitario";

            // Act
            bool resultado = Cliente.ValidarString(valorPrueba);

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void ValidarString_DeberiaDevolverFalse_CuandoStringEsNullOtieneEspaciosOUnNumero()
        {
            // Arrange
            string valorPrueba1 = " qq";
            string valorPrueba2 = "";
            string valorPrueba3 = "Prueba55ario";

            // Act
            bool resultado1 = Cliente.ValidarString(valorPrueba1);
            bool resultado2 = Cliente.ValidarString(valorPrueba2);
            bool resultado3 = Cliente.ValidarString(valorPrueba3);

            // Assert
            Assert.IsFalse(resultado1);
            Assert.IsFalse(resultado2);
            Assert.IsFalse(resultado3);
        }

    }
}