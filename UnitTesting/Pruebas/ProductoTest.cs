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
            empleado = new Producto("1003239264", "CC", imagen, "Angel David", "Bolaño Aroca", DateTime.Now, 20, "Manzana A casa 6", "M", "3147133334", "Producto", "valfonsoardila@unicesar.edu.co");
            empleadoService = new ProductoService(ConfigConnection.ConnectionString);
            string resultado = empleadoService.Guardar(empleado);
            string esperado = "Producto registrado correctamente";
            Assert.AreEqual(esperado, resultado);
        }
    }
}
