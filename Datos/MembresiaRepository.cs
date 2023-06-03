using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class MembresiaRepository
    {
        private readonly SqlConnection _connection;
        public MembresiaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar(Membresia membresia)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into MEMBRESIA (CodigoMiembro, Categoria, Estado, Nombres, Apellidos, NombrePlan, Creditos, ValorInscripcion, ValorMensual, Abono, Saldo) 
                                        values (@CodigoMiembro, @Categoria, @Estado, @Nombres, @Apellidos, @NombrePlan, @Creditos, @ValorInscripcion, @ValorMensual, @Abono, @Saldo)";
                command.Parameters.AddWithValue("@CodigoMiembro", membresia.CodigoMiembro);
                command.Parameters.AddWithValue("@Categoria", membresia.Categoria);
                command.Parameters.AddWithValue("@Estado", membresia.Estado);
                command.Parameters.AddWithValue("@Nombres", membresia.Nombres);
                command.Parameters.AddWithValue("@Apellidos", membresia.Apellidos);
                command.Parameters.AddWithValue("@NombrePlan", membresia.NombreDePlan);
                command.Parameters.AddWithValue("@Creditos", membresia.Creditos);
                command.Parameters.AddWithValue("@ValorInscripcion", membresia.ValorInscripcion);
                command.Parameters.AddWithValue("@ValorMensual", membresia.ValorMensual);
                command.Parameters.AddWithValue("@Abono", membresia.Abono);
                command.Parameters.AddWithValue("@Saldo", membresia.Saldo);
                var filas = command.ExecuteNonQuery();
            }
        }
        public List<Membresia> BuscarPorEstado(string estado)
        {
            List<Membresia> membresias = new List<Membresia>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from MEMBRESIA where Estado=@Estado";
                command.Parameters.AddWithValue("@Estado", estado);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Membresia membresia = DataReaderMapToMembresia(dataReader);
                        membresias.Add(membresia);
                    }
                }
            }
            return membresias;
        }
        public Membresia BuscarPorIdentificacion(string identificacion)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from MEMBRESIA where CodigoMiembro=@CodigoMiembro";
                command.Parameters.AddWithValue("@CodigoMiembro", identificacion);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToMembresia(dataReader);
            }
        }
        public Membresia BuscarPorNombre(string nombre)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from MEMBRESIA where Nombres=@Nombres";
                command.Parameters.AddWithValue("@Nombres", nombre);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToMembresia(dataReader);
            }
        }
        public Membresia BuscarPorCategoria(string categoria)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from MEMBRESIA where Categoria=@Categoria";
                command.Parameters.AddWithValue("@Categoria", categoria);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToMembresia(dataReader);
            }
        }
        public void Modificar(Membresia membresia)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update MEMBRESIA set Categoria=@Categoria, Estado=@Estado, Nombres=@Nombres, Apellidos=@Apellidos, NombrePlan=@NombrePlan, Creditos=@Creditos, ValorInscripcion=@ValorInscripcion, ValorMensual=@ValorMensual, Abono=@Abono, Saldo=@Saldo
                                        where CodigoMiembro=@CodigoMiembro";
                command.Parameters.AddWithValue("@CodigoMiembro", membresia.CodigoMiembro);
                command.Parameters.AddWithValue("@Categoria", membresia.Categoria);
                command.Parameters.AddWithValue("@Estado", membresia.Estado);
                command.Parameters.AddWithValue("@Nombres", membresia.Nombres);
                command.Parameters.AddWithValue("@Apellidos", membresia.Apellidos);
                command.Parameters.AddWithValue("@NombrePlan", membresia.NombreDePlan);
                command.Parameters.AddWithValue("@Creditos", membresia.Creditos);
                command.Parameters.AddWithValue("@ValorInscripcion", membresia.ValorInscripcion);
                command.Parameters.AddWithValue("@ValorMensual", membresia.ValorMensual);
                command.Parameters.AddWithValue("@Abono", membresia.Abono);
                command.Parameters.AddWithValue("@Saldo", membresia.Saldo);
                var filas = command.ExecuteNonQuery();
            }
        }
        public List<Membresia> ConsultarTodos()
        {
            List<Membresia> membresias = new List<Membresia>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select CodigoMiembro, Categoria, Estado, Nombres, Apellidos, NombrePlan, Creditos, ValorInscripcion, ValorMensual, Abono, Saldo from MEMBRESIA";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Membresia membresia = DataReaderMapToMembresia(dataReader);
                        membresias.Add(membresia);
                    }
                }
            }
            return membresias;
        }
        public void Eliminar(Membresia membresia)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from MEMBRESIA where CodigoMiembro=@CodigoMiembro";
                command.Parameters.AddWithValue("@CodigoMiembro", membresia.CodigoMiembro);
                command.ExecuteNonQuery();
            }
        }
        private Membresia DataReaderMapToMembresia(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Membresia membresia = new Membresia();
            membresia.CodigoMiembro = (string)dataReader["CodigoMiembro"];
            membresia.Categoria = (string)dataReader["Categoria"];
            membresia.Estado = (string)dataReader["Estado"];
            membresia.Nombres = (string)dataReader["Nombres"];
            membresia.Apellidos = (string)dataReader["Apellidos"];
            membresia.NombreDePlan = (string)dataReader["NombrePlan"];
            membresia.Creditos = (int)dataReader["Creditos"];
            membresia.ValorInscripcion = (int)dataReader["ValorInscripcion"];
            membresia.ValorMensual = (int)dataReader["ValorMensual"];
            membresia.Abono = (int)dataReader["Abono"];
            membresia.Saldo = (int)dataReader["Saldo"];
            return membresia;
        }
        public int Totalizar()
        {
            return ConsultarTodos().Count();
        }
        public int TotalizarTipoEstado(string estado)
        {
            return ConsultarTodos().Where(p => p.Estado.Equals(estado)).Count();
        }
        public int TotalizarTipoCategoria(string categoria)
        {
            return ConsultarTodos().Where(p => p.Categoria.Equals(categoria)).Count();
        }
    }
}
