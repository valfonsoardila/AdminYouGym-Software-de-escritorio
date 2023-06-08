using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Logica;
using Entidades;

namespace PruebasUnitarias
{
    [TestClass]
    public class AdministradorTest
    {
        private Administrador administrador;
        public AdministradorService administradorService;

        [TestMethod]
        public void TestMethod1()
        {
            byte[] imagen = new byte[0];
            administrador = new Administrador("1003236492", "CC", imagen, "Angel David", "Bolaño Aroca", DateTime.Now, "Manzana A casa 6", "M", "3147133334", "Administrador", "valfonsoardila@unicesar.edu.co");
            administradorService = new AdministradorService(ConfigConnection.ConnectionString);
            string resultado = administradorService.Guardar(administrador);
            string esperado = "Administrador registrado correctamente";
            Assert.AreEqual(esperado, resultado);
        }
    }
}
