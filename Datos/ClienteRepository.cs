using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using System.Data;

namespace Datos
{
    public class ClienteRepository
    {
        private readonly SqlConnection _connection;
        public ClienteRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar2(Cliente cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Insert Into CLIENTE(Id, Tipo_De_Id, Codigo_Cliente, Nombres, Apellidos, Fecha_De_Nacimiento, Edad, Sexo, Peso, Altura, Direccion_Domicilio, Telefono, Correo, ClasificacionPorPeso, IndMC, IndGC, IndMM, IndMO, IndMR) " +
                    "Values (@Id, @Tipo_De_Id, @Codigo_Cliente, @Nombres, @Apellidos, @Fecha_De_Nacimiento, @Edad, @Sexo, @Peso, @Altura, @Direccion_Domicilio, @Telefono, @Correo, @Clasificacion_Por_Peso, @IndMC, @IndGC, @IndMM, @IndMO, @IndMR)";
                //command.Parameters.Add("@Id", SqlDbType.VarChar).Value = persona.Identificacion;
                command.Parameters.AddWithValue("@Id", cliente.Identificacion);
                command.Parameters.AddWithValue("@Tipo_De_Id", cliente.TipoDeIdentificacion);
                command.Parameters.AddWithValue("@Codigo_Cliente", cliente.CodigoCliente);
                command.Parameters.AddWithValue("@Nombres", cliente.Nombres);
                command.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                command.Parameters.AddWithValue("@Fecha_De_Nacimiento", cliente.FechaDeNacimiento);
                command.Parameters.AddWithValue("@Edad", cliente.Edad);
                command.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                command.Parameters.AddWithValue("@Peso", cliente.Peso);
                command.Parameters.AddWithValue("@Altura", cliente.Altura);
                command.Parameters.AddWithValue("@Direccion_Domicilio", cliente.Direccion);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@Correo", cliente.CorreoElectronico);
                command.Parameters.AddWithValue("@Clasificacion_Por_Peso", cliente.ClasificacionPorPeso);
                command.Parameters.AddWithValue("@IndMC", cliente.IndiceDeMasaCorporal);
                command.Parameters.AddWithValue("@IndGC", cliente.IndiceDeGrasaCorporal);
                command.Parameters.AddWithValue("@IndMM", cliente.IndiceDeMasaMuscular);
                command.Parameters.AddWithValue("@IndMO", cliente.IndiceDeMasaOsea);
                command.Parameters.AddWithValue("@IndMR", cliente.IndiceDeMasaResidual);
                command.ExecuteNonQuery();

            }
        }
        public void Guardar(Cliente cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into CLIENTE (Id, Tipo_De_Id, Codigo_Cliente, Nombres, Apellidos, Fecha_De_Nacimiento, Edad, Sexo, Peso, Altura, Direccion_Domicilio, Telefono, Correo, Clasificacion_Por_Peso, IndMC, IndGC, IndMM, IndMO, IndMR) 
                                        values (@Id, @Tipo_De_Id, @Codigo_Cliente, @Nombres, @Apellidos, @Fecha_De_Nacimiento, @Edad, @Sexo, @Peso, @Altura, @Direccion_Domicilio, @Telefono, @Correo, @Clasificacion_Por_Peso, @IndMC, @IndGC, @IndMM, @IndMO, @IndMR)";
                command.Parameters.AddWithValue("@Id", cliente.Identificacion);
                command.Parameters.AddWithValue("@Tipo_De_Id", cliente.TipoDeIdentificacion);
                command.Parameters.AddWithValue("@Codigo_Cliente", cliente.CodigoCliente);
                command.Parameters.AddWithValue("@Nombres", cliente.Nombres);
                command.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                command.Parameters.AddWithValue("@Fecha_De_Nacimiento", cliente.FechaDeNacimiento);
                command.Parameters.AddWithValue("@Edad", cliente.Edad);
                command.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                command.Parameters.AddWithValue("@Peso", cliente.Peso);
                command.Parameters.AddWithValue("@Altura", cliente.Altura);
                command.Parameters.AddWithValue("@Direccion_Domicilio", cliente.Direccion);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@Correo", cliente.CorreoElectronico);
                command.Parameters.AddWithValue("@Clasificacion_Por_Peso", cliente.ClasificacionPorPeso);
                command.Parameters.AddWithValue("@IndMC", cliente.IndiceDeMasaCorporal);
                command.Parameters.AddWithValue("@IndGC", cliente.IndiceDeGrasaCorporal);
                command.Parameters.AddWithValue("@IndMM", cliente.IndiceDeMasaMuscular);
                command.Parameters.AddWithValue("@IndMO", cliente.IndiceDeMasaOsea);
                command.Parameters.AddWithValue("@IndMR", cliente.IndiceDeMasaResidual);
                var filas = command.ExecuteNonQuery();
            }
        }
        public void Eliminar(Cliente cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from CLIENTE where Id=@Id";
                command.Parameters.AddWithValue("@Id", cliente.Identificacion);
                command.ExecuteNonQuery();
            }
        }
        public List<Cliente> ConsultarTodos()
        {
            List<Cliente> clientes = new List<Cliente>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select Id, Tipo_De_Id, Codigo_Cliente, Nombres, Apellidos, Fecha_De_Nacimiento, Edad, Sexo, Peso, Altura, Direccion_Domicilio, Telefono, Correo, Clasificacion_Por_Peso, IndMC, IndGC, IndMM, IndMO, IndMR from CLIENTE ";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Cliente cliente = DataReaderMapToCliente(dataReader);
                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
        }
        public Cliente BuscarPorIdentificacion(string id)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from CLIENTE where Id=@Id";
                command.Parameters.AddWithValue("@Id", id);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToCliente(dataReader);
            }
        }
        public void Modificar(Cliente cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update CLIENTE set Tipo_De_Id=@Tipo_De_Id, Nombres=@Nombres, Apellidos=@Apellidos, Fecha_De_Nacimiento=@Fecha_De_Nacimiento, Edad=@Edad, Sexo=@Sexo, Peso=@Peso, Altura=@Altura, Direccion_Domicilio=@Direccion_Domicilio, Telefono=@Telefono, Correo=@Correo, Clasificacion_Por_Peso = @Clasificacion_Por_Peso, IndMC=@IndMC, IndGC=@IndGC, IndMM=@IndMM, IndMO=@IndMO, IndMR=@IndMR
                                        where Id=@Id";
                command.Parameters.AddWithValue("@Id", cliente.Identificacion);
                command.Parameters.AddWithValue("@Tipo_De_Id", cliente.TipoDeIdentificacion);
                command.Parameters.AddWithValue("@Nombres", cliente.Nombres);
                command.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                command.Parameters.AddWithValue("@Fecha_De_Nacimiento", cliente.FechaDeNacimiento);
                command.Parameters.AddWithValue("@Edad", cliente.Edad);
                command.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                command.Parameters.AddWithValue("@Peso", cliente.Peso);
                command.Parameters.AddWithValue("@Altura", cliente.Altura);
                command.Parameters.AddWithValue("@Direccion_Domicilio", cliente.Direccion);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@Correo", cliente.CorreoElectronico);
                command.Parameters.AddWithValue("@Clasificacion_Por_Peso", cliente.ClasificacionPorPeso);
                command.Parameters.AddWithValue("@IndMC", cliente.IndiceDeMasaCorporal);
                command.Parameters.AddWithValue("@IndGC", cliente.IndiceDeGrasaCorporal);
                command.Parameters.AddWithValue("@IndMM", cliente.IndiceDeMasaMuscular);
                command.Parameters.AddWithValue("@IndMO", cliente.IndiceDeMasaOsea);
                command.Parameters.AddWithValue("@IndMR", cliente.IndiceDeMasaResidual);
                var filas = command.ExecuteNonQuery();
            }
        }
        private Cliente DataReaderMapToCliente(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Cliente cliente = new Cliente();

            cliente.Identificacion = (string)dataReader["Id"];
            cliente.TipoDeIdentificacion = (string)dataReader["Tipo_De_Id"];
            cliente.CodigoCliente = (string)dataReader["Codigo_Cliente"];
            cliente.Nombres = (string)dataReader["Nombres"];
            cliente.Apellidos = (string)dataReader["Apellidos"];
            cliente.FechaDeNacimiento = (DateTime)dataReader["Fecha_De_Nacimiento"];
            cliente.Edad = (int)dataReader["Edad"];
            cliente.Sexo = (string)dataReader["Sexo"];
            cliente.Peso = (double)dataReader["Peso"];
            cliente.Altura = (double)dataReader["Altura"];
            cliente.Direccion = (string)dataReader["Direccion_Domicilio"];
            cliente.Telefono = (string)dataReader["Telefono"];
            cliente.CorreoElectronico = (string)dataReader["Correo"];
            cliente.ClasificacionPorPeso = (string)dataReader["Clasificacion_Por_Peso"];
            cliente.IndiceDeMasaCorporal = (double)dataReader["IndMC"];
            cliente.IndiceDeGrasaCorporal = (double)dataReader["IndGC"];
            cliente.IndiceDeMasaMuscular = (double)dataReader["IndMM"];
            cliente.IndiceDeMasaOsea = (double)dataReader["IndMO"];
            cliente.IndiceDeMasaResidual = (double)dataReader["IndMR"];
            return cliente;
        }
        public int Totalizar()
        {
            return ConsultarTodos().Count();
        }
        public int TotalizarTipo(string tipo)
        {
            return ConsultarTodos().Where(p => p.Sexo.Equals(tipo)).Count();
        }
    }
}
