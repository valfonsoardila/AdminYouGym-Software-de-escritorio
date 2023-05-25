using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Logica
{
    public class CadenaConexionXMLService
    {
        private readonly CadenaConexionXMLRepository cadenaConexionRepository;
        public CadenaConexionXMLService()
        {
            cadenaConexionRepository = new CadenaConexionXMLRepository();
        }
        public string Modificar(CadenaConexionXML cadenaConexion, string oldServer)
        {
            try
            {
                cadenaConexionRepository.Modificar(cadenaConexion, oldServer);
                return "Producto en txt registro Satisfactoriamente";
            }
            catch (Exception e)
            {
                return "Error al Guardar:" + e.Message;
            }
        }
    }
}
