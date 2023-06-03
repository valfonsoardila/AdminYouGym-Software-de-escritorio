using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Membresia
    {
        public Membresia(string codigoMiembro, string categoria, string estado, string nombres, string apellidos, int creditos, int valorInscripcion, int valorMensual, int abono, int saldo)
        {
            CodigoMiembro = codigoMiembro;
            Categoria = categoria;
            Estado = estado;
            Nombres = nombres;
            Apellidos = apellidos;
            Creditos = creditos;
            ValorInscripcion = valorInscripcion;
            ValorMensual = valorMensual;
            Abono = abono;
            Saldo = saldo;
        }
        public Membresia()
        {

        }
        public string CodigoMiembro { get; set; }
        public string Categoria { get; set; }
        public string Estado { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreDePlan { get; set; }
        public int Creditos { get; set; }
        public int ValorInscripcion { get; set; }
        public int ValorMensual { get; set; }
        public int Abono { get; set; }
        public int Saldo { get; set; }
        
        public void ObtenerPizarraMiembro()
        {
            int abono = Abono;
            int valorMensual = 60000;
            if (Categoria == "Principiante")
            {
                ValorInscripcion = 5000;
                ValorMensual = valorMensual;
                Creditos = 7;
                Saldo = (valorMensual - abono)+ValorInscripcion;
            }
            else
            {
                valorMensual = 70000;
                if (Categoria == "Elite")
                {
                    ValorInscripcion = 8000;
                    ValorMensual = valorMensual;
                    Creditos = 18;
                    Saldo = (valorMensual - abono) + ValorInscripcion;
                }
                else
                {
                    valorMensual = 80000;
                    if (Categoria == "Profesional")
                    {
                        ValorInscripcion = 15000;
                        ValorMensual = valorMensual;
                        Creditos = 30;
                        Saldo = (valorMensual - abono) + ValorInscripcion;
                    }
                }
            }
        }
    }
}
