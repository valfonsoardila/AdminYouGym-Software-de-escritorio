using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Logica
{
    public class PapeleraService
    {
        private readonly PapeleraRepository PapeleraRepository;
        public PapeleraService()
        {
            PapeleraRepository = new PapeleraRepository();
        }

        public string Guardar(Papelera papelera)
        {
            try
            {
                PapeleraRepository.Guardar(papelera);
                return "Papelera registro Satisfactoriamente";
            }
            catch (Exception e)
            {
                return "Error al Guardar:" + e.Message;
            }
        }

        public PapeleraConsultaResponse Consultar()
        {
            try
            {
                return new PapeleraConsultaResponse(PapeleraRepository.Consultar());
            }
            catch (Exception e)
            {
                return new PapeleraConsultaResponse("Error al Guardar:" + e.Message);
            }
        }
        public bool FiltroIdentificaicon(string identificacion)
        {

            try
            {
                return (PapeleraRepository.FiltroIdentificaicon(identificacion));
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public string Modificar(Papelera papelera, string identificacion)
        {
            try
            {
                PapeleraRepository.Modificar(papelera, identificacion);
                return "Papelera Modificada Satisfactoriamente";
            }
            catch (Exception e)
            {
                return "Error al Modificar:" + e.Message;
            }
        }
        public string Eliminar(string identificacion)
        {
            try
            {
                PapeleraRepository.Eliminar(identificacion);
                return "Papelera Eliminada";
            }
            catch (Exception)
            {
                return ("Error al Eliminar");
            }
        }
        public string EliminarHistorial()
        {
            try
            {
                PapeleraRepository.EliminarHistorial();
                return "Historial Eliminado";
            }
            catch (Exception)
            {
                return ("Error al Eliminar");
            }
        }
    }
}
