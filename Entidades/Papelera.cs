using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Papelera
    {
        public Papelera(string idCajaDelete, string fechaDeAperturaDelete, string fechaDeCierreDelete, string estadoDelete, double montoDelete)
        {
            Id_CajaDelete = idCajaDelete;
            FechaDeAperturaDelete = fechaDeAperturaDelete;
            FechaDeCierreDelete = fechaDeCierreDelete;
            EstadoDelete = estadoDelete;
            MontoDelete = montoDelete;
        }
        public Papelera()
        {

        }
        public string Id_CajaDelete { get; set; }
        public string FechaDeAperturaDelete { get; set; }
        public string FechaDeCierreDelete { get; set; }
        public string EstadoDelete { get; set; }
        public double MontoDelete { get; set; }
        public override string ToString()
        {
            return $"\n" +
                   $"- Id_CajaDelete: {Id_CajaDelete}\n" +
                   $"- FechaDeAperturaDelete: {FechaDeAperturaDelete}\n" +
                   $"- FechaDeCierreDelete: {FechaDeCierreDelete}\n" +
                   $"- EstadoDelete: {EstadoDelete}\n" +
                   $"- MontoDelete: {MontoDelete}\n";
        }
    }
}
