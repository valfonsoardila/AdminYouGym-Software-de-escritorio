using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Logica;
using Entidades;

namespace PruebasUnitarias
{
    [TestClass]
    public class GimnasioTest
    {
        private Gimnasio empleado;
        public GimnasioService empleadoService;

        [TestMethod]
        public void TestMethod1()
        {
            byte[] imagen = new byte[0];
            empleado = new Gimnasio("1003239264", "CC", imagen, "Angel David", "Bolaño Aroca", DateTime.Now, 20, "Manzana A casa 6", "M", "3147133334", "Gimnasio", "valfonsoardila@unicesar.edu.co");
            empleadoService = new GimnasioService(ConfigConnection.ConnectionString);
            string resultado = empleadoService.Guardar(empleado);
            string esperado = "Gimnasio registrado correctamente";
            Assert.AreEqual(esperado, resultado);
        }
    }
}
