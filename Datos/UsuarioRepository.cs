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
    public class UsuarioRepository
    {
        private readonly SqlConnection _connection;
        public UsuarioRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar(Usuario usuario)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into USUARIO (CodigoUsuario, ImagenPerfil, Nombres, Apellidos, Rol, Correo, NombreUsuario, Contraseña) 
                                        values (@CodigoUsuario, @ImagenPerfil, @Nombres, @Apellidos, @Rol, @Correo, @NombreUsuario, @Contraseña)";
                command.Parameters.AddWithValue("@CodigoUsuario", usuario.CodigoUsuario);
                command.Parameters.AddWithValue("@ImagenPerfil", usuario.ImagenPerfil);
                command.Parameters.AddWithValue("@Nombres", usuario.Nombres);
                command.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
                command.Parameters.AddWithValue("@Correo", usuario.CorreoElectronico);
                command.Parameters.AddWithValue("@Rol", usuario.Rol);
                command.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                var filas = command.ExecuteNonQuery();
            }
        }
        public List<Usuario> BuscarPorRol(string rol)
        {
            List<Usuario> Usuarios = new List<Usuario>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from USUARIO where Rol=@Rol";
                command.Parameters.AddWithValue("@Rol", rol);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Usuario Usuario = DataReaderMapToUsuario(dataReader);
                        Usuarios.Add(Usuario);
                    }
                }
            }
            return Usuarios;
        }
        public Usuario BuscarPorIdentificacion(string identificacion)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from USUARIO where CodigoUsuario=@CodigoUsuario";
                command.Parameters.AddWithValue("@CodigoUsuario", identificacion);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToUsuario(dataReader);
            }
        }
        public Usuario BuscarPorNombreDeUsuario(string nombreDeUsuario)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from USUARIO where NombreUsuario=@NombreUsuario";
                command.Parameters.AddWithValue("@NombreUsuario", nombreDeUsuario);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToUsuario(dataReader);
            }
        }
        public void Modificar(Usuario Usuario)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update USUARIO set ImagenPerfil=@ImagenPerfil, Nombres=@Nombres, Apellidos=@Apellidos, Rol=@Rol, Correo=@Correo, NombreUsuario=@NombreUsuario, Contraseña=@Contraseña
                                        where CodigoUsuario=@CodigoUsuario";
                command.Parameters.AddWithValue("@CodigoUsuario", Usuario.CodigoUsuario);
                command.Parameters.AddWithValue("@ImagenPerfil", Usuario.ImagenPerfil);
                command.Parameters.AddWithValue("@Nombres", Usuario.Nombres);
                command.Parameters.AddWithValue("@Apellidos", Usuario.Apellidos);
                command.Parameters.AddWithValue("@Rol", Usuario.Rol);
                command.Parameters.AddWithValue("@Correo", Usuario.CorreoElectronico);
                command.Parameters.AddWithValue("@NombreUsuario", Usuario.NombreUsuario);
                command.Parameters.AddWithValue("@Contraseña", Usuario.Contraseña);
                var filas = command.ExecuteNonQuery();
            }
        }
        public List<Usuario> ConsultarTodos()
        {
            List<Usuario> Usuarios = new List<Usuario>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select CodigoUsuario, ImagenPerfil, Nombres, Apellidos, Rol, Correo, NombreUsuario, Contraseña from USUARIO";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Usuario Usuario = DataReaderMapToUsuario(dataReader);
                        Usuarios.Add(Usuario);
                    }
                }
            }
            return Usuarios;
        }
        public void Eliminar(Usuario Usuario)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from USUARIO where CodigoUsuario=@CodigoUsuario";
                command.Parameters.AddWithValue("@CodigoUsuario", Usuario.CodigoUsuario);
                command.ExecuteNonQuery();
            }
        }
        private Usuario DataReaderMapToUsuario(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Usuario Usuario = new Usuario();
            Usuario.CodigoUsuario = (string)dataReader["CodigoUsuario"];
            Usuario.ImagenPerfil = (byte[])dataReader["ImagenPerfil"];
            Usuario.Nombres = (string)dataReader["Nombres"];
            Usuario.Apellidos = (string)dataReader["Apellidos"];
            Usuario.Rol = (string)dataReader["Rol"];
            Usuario.CorreoElectronico = (string)dataReader["Correo"];
            Usuario.NombreUsuario = (string)dataReader["NombreUsuario"];
            Usuario.Contraseña = (string)dataReader["Contraseña"];
            return Usuario;
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
            return ConsultarTodos().Where(p => p.Rol.Equals(tipo)).Count();
        }
    }
}
