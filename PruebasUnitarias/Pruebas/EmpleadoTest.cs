using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Logica;
using Entidades;

namespace PruebasUnitarias
{
    [TestClass]
    public class EmpleadoTest
    {
        private Empleado empleado;
        public EmpleadoService empleadoService;

        [TestMethod]
        public void TestMethod1()
        {
            byte[] imagen= new byte[0];
            empleado = new Empleado("1003239264", "CC", imagen, "Angel David", "Bolaño Aroca", DateTime.Now, 20, "Manzana A casa 6", "M", "3147133334", "Empleado", "valfonsoardila@unicesar.edu.co");
            empleadoService = new EmpleadoService(ConfigConnection.ConnectionString);
            string resultado = empleadoService.Guardar(empleado);
            string esperado = "Empleado registrado correctamente";
            Assert.AreEqual(esperado,resultado);
        }
    }
}
