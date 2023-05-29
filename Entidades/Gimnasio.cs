using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gimnasio
    {
        public Gimnasio(string idGimnasio, string nombreGimnasio, string nit, string codigoDeCamara, string fraseDistintiva, string regimen,  string pbx, string direccion, string telefono)
        {
            IdGimnasio = idGimnasio;
            NombreGimnasio = nombreGimnasio;
            NIT = nit;
            CodigoDeCamara = codigoDeCamara;
            FraseDistintiva = fraseDistintiva;
            Regimen = regimen;
            PBX = pbx;
            Direccion = direccion;
            Telefono = telefono;
        }
        public Gimnasio()
        {

        }
        public string IdGimnasio { get; set; }
        public string NombreGimnasio { get; set; }
        public string NIT { get; set; }
        public string CodigoDeCamara { get; set; }
        public string FraseDistintiva { get; set; }
        public string Regimen { get; set; }
        public string PBX { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public void GenerarIdGimnasio()
        {
            IdGimnasio = "#Gym";
        }
    }
}
