using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entrenador
    {

        //Constructor
        public Entrenador(string identificacion, string tipoDeIdentificacion, string nombres, string apellidos, DateTime fechaDeNacimiento, int edad,string direccion, string sexo,string correoElectronico)
        {
            Identificacion = identificacion;
            TipoDeIdentificacion = tipoDeIdentificacion;
            Nombres = nombres;
            Apellidos = apellidos;
            FechaDeNacimiento = fechaDeNacimiento;
            Edad = edad;
            Sexo = sexo;
            Direccion = direccion;
            CorreoElectronico = correoElectronico;
        }

        public Entrenador()
        {

        }

        /*Atributos de la clase*/
        public string Identificacion { get; set; }
        public string TipoDeIdentificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public string CodigoEntrenador { get; set; }
        public int PagoDeSalario { get; set; }
        public int HorasExtrasDeTrabajo{ get; set; }
        public int DiasDeTrabajo { get; set; }
        public int MesesDeContrato { get; set; }
        public string TipoDeContrato { get; set; }
        /*Metodos de la clase*/
        public void CalcularEdad()
        {
            int fechaActual;
            fechaActual = DateTime.Today.Year;
            Edad = fechaActual - FechaDeNacimiento.Year;
        }
        public void CalcularSalario()
        {
            string TipoC="";
            TipoC = TipoDeContrato;
            if (TipoC == "Ps" || TipoC == "Ps(Prestacion-de-servicios)")
            {
                PagoDeSalario = (60000 * DiasDeTrabajo) + (HorasExtrasDeTrabajo * 100000);
            }
            else
            {
                if (TipoC == "Cf" || TipoC == "Cf(Contrato-a-termino-fijo)")
                {
                    PagoDeSalario = (2000000* MesesDeContrato) + (HorasExtrasDeTrabajo * 100000);
                }
            }
        }
        public void GenerarCodigoEntrenador()
        {
            string a = "#En";
            int b;
            string codigo;
            Random aleatorio = new Random();
            b = aleatorio.Next(400000, 500000);
            codigo = a + b;
            CodigoEntrenador = codigo;
        }
    }
}
