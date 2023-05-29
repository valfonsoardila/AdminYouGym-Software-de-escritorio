using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Logica
{
    public class GimnasioService
    {
        private readonly ConnectionManager conexion;
        private readonly GimnasioRepository repositorio;
        public GimnasioService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new GimnasioRepository(conexion);
        }
        public string Guardar(Gimnasio drogueria)
        {
            try
            {
                drogueria.GenerarIdGimnasio();
                conexion.Open();
                if (repositorio.BuscarPorId(drogueria.NIT) == null)
                {
                    repositorio.Guardar(drogueria);
                    return $"Gimnasio registrada correctamente";
                }
                return $"Esta id de drogueria ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConsultaGimnasioRespuesta ConsultarTodos()
        {
            ConsultaGimnasioRespuesta respuesta = new ConsultaGimnasioRespuesta();
            try
            {

                conexion.Open();
                respuesta.Gimnasios = repositorio.ConsultarTodos();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Gimnasios.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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
        public string Modificar(Gimnasio drogueriaNueva)
        {
            try
            {
                conexion.Open();
                var drogueriaAntigua = repositorio.BuscarPorId(drogueriaNueva.IdGimnasio);
                if (drogueriaAntigua != null)
                {
                    repositorio.Modificar(drogueriaNueva);
                    return ($"El registro de {drogueriaNueva.NIT} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, la drogueria con Id {drogueriaNueva.NIT} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public BusquedaGimnasioRespuesta BuscarPorId(string nit)
        {
            BusquedaGimnasioRespuesta respuesta = new BusquedaGimnasioRespuesta();
            try
            {

                conexion.Open();
                respuesta.Gimnasio = repositorio.BuscarPorId(nit);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Gimnasio != null) ? "Se encontró la id de drogueria buscada" : "la id de drogueria buscada no existe";
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
        public string Eliminar(string id)
        {
            try
            {
                conexion.Open();
                var drogueria = repositorio.BuscarPorId(id);
                if (drogueria != null)
                {
                    repositorio.Eliminar(drogueria);
                    conexion.Close();
                    return ($"El registro {drogueria.IdGimnasio} se ha eliminado satisfactoriamente.");
                }
                return ($"Lo sentimos, {id} no se encuentra registrada.");
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConteoProductoRespuesta Totalizar()
        {
            ConteoProductoRespuesta respuesta = new ConteoProductoRespuesta();
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
        public ConteoProductoRespuesta TotalizarTipo(string tipo)
        {
            ConteoProductoRespuesta respuesta = new ConteoProductoRespuesta();
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
    public class ConsultaGimnasioRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Gimnasio> Gimnasios { get; set; }
    }
    public class BusquedaGimnasioRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Gimnasio Gimnasio { get; set; }
    }
    public class ConteoGimnasioRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }
}
