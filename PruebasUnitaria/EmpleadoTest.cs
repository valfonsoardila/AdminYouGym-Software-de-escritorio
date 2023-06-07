using Entidades;
using Logica;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PruebasUnitaria
{
    public class Tests
    {
        EmpleadoService empleadoService;
        Empleado empleado;
        [SetUp]
        public void Setup()
        {
            empleado = new Empleado("1003377848", "CC", null, "Victor Alfonso", "Ardila Montalban", DateTime.Now, 20, "Manzana A casa 6", "M", "3147133334", "Empleado", "valfonsoardila@unicesar.edu.co");
            empleadoService = new EmpleadoService(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        }

        [Test]
        public void Test1()
        {
            string resultado = empleadoService.Guardar(empleado);
            string esperado = "Empleado registrado correctamente";
            Assert.That(resultado, Is.EqualTo(esperado));
            Assert.Pass();
        }
    }
}