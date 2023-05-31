using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AdministradorRepository
    {
        private readonly SqlConnection _connection;
        public AdministradorRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar(Administrador administrador)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into ADMINISTRADOR (Id, Tipo_De_Id, ImagenPerfil, Nombres, Apellidos, Fecha_De_Nacimiento, Edad, Sexo, Direccion_Domicilio, Telefono, Rol, Correo) 
                                        values (@Id, @Tipo_De_Id, @ImagenPerfil, @Nombres, @Apellidos, @Fecha_De_Nacimiento, @Edad, @Sexo, @Direccion_Domicilio, @Telefono, @Rol, @Correo)";
                command.Parameters.AddWithValue("@Id", administrador.Identificacion);
                command.Parameters.AddWithValue("@Tipo_De_Id", administrador.TipoDeIdentificacion);
                command.Parameters.AddWithValue("@ImagenPerfil", administrador.ImagenPerfil);
                command.Parameters.AddWithValue("@Nombres", administrador.Nombres);
                command.Parameters.AddWithValue("@Apellidos", administrador.Apellidos);
                command.Parameters.AddWithValue("@Fecha_De_Nacimiento", administrador.FechaDeNacimiento);
                command.Parameters.AddWithValue("@Edad", administrador.Edad);
                command.Parameters.AddWithValue("@Sexo", administrador.Sexo);
                command.Parameters.AddWithValue("@Direccion_Domicilio", administrador.Direccion);
                command.Parameters.AddWithValue("@Telefono", administrador.Telefono);
                command.Parameters.AddWithValue("@Rol", administrador.Rol);
                command.Parameters.AddWithValue("@Correo", administrador.CorreoElectronico);
                var filas = command.ExecuteNonQuery();
            }
        }
        public Administrador BuscarPorIdentificacion(string identificacion)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from ADMINISTRADOR where Id=@Id";
                command.Parameters.AddWithValue("@Id", identificacion);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToAdministrador(dataReader);
            }
        }
        public Administrador BuscarPorRol(string rol)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from ADMINISTRADOR where Rol=@Rol";
                command.Parameters.AddWithValue("@Rol", rol);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToAdministrador(dataReader);
            }
        }
        public Administrador BuscarPorNombreDeUsuario(string nombreDeUsuario)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from ADMINISTRADOR where Nombres=@Nombres";
                command.Parameters.AddWithValue("@Nombres", nombreDeUsuario);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToAdministrador(dataReader);
            }
        }
        public void Modificar(Administrador administrador)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update ADMINISTRADOR set Tipo_De_Id=@Tipo_De_Id, ImagenPerfil=@ImagenPerfil, Nombres=@Nombres, Apellidos=@Apellidos, Fecha_De_Nacimiento=@Fecha_De_Nacimiento, Edad=@Edad, Sexo=@Sexo, Direccion_Domicilio=@Direccion_Domicilio, Telefono=@Telefono, Rol=@Rol, Correo=@Correo
                                        where Id=@Id";
                command.Parameters.AddWithValue("@Id", administrador.Identificacion);
                command.Parameters.AddWithValue("@Tipo_De_Id", administrador.TipoDeIdentificacion);
                command.Parameters.AddWithValue("@ImagenPerfil", administrador.ImagenPerfil);
                command.Parameters.AddWithValue("@Nombres", administrador.Nombres);
                command.Parameters.AddWithValue("@Apellidos", administrador.Apellidos);
                command.Parameters.AddWithValue("@Fecha_De_Nacimiento", administrador.FechaDeNacimiento);
                command.Parameters.AddWithValue("@Edad", administrador.Edad);
                command.Parameters.AddWithValue("@Sexo", administrador.Sexo);
                command.Parameters.AddWithValue("@Direccion_Domicilio", administrador.Direccion);
                command.Parameters.AddWithValue("@Telefono", administrador.Telefono);
                command.Parameters.AddWithValue("@Rol", administrador.Rol);
                command.Parameters.AddWithValue("@Correo", administrador.CorreoElectronico);
                var filas = command.ExecuteNonQuery();
            }
        }
        public List<Administrador> ConsultarTodos()
        {
            List<Administrador> administradors = new List<Administrador>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select Id, Tipo_De_Id, ImagenPerfil, Nombres, Apellidos, Fecha_De_Nacimiento, Edad, Sexo, Direccion_Domicilio, Telefono, Rol, Correo from ADMINISTRADOR";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Administrador administrador = DataReaderMapToAdministrador(dataReader);
                        administradors.Add(administrador);
                    }
                }
            }
            return administradors;
        }
        public void Eliminar(Administrador administrador)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from ADMINISTRADOR where Id=@Id";
                command.Parameters.AddWithValue("@Id", administrador.Identificacion);
                command.ExecuteNonQuery();
            }
        }
        private Administrador DataReaderMapToAdministrador(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Administrador administrador = new Administrador();
            administrador.Identificacion = (string)dataReader["Id"];
            administrador.TipoDeIdentificacion = (string)dataReader["Tipo_De_Id"];
            administrador.ImagenPerfil = (byte[])dataReader["ImagenPerfil"];
            administrador.Nombres = (string)dataReader["Nombres"];
            administrador.Apellidos = (string)dataReader["Apellidos"];
            administrador.FechaDeNacimiento = (DateTime)dataReader["Fecha_De_Nacimiento"];
            administrador.Edad = (int)dataReader["Edad"];
            administrador.Sexo = (string)dataReader["Sexo"];
            administrador.Direccion = (string)dataReader["Direccion_Domicilio"];
            administrador.Telefono = (string)dataReader["Telefono"];
            administrador.Rol = (string)dataReader["Rol"];
            administrador.CorreoElectronico = (string)dataReader["Correo"];
            return administrador;
        }
        public int Totalizar()
        {
            return ConsultarTodos().Count();
        }
        public int TotalizarTipoRol(string tipo)
        {
            return ConsultarTodos().Where(p => p.Rol.Equals(tipo)).Count();
        }
        public int TotalizarTipo(string tipo)
        {
            return ConsultarTodos().Where(p => p.Sexo.Equals(tipo)).Count();
        }
    }
}
