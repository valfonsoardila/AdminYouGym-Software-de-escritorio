using Entidades;
using Logica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string identificacion;
            Empleado empleado = new Empleado(identificacion, string tipoDeIdentificacion, byte[] imagenPerfil, string nombres, string apellidos, DateTime fechaDeNacimiento, int edad, string direccion, string sexo, string telefono, string rol, string correoElectronico);
            string resultado = empleadoService.Guardar(empleado);
        }
    }
}
