using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Logica
{
    public class PlanDeEjercicioService
    {
        private readonly ConnectionManager conexion;
        private readonly PlanDeEjercicioRepository repositorio;
        public PlanDeEjercicioService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new PlanDeEjercicioRepository(conexion);
        }
        public string Guardar(PlanDeEjercicio planDeEjercicio)
        {
            try
            {
                planDeEjercicio.CalcularPrecio();
                conexion.Open();

                if (repositorio.BuscarPorIdentificacion(planDeEjercicio.IdPlanDeEjercicio) == null)
                {
                    repositorio.Guardar(planDeEjercicio);
                    return $"Se guardaron los datos satisfactoriamente";
                }
                return $"El plan de ejercicio ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConsultaPlanDeEjercicioRespuesta ConsultarTodos()
        {
            ConsultaPlanDeEjercicioRespuesta respuesta = new ConsultaPlanDeEjercicioRespuesta();
            try
            {

                conexion.Open();
                respuesta.PlanesDeEjercicios = repositorio.ConsultarTodos();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.PlanesDeEjercicios.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }

        }
        public ConsultaPlanDeEjercicioRespuesta ConsultarPorEstados(string activo)
        {
            ConsultaPlanDeEjercicioRespuesta respuesta = new ConsultaPlanDeEjercicioRespuesta();
            try
            {
                conexion.Open();
                respuesta.PlanesDeEjercicios = repositorio.ConsultarTodos();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.PlanesDeEjercicios.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }

        }
        public string Eliminar(string identificacion)
        {
            try
            {
                conexion.Open();
                var planDeEjercicio = repositorio.BuscarPorIdentificacion(identificacion);
                if (planDeEjercicio != null)
                {
                    repositorio.Eliminar(planDeEjercicio);
                    conexion.Close();
                    return ($"El registro {planDeEjercicio.IdPlanDeEjercicio} se ha eliminado satisfactoriamente.");
                }
                return ($"Lo sentimos, {identificacion} no se encuentra registrada.");
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }
        public string Modificar(PlanDeEjercicio planDeEjercicioNuevo)
        {
            try
            {
                planDeEjercicioNuevo.CalcularPrecio();
                conexion.Open();
                var planDeEjercicioAntiguo = repositorio.BuscarPorIdentificacion(planDeEjercicioNuevo.IdPlanDeEjercicio);
                if (planDeEjercicioAntiguo != null)
                {
                    repositorio.Modificar(planDeEjercicioNuevo);
                    return ($"El registro de {planDeEjercicioNuevo.IdPlanDeEjercicio} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, el plan de ejercicico con Identificación {planDeEjercicioNuevo.IdPlanDeEjercicio} no se encuentra registrado.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public BusquedaPlanDeEjercicioRespuesta BuscarPorJornada(string jornada)
        {
            BusquedaPlanDeEjercicioRespuesta respuesta = new BusquedaPlanDeEjercicioRespuesta();
            try
            {

                conexion.Open();
                respuesta.PlanDeEjercicio = repositorio.BuscarPorJornada(jornada);
                conexion.Close();
                respuesta.Mensaje = (respuesta.PlanDeEjercicio != null) ? "Se encontró el plan de ejercicio buscado" : "el plan de ejercicio buscada no existe";
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {

                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }
        public BusquedaPlanDeEjercicioRespuesta BuscarPorIdentificacion(string identificacion)
        {
            BusquedaPlanDeEjercicioRespuesta respuesta = new BusquedaPlanDeEjercicioRespuesta();
            try
            {

                conexion.Open();
                respuesta.PlanDeEjercicio = repositorio.BuscarPorIdentificacion(identificacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.PlanDeEjercicio != null) ? "Se encontró el plan de ejercicio buscado" : "el plan de ejercicio buscada no existe";
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {

                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }
        public BusquedaPlanDeEjercicioRespuesta BuscarPorObjetivo(string objetivo)
        {
            BusquedaPlanDeEjercicioRespuesta respuesta = new BusquedaPlanDeEjercicioRespuesta();
            try
            {

                conexion.Open();
                respuesta.PlanDeEjercicio = repositorio.BuscarPorObjetivo(objetivo);
                conexion.Close();
                respuesta.Mensaje = (respuesta.PlanDeEjercicio != null) ? "Se encontró el plan de ejercicio buscado" : "el plan de ejercicio buscada no existe";
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {

                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }
        public ConteoPlanDeEjercicioRespuesta Totalizar()
        {
            ConteoPlanDeEjercicioRespuesta respuesta = new ConteoPlanDeEjercicioRespuesta();
            try
            {

                conexion.Open();
                respuesta.Cuenta = repositorio.Totalizar(); ;
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = "Se consultan los Datos";

                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }
        public ConteoPlanDeEjercicioRespuesta TotalizarTipo(string tipo)
        {
            ConteoPlanDeEjercicioRespuesta respuesta = new ConteoPlanDeEjercicioRespuesta();
            try
            {

                conexion.Open();
                respuesta.Cuenta = repositorio.TotalizarTipo(tipo);
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = "Se consultan los Datos";

                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }

        }
    }
    public class ConsultaPlanDeEjercicioRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<PlanDeEjercicio> PlanesDeEjercicios { get; set; }
    }
    public class BusquedaPlanDeEjercicioRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public PlanDeEjercicio PlanDeEjercicio { get; set; }
    }
    public class ConteoPlanDeEjercicioRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }
}
