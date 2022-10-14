using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlanDeEjercicio
    {
        public PlanDeEjercicio(string tipoDeTiempo, int numeroDiasMeses, DateTime fechaDeEntreno,string sesion, string objetivo, string descripcionPlanEjercicio, string estado, string ciclo)
        {
            TipoDeTiempo = tipoDeTiempo;
            NumeroDiasMeses = numeroDiasMeses;
            FechaDeEntreno = fechaDeEntreno;
            Sesion = sesion;
            Objetivo = objetivo;
            DescripcionPlanEjercicio = sesion;
            DescripcionPlanEjercicio = descripcionPlanEjercicio;
            Estado = estado;
            Ciclo = ciclo;
        }

        public PlanDeEjercicio()
        {

        }
        //Atributos de la clase
        public string IdPlanDeEjercicio { get; set; }
        public string TipoDeTiempo { get; set; }
        public int NumeroDiasMeses { get; set; }
        public DateTime FechaDeEntreno { get; set; }
        public string Sesion { get; set; }
        public string Objetivo { get; set; }
        public string DescripcionPlanEjercicio { get; set; }
        public string Estado { get; set; }
        public string Ciclo { get; set; }
        public double Precio { get; set; }
        public string IdCliente { get; set; }
        public string TipoIdCliente { get; set; }
        public string NombreCliente { get; set; }

        //Metodos De la clase
        public void CalcularPrecio()
        {
            if(TipoDeTiempo== "Mes/Meses")
            {
                Precio = NumeroDiasMeses * 120000;
            }
            else
            {
                if(TipoDeTiempo== "Dia/Dias")
                {
                    Precio = NumeroDiasMeses * 11300;
                }
            }
        }
        public void GenerarIdPlanEjercicio()
        {
            string a = "#Plan";
            int b;
            string codigo;
            Random aleatorio = new Random();
            b = aleatorio.Next(1, 1000);
            codigo = a + b;
            IdPlanDeEjercicio = codigo;
        }
    }
}
