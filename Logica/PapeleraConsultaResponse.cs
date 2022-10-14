using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Logica
{
    public class PapeleraConsultaResponse
    {
        public List<Papelera> Papeleras { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public bool Encontrado { get; set; }

        public PapeleraConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Encontrado = false;
        }
        public PapeleraConsultaResponse(List<Papelera> papeleras)
        {
            Papeleras = new List<Papelera>();
            Papeleras = papeleras;
            Encontrado = true;
        }
    }
}
