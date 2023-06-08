using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Logica;
using Entidades;

namespace PruebasUnitarias
{
    [TestClass]
    public class GimnasioTest
    {
        private Gimnasio gimnasio;
        public GimnasioService gimnasioService;

        [TestMethod]
        public void TestMethod1()
        {
            gimnasio = new Gimnasio("#Gym12", "TecnoGym", "152424", "335562", "Somos", "Comun", "453344545", "Diagonal 16E", "3147133334");
            gimnasioService = new GimnasioService(ConfigConnection.ConnectionString);
            string resultado = gimnasioService.Guardar(gimnasio);
            string esperado = "Gimnasio registrado correctamente";
            Assert.AreEqual(esperado, resultado);
        }
    }
}
