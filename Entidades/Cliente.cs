using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        //Constructor
        public Cliente(string identificacion,string tipoDeIdentificacion, byte[] imagenPerfil, string nombres,string apellidos, DateTime fechaDeNacimiento, string direccion, string sexo, string telefono,string correoElectronico, double peso, double altura)
        {
            Identificacion = identificacion;
            TipoDeIdentificacion = tipoDeIdentificacion;
            ImagenPerfil = imagenPerfil;
            Nombres = nombres;
            Apellidos = apellidos;
            FechaDeNacimiento = fechaDeNacimiento;
            Direccion = direccion;
            Sexo = sexo;
            Telefono = telefono;
            CorreoElectronico = correoElectronico;
            Peso = peso;
            Altura = altura;
        }
        //Constructor Sobrecargado
        public Cliente()
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
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string Sexo { get; set; } 
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string CodigoCliente { get; set; }
        public string ClasificacionPorPeso { get; set; }
        public double IndiceDeMasaCorporal { get; set; }
        public double IndiceDeGrasaCorporal { get; set; }
        public double IndiceDeMasaMuscular { get; set; }
        public double IndiceDeMasaOsea { get; set; }
        public double IndiceDeMasaResidual { get; set; }
        /*Metodos de la clase*/
        public void GenerarCodigoCliente()
        {
            string a = "#Cl";
            int b;
            string codigo;
            Random aleatorio = new Random();
            b = aleatorio.Next(100000, 200000);
            codigo = a + b;
            CodigoCliente = codigo;
        }
        public void CalcularEdad()
        {
            int fechaActual;
            fechaActual = DateTime.Today.Year;
            Edad = fechaActual-FechaDeNacimiento.Year;

        }
        public void ObtenerIndiceMasaCorporal()
        {
            double indiceDeMasaCorporal;
            indiceDeMasaCorporal = (Peso / (Altura*Altura))*10000;
            IndiceDeMasaCorporal = indiceDeMasaCorporal;
            if (IndiceDeMasaCorporal <= 15){ClasificacionPorPeso = "Delgadez muy Severa";}
            else{ if (IndiceDeMasaCorporal >= 15 && IndiceDeMasaCorporal <= 15.9) { ClasificacionPorPeso = "Delgadez Severa"; }
                else { if (IndiceDeMasaCorporal >= 16 && IndiceDeMasaCorporal <= 18.4) { ClasificacionPorPeso = "Delgadez"; }
                    else { if (IndiceDeMasaCorporal >= 18.5 && IndiceDeMasaCorporal <= 24.9) { ClasificacionPorPeso = "Peso Saludable"; }
                        else { if (IndiceDeMasaCorporal >= 25 && IndiceDeMasaCorporal <= 29.9) { ClasificacionPorPeso = "Sobrepeso"; }
                            else { if (IndiceDeMasaCorporal >= 30 && IndiceDeMasaCorporal <= 34.9) { ClasificacionPorPeso = "Obesidad Moderada"; }
                                else { if (IndiceDeMasaCorporal >= 35 && IndiceDeMasaCorporal <= 39.9) { ClasificacionPorPeso = "Obesidad Severa"; } 
                                    else { if (IndiceDeMasaCorporal >= 40) { ClasificacionPorPeso = "Obesidad muy Severa"; } } 
                                } 
                            } 
                        } 
                    } 
                } 
            }
        }
        public void ObtenerIndiceMasaOsea()
        {
            double porcentajeMasa = 0.15;
            IndiceDeMasaOsea = Peso * porcentajeMasa;
        }
        public void ObtenerIndiceGrasaMuscular()
        {
            double indiceDeGrasaMuscular;
            int valorSexo = 0;
            if (Sexo == "M") { valorSexo = 1; } else { if (Sexo == "F") { valorSexo = 0; } }
            indiceDeGrasaMuscular = 1.2 * (IndiceDeMasaCorporal) + 0.23 * (Edad) - 10.8 * (valorSexo) - 5.4;
            IndiceDeGrasaCorporal = indiceDeGrasaMuscular;
        }
        public void ObtenerIndiceMasaResidual()
        {
            double indiceDeMasaResidual;
            double valorSexo=0;
            if (Sexo == "M") { valorSexo = 0.241; } else { if (Sexo == "F") { valorSexo = 0.209; } }
            indiceDeMasaResidual = Peso * valorSexo;
            IndiceDeMasaResidual = indiceDeMasaResidual;
        }
        public void ObtenerIndiceMasaMuscular()
        {
            IndiceDeMasaMuscular = Peso - (IndiceDeGrasaCorporal + IndiceDeMasaOsea + IndiceDeMasaResidual);
        }
    }
}
