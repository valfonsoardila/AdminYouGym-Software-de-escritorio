using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class AdministradorService
    {
        private readonly ConnectionManager conexion;
        private readonly AdministradorRepository repositorio;
        public AdministradorService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new AdministradorRepository(conexion);
        }
        public string Guardar(Administrador administrador)
        {
            try
            {
                administrador.CalcularEdad();
                conexion.Open();
                if (repositorio.BuscarPorIdentificacion(administrador.Identificacion) == null)
                {
                    repositorio.Guardar(administrador);
                    return $"Administrador registrado correctamente";
                }
                return $"Esta id de administrador ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConsultaAdministradorRespuesta ConsultarTodos()
        {
            ConsultaAdministradorRespuesta respuesta = new ConsultaAdministradorRespuesta();
            try
            {

                conexion.Open();
                respuesta.Administradors = repositorio.ConsultarTodos();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Administradors.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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
        public BusquedaAdministradorRespuesta BuscarPorIdentificacion(string identificacion)
        {
            BusquedaAdministradorRespuesta respuesta = new BusquedaAdministradorRespuesta();
            try
            {

                conexion.Open();
                respuesta.Administrador = repositorio.BuscarPorIdentificacion(identificacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Administrador != null) ? "Se encontró la id de administrador buscado" : "la id de administrador buscada no existe";
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
        public BusquedaAdministradorRespuesta BuscarPorRol(string rol)
        {
            BusquedaAdministradorRespuesta respuesta = new BusquedaAdministradorRespuesta();
            try
            {

                conexion.Open();
                respuesta.Administrador = repositorio.BuscarPorRol(rol);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Administrador != null) ? "Se encontró la id de administrador buscado" : "la id de administrador buscada no existe";
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
        public BusquedaAdministradorRespuesta BuscarPorNombreDeUsuario(string nombreDeUsuario)
        {
            BusquedaAdministradorRespuesta respuesta = new BusquedaAdministradorRespuesta();
            try
            {

                conexion.Open();
                respuesta.Administrador = repositorio.BuscarPorNombreDeUsuario(nombreDeUsuario);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Administrador != null) ? "Se encontró la id de administrador buscado" : "la id de administrador buscada no existe";
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
                var administrador = repositorio.BuscarPorIdentificacion(identificacion);
                if (administrador != null)
                {
                    repositorio.Eliminar(administrador);
                    conexion.Close();
                    return ($"El registro {administrador.Identificacion} se ha eliminado satisfactoriamente.");
                }
                return ($"Lo sentimos, {identificacion} no se encuentra registrada.");
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }
        public string Modificar(Administrador administradorNuevo)
        {
            try
            {
                administradorNuevo.CalcularEdad();
                conexion.Open();
                var cajaRegistradora = repositorio.BuscarPorIdentificacion(administradorNuevo.Identificacion);
                if (cajaRegistradora != null)
                {
                    repositorio.Modificar(administradorNuevo);
                    return ($"El registro de {administradorNuevo.Identificacion} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, el administrador con Id {administradorNuevo.Identificacion} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConteoAdministradorRespuesta Totalizar()
        {
            ConteoAdministradorRespuesta respuesta = new ConteoAdministradorRespuesta();
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
        public ConteoAdministradorRespuesta TotalizarTipoRol(string tipo)
        {
            ConteoAdministradorRespuesta respuesta = new ConteoAdministradorRespuesta();
            try
            {

                conexion.Open();
                respuesta.Cuenta = repositorio.TotalizarTipoRol(tipo);
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
        public ConteoAdministradorRespuesta TotalizarTipo(string tipo)
        {
            ConteoAdministradorRespuesta respuesta = new ConteoAdministradorRespuesta();
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
    public class ConsultaAdministradorRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Administrador> Administradors { get; set; }
    }
    public class BusquedaAdministradorRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Administrador Administrador { get; set; }
    }
    public class ConteoAdministradorRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }
}
