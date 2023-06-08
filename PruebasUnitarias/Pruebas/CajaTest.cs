using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Logica;
using Entidades;

namespace PruebasUnitarias
{
    [TestClass]
    public class CajaTest
    {
        private Caja administrador;
        public CajaRegistradoraService administradorService;

        [TestMethod]
        public void TestMethod1()
        {
            byte[] imagen = new byte[0];
            administrador = new Caja("#CJ123", "06/06/2023", "08:30 a.m", "07/06/2023", "10:30 a.m","Cerrada",0, 12000, 120000);
            administradorService = new CajaRegistradoraService(ConfigConnection.ConnectionString);
            string resultado = administradorService.Guardar(administrador);
            string esperado = "Caja abierta correctamente";
            Assert.AreEqual(esperado, resultado);
        }
    }
}
