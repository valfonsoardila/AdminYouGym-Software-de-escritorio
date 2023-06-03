using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class MembresiaService
    {
        private readonly ConnectionManager conexion;
        private readonly MembresiaRepository repositorio;
        public MembresiaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new MembresiaRepository(conexion);
        }
        public string Guardar(Membresia membresia)
        {
            try
            {
                membresia.ObtenerPizarraMiembro();
                conexion.Open();
                if (repositorio.BuscarPorIdentificacion(membresia.CodigoMiembro) == null)
                {
                    repositorio.Guardar(membresia);
                    return $"Membresia registrada correctamente";
                }
                return $"Esta id de membresia ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConsultaMembresiaRespuesta ConsultarTodos()
        {
            ConsultaMembresiaRespuesta respuesta = new ConsultaMembresiaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Membresias = repositorio.ConsultarTodos();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Membresias.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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
        public BusquedaMembresiaRespuesta BuscarPorIdentificacion(string identificacion)
        {
            BusquedaMembresiaRespuesta respuesta = new BusquedaMembresiaRespuesta();
            try
            {
                conexion.Open();
                respuesta.Membresia = repositorio.BuscarPorIdentificacion(identificacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Membresia != null) ? "Se encontró la id de membresia buscado" : "la id de membresia buscada no existe";
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
        public BusquedaMembresiaRespuesta BuscarPorCategoria(string categoria)
        {
            BusquedaMembresiaRespuesta respuesta = new BusquedaMembresiaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Membresia = repositorio.BuscarPorCategoria(categoria);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Membresia != null) ? "Se encontró la id de membresia buscado" : "la id de membresia buscada no existe";
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
        public BusquedaMembresiaRespuesta BuscarPorNombre(string nombre)
        {
            BusquedaMembresiaRespuesta respuesta = new BusquedaMembresiaRespuesta();
            try
            {
                conexion.Open();
                respuesta.Membresia = repositorio.BuscarPorNombre(nombre);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Membresia != null) ? "Se encontró la id de membresia buscado" : "la id de membresia buscada no existe";
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
        public string Eliminar(string identificacion)
        {
            try
            {
                conexion.Open();
                var membresia = repositorio.BuscarPorIdentificacion(identificacion);
                if (membresia != null)
                {
                    repositorio.Eliminar(membresia);
                    conexion.Close();
                    return ($"El registro {membresia.CodigoMiembro} se ha eliminado satisfactoriamente.");
                }
                return ($"Lo sentimos, {identificacion} no se encuentra registrada.");
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }
        public string Modificar(Membresia membresiaNuevo)
        {
            try
            {
                membresiaNuevo.ObtenerPizarraMiembro();
                conexion.Open();
                var cajaRegistradora = repositorio.BuscarPorIdentificacion(membresiaNuevo.CodigoMiembro);
                if (cajaRegistradora != null)
                {
                    repositorio.Modificar(membresiaNuevo);
                    return ($"El registro de {membresiaNuevo.CodigoMiembro} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, el membresia con Id {membresiaNuevo.CodigoMiembro} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConteoMembresiaRespuesta Totalizar()
        {
            ConteoMembresiaRespuesta respuesta = new ConteoMembresiaRespuesta();
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
        public ConteoMembresiaRespuesta TotalizarTipoCategoria(string categoria)
        {
            ConteoMembresiaRespuesta respuesta = new ConteoMembresiaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Cuenta = repositorio.TotalizarTipoCategoria(categoria);
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
        public ConteoMembresiaRespuesta TotalizarTipoEstado(string estado)
        {
            ConteoMembresiaRespuesta respuesta = new ConteoMembresiaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Cuenta = repositorio.TotalizarTipoEstado(estado);
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
    public class ConsultaMembresiaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Membresia> Membresias { get; set; }
    }
    public class BusquedaMembresiaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Membresia Membresia { get; set; }
    }
    public class ConteoMembresiaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }
}
