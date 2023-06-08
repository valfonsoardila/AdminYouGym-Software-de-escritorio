using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Logica;
using Entidades;

namespace PruebasUnitarias
{
    [TestClass]
    public class MembresiaTest
    {
        private Membresia empleado;
        public MembresiaService empleadoService;

        [TestMethod]
        public void TestMethod1()
        {
            byte[] imagen = new byte[0];
            empleado = new Membresia("1003239264", "CC", imagen, "Angel David", "Bolaño Aroca", DateTime.Now, 20, "Manzana A casa 6", "M", "3147133334", "Membresia", "valfonsoardila@unicesar.edu.co");
            empleadoService = new MembresiaService(ConfigConnection.ConnectionString);
            string resultado = empleadoService.Guardar(empleado);
            string esperado = "Membresia registrado correctamente";
            Assert.AreEqual(esperado, resultado);
        }
    }
}
