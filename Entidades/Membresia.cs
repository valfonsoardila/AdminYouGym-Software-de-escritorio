using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Membresia
    {
        public string CodigoMiembro { get; set; }
        public string Categoria { get; set; }
        public string Estado { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Foto { get; set; }
        public int Creditos { get; set; }
        public int ValorInscripcion { get; set; }
        public int ValorMensual { get; set; }
        public int Abono { get; set; }
        public int Saldo { get; set; }
    }
}
