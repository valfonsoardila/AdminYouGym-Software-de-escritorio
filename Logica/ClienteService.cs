using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Data;

namespace Logica
{
    public class ClienteService
    {
        private readonly ConnectionManager conexion;
        private readonly ClienteRepository repositorio;
        public ClienteService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new ClienteRepository(conexion);
        }

        public ClienteService()
        {
        }

        //<Validaciones por mensajes de botones de los formularios>
        public string ValidarIndiceMasaCorporal(Cliente cliente)
        {
            try
            {
                if (cliente.Peso == 0 || cliente.Peso == ' ' && cliente.Altura == 0 || cliente.Altura == ' ')
                {
                    cliente.IndiceDeMasaCorporal = 0;
                    return $"No ha llenado los valores del peso y la altura del cliente";
                }
                else
                {
                    if (cliente.Peso == 0 || cliente.Peso == ' ')
                    {
                        return $"No ha llenado el valor del peso del cliente";
                    }
                    else
                    {
                        if (cliente.Altura == 0 || cliente.Altura == ' ')
                        {
                            return $"No ha llenado el valor de la altura del cliente";
                        }
                    }
                }
                return $"Indice de masa corporal calculada satisfactoriamente";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public string ValidarIndiceMasaOsea(Cliente cliente)
        {
            try
            {
                if (cliente.Peso != 0 || cliente.Peso != ' ')
                {
                    return $"Indice de Masa Osea(Indice MO) calculada satisfactoriamente";
                }
                return $"Aun no ha llenado el campo de peso(Kg) de cliente, por favor ingrese su peso";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public string ValidarIndiceGrasaMuscular(Cliente cliente)
        {
            try
            {
                if (cliente.Sexo == " ")
                {
                    return $"¡No ha seleccionado una opcion en el campo sexo!";
                }
                else
                {
                    if (cliente.IndiceDeMasaCorporal == 0 || cliente.IndiceDeMasaCorporal == ' ')
                    {
                        return $"¡No ha calculado el indice de Masa Corporal(Indice MC)!";
                    }
                    else
                    {
                        if (cliente.Edad == 0)
                        {
                            return $"¡Aun no ha calculado la edad!";
                        }
                    }
                }
                return $"Indice de Grasa Muscular(Indice GM) calculado satisfactoriamente";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public string ValidarIndiceMasaMuscular(Cliente cliente)
        {
            try
            {
                if (cliente.Peso != 0 || cliente.Peso != ' ')
                {
                    return $"Aun no ha digitado un peso para el cliente";
                }
                else
                {
                    if (cliente.IndiceDeGrasaCorporal == 0 || cliente.IndiceDeGrasaCorporal == ' ')
                    {
                        return $"¡No ha calculado el indice de Masa Corporal(Indice MC)!";
                    }
                    else
                    {
                        if (cliente.IndiceDeMasaOsea == 0 || cliente.IndiceDeMasaOsea == ' ')
                        {
                            return $"¡No ha calculado el indice de Masa Osea(Indice MO)!";
                        }
                        else
                        {
                            if (cliente.IndiceDeMasaResidual == 0 || cliente.IndiceDeMasaResidual == ' ')
                            {
                                return $"¡No ha calculado el indice de Masa Residual(Indice MR)!";
                            }
                        }
                    }
                }
                return $"Indice de Masa Muscular(Indice MM) calculado satisfactoriamente";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public string ValidarIndiceMasaResidual(Cliente cliente)
        {
            try
            {
                if (cliente.Sexo == " ")
                {
                    return $"¡No ha seleccionado una opcion en el campo sexo!";
                }
                else
                {
                    if (cliente.Peso == 0 || cliente.Peso == ' ')
                    {
                        return $"Aun no ha digitado el peso para el cliente";
                    }
                }
                return $"Indice de Masa Residual(Indice MR) calculado satisfactoriamente";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        //</Validaciones por mensajes de botones de los formularios>
        public string Guardar(Cliente cliente)
        {
            try
            {
                cliente.GenerarCodigoCliente();
                cliente.CalcularEdad();
                cliente.ObtenerIndiceMasaCorporal();
                cliente.ObtenerIndiceGrasaMuscular();
                cliente.ObtenerIndiceMasaResidual();
                cliente.ObtenerIndiceMasaOsea();
                cliente.ObtenerIndiceMasaMuscular();
                conexion.Open();
                if (repositorio.BuscarPorIdentificacion(cliente.Identificacion) == null)
                {
                    repositorio.Guardar(cliente);
                    return $"Se guardaron los datos satisfactoriamente";
                }
                return $"El cliente ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConsultaClienteRespuesta ConsultarTodos()
        {
            ConsultaClienteRespuesta respuesta = new ConsultaClienteRespuesta();
            try
            {

                conexion.Open();
                respuesta.Clientes = repositorio.ConsultarTodos();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Clientes.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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
                var cliente = repositorio.BuscarPorIdentificacion(identificacion);
                if (cliente != null)
                {
                    repositorio.Eliminar(cliente);
                    conexion.Close();
                    return ($"El registro {cliente.Nombres} se ha eliminado satisfactoriamente.");
                }
                return ($"Lo sentimos, {identificacion} no se encuentra registrada.");
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }
        public string Modificar(Cliente clienteNuevo)
        {
            try
            {
                clienteNuevo.CalcularEdad();
                clienteNuevo.ObtenerIndiceMasaCorporal();
                clienteNuevo.ObtenerIndiceGrasaMuscular();
                clienteNuevo.ObtenerIndiceMasaResidual();
                clienteNuevo.ObtenerIndiceMasaOsea();
                clienteNuevo.ObtenerIndiceMasaMuscular();
                
                conexion.Open();
                var clienteAntiguo = repositorio.BuscarPorIdentificacion(clienteNuevo.Identificacion);

                if (clienteAntiguo != null)
                {
                    repositorio.Modificar(clienteNuevo);
                    return $"El registro de {clienteNuevo.Nombres} se ha modificado satisfactoriamente.";
                }
                else
                {
                    return $"Lo sentimos, el cliente con Identificación {clienteNuevo.Identificacion} no se encuentra registrado.";
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public BusquedaClienteRespuesta BuscarPorIdentificacion(string identificacion)
        {
            BusquedaClienteRespuesta respuesta = new BusquedaClienteRespuesta();
            try
            {
                conexion.Open();
                respuesta.Cliente = repositorio.BuscarPorIdentificacion(identificacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Cliente != null) ? "Se encontró el cliente buscado" : "el cliente buscada no existe";
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
        public ConteoClienteRespuesta Totalizar()
        {
            ConteoClienteRespuesta respuesta = new ConteoClienteRespuesta();
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
        public ConteoClienteRespuesta TotalizarTipo(string tipo)
        {
            ConteoClienteRespuesta respuesta = new ConteoClienteRespuesta();
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
    public class ConsultaClienteRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Cliente> Clientes { get; set; }
    }
    public class BusquedaClienteRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Cliente Cliente { get; set; }
    }
    public class ConteoClienteRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }
}
