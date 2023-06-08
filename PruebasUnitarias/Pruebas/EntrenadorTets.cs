using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Logica;
using Entidades;

namespace PruebasUnitarias
{
    [TestClass]
    public class EntrenadorTest
    {
        private Entrenador entrenador;
        public EntrenadorService entrenadorService;

        [TestMethod]
        public void TestMethod1()
        {
            byte[] imagen = new byte[0];
            entrenador = new Entrenador("1003339262", "CC", imagen, "Angel David", "Bolaño Aroca", DateTime.Now, 20, "M", "Manzana A casa 6", "3147133334", "valfonsoardila@unicesar.edu.co", "#Ent24352", 2000000, 12, 30, 1, "Contrato a termino fijo");
            entrenadorService = new EntrenadorService(ConfigConnection.ConnectionString);
            string resultado = entrenadorService.Guardar(entrenador);
            string esperado = "Entrenador registrado correctamente";
            Assert.AreEqual(esperado, resultado);
        }
    }
}
