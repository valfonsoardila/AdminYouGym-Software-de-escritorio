using Entidades;
using Logica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias
{
    [TestClass]
    public class UsuarioTest
    {
        private Usuario usuario;
        public UsuarioService usuarioService;

        [TestMethod]
        public void TestMethod1()
        {
            byte[] imagen = new byte[0];
            usuario = new Usuario("#User1230", imagen, "Angel David", "Bolaño Aroca", "Usuario", "valfonsoardila@unicesar.edu.co", "@Angel32", "123456789");
            usuarioService = new UsuarioService(ConfigConnection.ConnectionString);
            string resultado = usuarioService.Guardar(usuario);
            string esperado = "Usuario registrado correctamente";
            Assert.AreEqual(esperado, resultado);
        }
    }
}
