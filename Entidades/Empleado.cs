using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        //Constructor
        public Empleado(string identificacion, string tipoDeIdentificacion, byte[] imagenPerfil, string nombres, string apellidos, DateTime fechaDeNacimiento, int edad, string direccion, string sexo, string telefono, string rol, string correoElectronico)
        {
            Identificacion = identificacion;
            TipoDeIdentificacion = tipoDeIdentificacion;
            ImagenPerfil = imagenPerfil;
            Nombres = nombres;
            Apellidos = apellidos;
            FechaDeNacimiento = fechaDeNacimiento;
            Edad = edad;
            Direccion = direccion;
            Sexo = sexo;
            Telefono = telefono;
            Rol = rol;
            CorreoElectronico = correoElectronico;
        }
        //Constructor Sobrecargado
        public Empleado()
        {

        }
        /*Atributos de la clase*/
        public string Identificacion { get; set; }
        public string TipoDeIdentificacion { get; set; }
        public byte[] ImagenPerfil { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Rol { get; set; }
        public string CorreoElectronico { get; set; }
        public void CalcularEdad()
        {
            int AñoActual = DateTime.Now.Year;
            Edad = AñoActual - FechaDeNacimiento.Year;
        }
    }
}
