using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Logica;
using Entidades;

namespace PruebasUnitarias
{
    [TestClass]
    public class ProductoTest
    {
        private Producto empleado;
        public ProductoService empleadoService;

        [TestMethod]
        public void TestMethod1()
        {
            byte[] imagen = new byte[0];
            empleado = new Producto(13, "12ER", 13000, "Acetaminofen", "500mg", DateTime.Now, DateTime.Now, "L432FD", "MK", "Vencido", "Oral", 200,5000,15000,100,100,"Est2");
            empleadoService = new ProductoService(ConfigConnection.ConnectionString);
            string resultado = empleadoService.Guardar(empleado);
            string esperado = "Producto registrado correctamente";
            Assert.AreEqual(esperado, resultado);
        }
    }
}
