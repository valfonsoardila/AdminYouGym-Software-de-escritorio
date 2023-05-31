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
    public class EmpleadoRepository
    {
        private readonly SqlConnection _connection;
        public EmpleadoRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar(Empleado empleado)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into EMPLEADO (Id, Tipo_De_Id, ImagenPerfil, Nombres, Apellidos, Fecha_De_Nacimiento, Edad, Sexo, Direccion_Domicilio, Telefono, Rol, Correo) 
                                        values (@Id, @Tipo_De_Id, @ImagenPerfil, @Nombres, @Apellidos, @Fecha_De_Nacimiento, @Edad, @Sexo, @Direccion_Domicilio, @Telefono, @Rol, @Correo)";
                command.Parameters.AddWithValue("@Id", empleado.Identificacion);
                command.Parameters.AddWithValue("@Tipo_De_Id", empleado.TipoDeIdentificacion);
                command.Parameters.AddWithValue("@ImagenPerfil", empleado.ImagenPerfil);
                command.Parameters.AddWithValue("@Nombres", empleado.Nombres);
                command.Parameters.AddWithValue("@Apellidos", empleado.Apellidos);
                command.Parameters.AddWithValue("@Fecha_De_Nacimiento", empleado.FechaDeNacimiento);
                command.Parameters.AddWithValue("@Edad", empleado.Edad);
                command.Parameters.AddWithValue("@Sexo", empleado.Sexo);
                command.Parameters.AddWithValue("@Direccion_Domicilio", empleado.Direccion);
                command.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                command.Parameters.AddWithValue("@Rol", empleado.Rol);
                command.Parameters.AddWithValue("@Correo", empleado.CorreoElectronico);
                var filas = command.ExecuteNonQuery();
            }
        }
        public List<Empleado> BuscarPorSexo(string sexo)
        {
            List<Empleado> empleados = new List<Empleado>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from EMPLEADO where Sexo=@Sexo";
                command.Parameters.AddWithValue("@Sexo", sexo);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Empleado empleado = DataReaderMapToEmpleado(dataReader);
                        empleados.Add(empleado);
                    }
                }
            }
            return empleados;
        }
        public Empleado BuscarPorIdentificacion(string identificacion)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from EMPLEADO where Id=@Id";
                command.Parameters.AddWithValue("@Id", identificacion);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToEmpleado(dataReader);
            }
        }
        public Empleado BuscarPorRol(string rol)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from EMPLEADO where Rol=@Rol";
                command.Parameters.AddWithValue("@Rol", rol);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToEmpleado(dataReader);
            }
        }
        public Empleado BuscarPorNombreDeUsuario(string nombreDeUsuario)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from EMPLEADO where Nombres=@Nombres";
                command.Parameters.AddWithValue("@Nombres", nombreDeUsuario);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToEmpleado(dataReader);
            }
        }
        public void Modificar(Empleado empleado)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update EMPLEADO set Tipo_De_Id=@Tipo_De_Id, ImagenPerfil=@ImagenPerfil, Nombres=@Nombres, Apellidos=@Apellidos, Fecha_De_Nacimiento=@Fecha_De_Nacimiento, Edad=@Edad, Sexo=@Sexo, Direccion_Domicilio=@Direccion_Domicilio, Telefono=@Telefono, Rol=@Rol, Correo=@Correo, Usuario=@Usuario, Contraseña=@Contraseña
                                        where Id=@Id";
                command.Parameters.AddWithValue("@Id", empleado.Identificacion);
                command.Parameters.AddWithValue("@Tipo_De_Id", empleado.TipoDeIdentificacion);
                command.Parameters.AddWithValue("@ImagenPerfil", empleado.ImagenPerfil);
                command.Parameters.AddWithValue("@Nombres", empleado.Nombres);
                command.Parameters.AddWithValue("@Apellidos", empleado.Apellidos);
                command.Parameters.AddWithValue("@Fecha_De_Nacimiento", empleado.FechaDeNacimiento);
                command.Parameters.AddWithValue("@Edad", empleado.Edad);
                command.Parameters.AddWithValue("@Sexo", empleado.Sexo);
                command.Parameters.AddWithValue("@Direccion_Domicilio", empleado.Direccion);
                command.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                command.Parameters.AddWithValue("@Rol", empleado.Rol);
                command.Parameters.AddWithValue("@Correo", empleado.CorreoElectronico);
                var filas = command.ExecuteNonQuery();
            }
        }
        public List<Empleado> ConsultarTodos()
        {
            List<Empleado> empleados = new List<Empleado>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select Id, Tipo_De_Id, ImagenPerfil, Nombres, Apellidos, Fecha_De_Nacimiento, Edad, Sexo, Direccion_Domicilio, Telefono, Rol, Correo from EMPLEADO";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Empleado empleado = DataReaderMapToEmpleado(dataReader);
                        empleados.Add(empleado);
                    }
                }
            }
            return empleados;
        }
        public void Eliminar(Empleado empleado)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from EMPLEADO where Id=@Id";
                command.Parameters.AddWithValue("@Id", empleado.Identificacion);
                command.ExecuteNonQuery();
            }
        }
        private Empleado DataReaderMapToEmpleado(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Empleado empleado = new Empleado();
            empleado.Identificacion = (string)dataReader["Id"];
            empleado.TipoDeIdentificacion = (string)dataReader["Tipo_De_Id"];
            empleado.ImagenPerfil = (byte[])dataReader["ImagenPerfil"];
            empleado.Nombres = (string)dataReader["Nombres"];
            empleado.Apellidos = (string)dataReader["Apellidos"];
            empleado.FechaDeNacimiento = (DateTime)dataReader["Fecha_De_Nacimiento"];
            empleado.Edad = (int)dataReader["Edad"];
            empleado.Sexo = (string)dataReader["Sexo"];
            empleado.Direccion = (string)dataReader["Direccion_Domicilio"];
            empleado.Telefono = (string)dataReader["Telefono"];
            empleado.Rol = (string)dataReader["Rol"];
            empleado.CorreoElectronico = (string)dataReader["Correo"];
            return empleado;
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
