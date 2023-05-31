using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        //Constructor
        public Usuario(string codigoUsuario, byte[] imagenPerfil, string nombres, string apellidos, string rol, string correoElectronico, string nombreUsuario, string contraseña)
        {
            CodigoUsuario = codigoUsuario;
            ImagenPerfil = imagenPerfil;
            Nombres = nombres;
            Apellidos = apellidos;
            Rol = rol;
            CorreoElectronico = correoElectronico;
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
        }
        //Constructor Sobrecargado
        public Usuario()
        {

        }
        /*Atributos de la clase*/
        public string CodigoUsuario { get; set; }
        public byte[] ImagenPerfil { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Rol { get; set; }
        public string CorreoElectronico { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public void GenerarCodigoUsuario()
        {
            string a = "#User";
            int b;
            string codigo;
            Random aleatorio = new Random();
            b = aleatorio.Next(400000, 500000);
            codigo = a + b;
            CodigoUsuario = codigo;
        }
    }
}
