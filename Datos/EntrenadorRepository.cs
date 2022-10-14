using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using Entidades;
using System.Data;

namespace Datos
{
    public class EntrenadorRepository
    {
        private readonly SqlConnection _connection;
        public EntrenadorRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar2(Entrenador entrenador)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Insert Into ENTRENADOR(Id, Tipo_De_Id, Codigo_Entrenador,Nombres, Apellidos, Fecha_De_Nacimiento, Edad, Sexo, Direccion_Domicilio, Correo, Salario, Horas_Extras_De_Trabajo, Dias_De_Trabajo, Meses_De_Contrato, Tipo_De_Contrato) " +
                    "Values (@Id, @Tipo_De_Id, @Codigo_Entrenador, @Nombres, @Apellidos, @Fecha_De_Nacimiento, @Edad, @Sexo, @Direccion_Domicilio, @Correo, @Salario, @Horas_Extras_De_Trabajo, @Dias_De_Trabajo, @Meses_De_Contrato, @Tipo_De_Contrato)";
                command.Parameters.AddWithValue("@Id", entrenador.Identificacion);
                command.Parameters.AddWithValue("@Tipo_De_Id", entrenador.TipoDeIdentificacion);
                command.Parameters.AddWithValue("@Codigo_Entrenador", entrenador.CodigoEntrenador);
                command.Parameters.AddWithValue("@Nombres", entrenador.Nombres);
                command.Parameters.AddWithValue("@Apellidos", entrenador.Apellidos);
                command.Parameters.AddWithValue("@Fecha_De_Nacimiento", entrenador.FechaDeNacimiento);
                command.Parameters.AddWithValue("@Edad", entrenador.Edad);
                command.Parameters.AddWithValue("@Sexo", entrenador.Sexo);
                command.Parameters.AddWithValue("@Direccion_Domicilio", entrenador.Direccion);
                command.Parameters.AddWithValue("@Correo", entrenador.CorreoElectronico);
                command.Parameters.AddWithValue("@Salario", entrenador.PagoDeSalario);
                command.Parameters.AddWithValue("@Horas_Extras_De_Trabajo", entrenador.HorasExtrasDeTrabajo);
                command.Parameters.AddWithValue("@Dias_De_Trabajo", entrenador.DiasDeTrabajo);
                command.Parameters.AddWithValue("@Meses_De_Contrato", entrenador.MesesDeContrato);
                command.Parameters.AddWithValue("@Tipo_De_Contrato", entrenador.TipoDeContrato);
                command.ExecuteNonQuery();

            }
        }
        public void Guardar(Entrenador entrenador)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into ENTRENADOR (Id, Tipo_De_Id, Codigo_Entrenador, Nombres, Apellidos, Fecha_De_Nacimiento, Edad, Sexo, Direccion_Domicilio, Correo, Salario, Horas_Extras_De_Trabajo, Dias_De_Trabajo, Meses_De_Contrato, Tipo_De_Contrato) 
                                        values (@Id, @Tipo_De_Id, @Codigo_Entrenador, @Nombres, @Apellidos, @Fecha_De_Nacimiento, @Edad, @Sexo, @Direccion_Domicilio, @Correo, @Salario, @Horas_Extras_De_Trabajo, @Dias_De_Trabajo, @Meses_De_Contrato, @Tipo_De_Contrato)";
                command.Parameters.AddWithValue("@Id", entrenador.Identificacion);
                command.Parameters.AddWithValue("@Tipo_De_Id", entrenador.TipoDeIdentificacion);
                command.Parameters.AddWithValue("@Codigo_Entrenador", entrenador.CodigoEntrenador);
                command.Parameters.AddWithValue("@Nombres", entrenador.Nombres);
                command.Parameters.AddWithValue("@Apellidos", entrenador.Apellidos);
                command.Parameters.AddWithValue("@Fecha_De_Nacimiento", entrenador.FechaDeNacimiento);
                command.Parameters.AddWithValue("@Edad", entrenador.Edad);
                command.Parameters.AddWithValue("@Sexo", entrenador.Sexo);
                command.Parameters.AddWithValue("@Direccion_Domicilio", entrenador.Direccion);
                command.Parameters.AddWithValue("@Correo", entrenador.CorreoElectronico);
                command.Parameters.AddWithValue("@Salario", entrenador.PagoDeSalario);
                command.Parameters.AddWithValue("@Horas_Extras_De_Trabajo", entrenador.HorasExtrasDeTrabajo);
                command.Parameters.AddWithValue("@Dias_De_Trabajo", entrenador.DiasDeTrabajo);
                command.Parameters.AddWithValue("@Meses_De_Contrato", entrenador.MesesDeContrato);
                command.Parameters.AddWithValue("@Tipo_De_Contrato", entrenador.TipoDeContrato);
                var filas = command.ExecuteNonQuery();
            }
        }
        public void Eliminar(Entrenador entrenador)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from ENTRENADOR where Id=@Id";
                command.Parameters.AddWithValue("@Id", entrenador.Identificacion);
                command.ExecuteNonQuery();
            }
        }
        public List<Entrenador> ConsultarTodos()
        {
            List<Entrenador> entrenadores = new List<Entrenador>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select Id, Tipo_De_Id, Codigo_Entrenador, Nombres, Apellidos, Fecha_De_Nacimiento, Edad, Sexo, Direccion_Domicilio, Correo, Salario, Horas_Extras_De_Trabajo, Dias_De_Trabajo, Meses_De_Contrato, Tipo_De_Contrato from ENTRENADOR ";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Entrenador entrenador = DataReaderMapToEntrenador(dataReader);
                        entrenadores.Add(entrenador);
                    }
                }
            }
            return entrenadores;
        }
        public Entrenador BuscarPorIdentificacion(string id)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from ENTRENADOR where Id=@Id";
                command.Parameters.AddWithValue("@Id", id);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToEntrenador(dataReader);
            }
        }
        public void Modificar(Entrenador entrenador)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update ENTRENADOR set Tipo_De_Id = @Tipo_De_Id, Nombres = @Nombres, Apellidos = @Apellidos, Fecha_De_Nacimiento = @Fecha_De_Nacimiento, Edad = @Edad, Sexo = @Sexo, Direccion_Domicilio = @Direccion_Domicilio, Correo = @Correo
                                        where Id=@Id";
                command.Parameters.AddWithValue("@Id", entrenador.Identificacion);
                command.Parameters.AddWithValue("@Tipo_De_Id", entrenador.TipoDeIdentificacion);
                command.Parameters.AddWithValue("@Nombres", entrenador.Nombres);
                command.Parameters.AddWithValue("@Apellidos", entrenador.Apellidos);
                command.Parameters.AddWithValue("@Fecha_De_Nacimiento", entrenador.FechaDeNacimiento);
                command.Parameters.AddWithValue("@Edad", entrenador.Edad);
                command.Parameters.AddWithValue("@Sexo", entrenador.Sexo);
                command.Parameters.AddWithValue("@Direccion_Domicilio", entrenador.Direccion);
                command.Parameters.AddWithValue("@Correo", entrenador.CorreoElectronico);
                var filas = command.ExecuteNonQuery();
            }
        }
        private Entrenador DataReaderMapToEntrenador(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Entrenador entrenador = new Entrenador();
            entrenador.Identificacion = (string)dataReader["Id"];
            entrenador.TipoDeIdentificacion = (string)dataReader["Tipo_De_Id"];
            entrenador.CodigoEntrenador = (string)dataReader["Codigo_Entrenador"];
            entrenador.Nombres = (string)dataReader["Nombres"];
            entrenador.Apellidos = (string)dataReader["Apellidos"];
            entrenador.FechaDeNacimiento = (DateTime)dataReader["Fecha_De_Nacimiento"];
            entrenador.Edad = (int)dataReader["Edad"];
            entrenador.Sexo = (string)dataReader["Sexo"];
            entrenador.Direccion = (string)dataReader["Direccion_Domicilio"];
            entrenador.CorreoElectronico = (string)dataReader["Correo"];
            entrenador.PagoDeSalario = (int)dataReader["Salario"];
            entrenador.HorasExtrasDeTrabajo = (int)dataReader["Horas_Extras_De_Trabajo"];
            entrenador.DiasDeTrabajo = (int)dataReader["Dias_De_Trabajo"];
            entrenador.MesesDeContrato = (int)dataReader["Meses_De_Contrato"];
            entrenador.TipoDeContrato = (string)dataReader["Tipo_De_Contrato"];
            return entrenador;
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
