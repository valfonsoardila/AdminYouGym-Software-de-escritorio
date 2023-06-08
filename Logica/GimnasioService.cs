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
        public string Guardar(Gimnasio gimnasio)
        {
            try
            {
                gimnasio.GenerarIdGimnasio();
                conexion.Open();
                if (repositorio.BuscarPorId(gimnasio.NIT) == null)
                {
                    repositorio.Guardar(gimnasio);
                    return $"Gimnasio registrado correctamente";
                }
                return $"Esta id de gimnasio ya existe";
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
        public string Modificar(Gimnasio gimnasioNueva)
        {
            try
            {
                conexion.Open();
                var gimnasioAntigua = repositorio.BuscarPorId(gimnasioNueva.IdGimnasio);
                if (gimnasioAntigua != null)
                {
                    repositorio.Modificar(gimnasioNueva);
                    return ($"El registro de {gimnasioNueva.NIT} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, la gimnasio con Id {gimnasioNueva.NIT} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public BusquedaGimnasioRespuesta BuscarPorId(string id)
        {
            BusquedaGimnasioRespuesta respuesta = new BusquedaGimnasioRespuesta();
            try
            {

                conexion.Open();
                respuesta.Gimnasio = repositorio.BuscarPorId(id);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Gimnasio != null) ? "Se encontró la id de gimnasio buscada" : "la id de gimnasio buscada no existe";
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
                var gimnasio = repositorio.BuscarPorId(id);
                if (gimnasio != null)
                {
                    repositorio.Eliminar(gimnasio);
                    conexion.Close();
                    return ($"El registro {gimnasio.IdGimnasio} se ha eliminado satisfactoriamente.");
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
