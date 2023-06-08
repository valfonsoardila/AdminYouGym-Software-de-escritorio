using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Logica
{
    public class EntrenadorService
    {
        private readonly ConnectionManager conexion;
        private readonly EntrenadorRepository repositorio;
        public EntrenadorService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new EntrenadorRepository(conexion);
        }
        public string Guardar(Entrenador entrenador)
        {
            try
            {
                entrenador.CalcularEdad();
                entrenador.GenerarCodigoEntrenador();
                conexion.Open();
                if (repositorio.BuscarPorIdentificacion(entrenador.Identificacion) == null)
                {
                    repositorio.Guardar(entrenador);
                    return $"Entrenador registrado correctamente";
                }
                return $"El entrenador ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConsultaEntrenadorRespuesta ConsultarTodos()
        {
            ConsultaEntrenadorRespuesta respuesta = new ConsultaEntrenadorRespuesta();
            try
            {

                conexion.Open();
                respuesta.Entrenadores = repositorio.ConsultarTodos();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Entrenadores.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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
                var entrenador = repositorio.BuscarPorIdentificacion(identificacion);
                if (entrenador != null)
                {
                    repositorio.Eliminar(entrenador);
                    conexion.Close();
                    return ($"El registro {entrenador.Nombres} se ha eliminado satisfactoriamente.");
                }
                return ($"Lo sentimos, {identificacion} no se encuentra registrada.");
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }
        public string Modificar(Entrenador entrenadorNuevo)
        {
            try
            {
                entrenadorNuevo.CalcularSalario();
                entrenadorNuevo.CalcularEdad();
                conexion.Open();
                var entrenadorAntiguo = repositorio.BuscarPorIdentificacion(entrenadorNuevo.Identificacion);
                
                if (entrenadorAntiguo != null)
                {
                    repositorio.Modificar(entrenadorNuevo);
                    return ($"El registro de {entrenadorNuevo.Nombres} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, el entrenador con Identificación {entrenadorNuevo.Identificacion} no se encuentra registrado.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public string ModificarDatosContrato(Entrenador entrenadorNuevo)
        {
            try
            {
                entrenadorNuevo.CalcularSalario();
                entrenadorNuevo.CalcularEdad();
                conexion.Open();
                var entrenadorAntiguo = repositorio.BuscarPorIdentificacion(entrenadorNuevo.Identificacion);

                if (entrenadorAntiguo != null)
                {
                    repositorio.ModificarDatosContrato(entrenadorNuevo);
                    return ($"El registro de {entrenadorNuevo.Nombres} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, el entrenador con Identificación {entrenadorNuevo.Identificacion} no se encuentra registrado.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public BusquedaEntrenadorRespuesta BuscarPorSexo(string sexo)
        {
            BusquedaEntrenadorRespuesta respuesta = new BusquedaEntrenadorRespuesta();
            try
            {

                conexion.Open();
                respuesta.Entrenador = repositorio.BuscarPorSexo(sexo);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Entrenador != null) ? "Se encontró el entrenador buscado" : "el entrenador buscada no existe";
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion aqui: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }
        public BusquedaEntrenadorRespuesta BuscarPorIdentificacion(string id)
        {
            BusquedaEntrenadorRespuesta respuesta = new BusquedaEntrenadorRespuesta();
            try
            {

                conexion.Open();
                respuesta.Entrenador = repositorio.BuscarPorIdentificacion(id);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Entrenador != null) ? "Se encontró el entrenador buscado" : "el entrenador buscada no existe";
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion aqui: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }
        public ConteoEntrenadorRespuesta Totalizar()
        {
            ConteoEntrenadorRespuesta respuesta = new ConteoEntrenadorRespuesta();
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
        public ConteoEntrenadorRespuesta TotalizarTipo(string tipo)
        {
            ConteoEntrenadorRespuesta respuesta = new ConteoEntrenadorRespuesta();
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

    public class ConsultaEntrenadorRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Entrenador> Entrenadores { get; set; }
    }
    public class BusquedaEntrenadorRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Entrenador Entrenador { get; set; }
    }
    public class ConteoEntrenadorRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }
}
