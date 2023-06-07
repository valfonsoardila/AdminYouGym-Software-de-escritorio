using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Logica;
using Entidades;

namespace PruebasUnitarias
{
    public class EntrenadorTets
    {
        [TestClass]
        public class EntrenadorTest
        {
            private Entrenador empleado;
            public EntrenadorService empleadoService;

            [TestMethod]
            public void TestMethod1()
            {
                byte[] imagen = new byte[0];
                empleado = new Entrenador("1003239264", "CC", imagen, "Angel David", "Bolaño Aroca", DateTime.Now, 20, "Manzana A casa 6", "M", "3147133334", "Entrenador", "valfonsoardila@unicesar.edu.co");
                empleadoService = new EntrenadorService(ConfigConnection.ConnectionString);
                string resultado = empleadoService.Guardar(empleado);
                string esperado = "Entrenador registrado correctamente";
                Assert.AreEqual(esperado, resultado);
            }
        }
    }
}
