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
            empleado = new Membresia("#Cl14433", "Elite", "Activo","Angel David", "Bolaño Aroca", "Aerobico", 20, 13000, 120000, 23000, 97000);
            empleadoService = new MembresiaService(ConfigConnection.ConnectionString);
            string resultado = empleadoService.Guardar(empleado);
            string esperado = "Membresia registrada correctamente";
            Assert.AreEqual(esperado, resultado);
        }
    }
}
