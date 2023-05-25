using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Membresia
    {
        public string codigoMiembro { get; set; }
        public string categoria { get; set; }
        public string estado { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string foto { get; set; }
        public int creditos { get; set; }
        public int valorInscripcion { get; set; }
        public int valorMensual { get; set; }
        public int abono { get; set; }
        public int saldo { get; set; }
    }
}
