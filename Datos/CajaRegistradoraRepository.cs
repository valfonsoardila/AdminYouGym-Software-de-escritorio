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
    public class CajaRegistradoraRepository
    {
        private readonly SqlConnection _connection;
        public CajaRegistradoraRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar2(CajaRegistradora cajaRegistradora)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Insert Into CAJA_REGISTRADORA(Id_Caja, Fecha_De_Apertura, Fecha_De_Cierre, Estado, Monto) " +
                    "Values (@Id_Caja, @Fecha_De_Apertura, @Fecha_De_Cierre, @Estado, @Monto)";
                //command.Parameters.Add("@Id", SqlDbType.VarChar).Value = persona.Identificacion;
                command.Parameters.AddWithValue("@Id_Caja", cajaRegistradora.IdCaja);
                command.Parameters.AddWithValue("@Fecha_De_Apertura", cajaRegistradora.FechaDeApertura);
                command.Parameters.AddWithValue("@Fecha_De_Cierre", cajaRegistradora.FechaDeCierre);
                command.Parameters.AddWithValue("@Estado", cajaRegistradora.Estado);
                command.Parameters.AddWithValue("@Monto", cajaRegistradora.Monto);
                command.ExecuteNonQuery();

            }
        }
        public void Guardar(CajaRegistradora cajaRegistradora)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into CAJA_REGISTRADORA (Id_Caja, Fecha_De_Apertura, Fecha_De_Cierre, Estado, Monto) 
                                        values (@Id_Caja, @Fecha_De_Apertura, @Fecha_De_Cierre, @Estado, @Monto)";
                command.Parameters.AddWithValue("@Id_Caja", cajaRegistradora.IdCaja);
                command.Parameters.AddWithValue("@Fecha_De_Apertura", cajaRegistradora.FechaDeApertura);
                command.Parameters.AddWithValue("@Fecha_De_Cierre", cajaRegistradora.FechaDeCierre);
                command.Parameters.AddWithValue("@Estado", cajaRegistradora.Estado);
                command.Parameters.AddWithValue("@Monto", cajaRegistradora.Monto);
                var filas = command.ExecuteNonQuery();
            }
        }
        public void Eliminar(CajaRegistradora cajaRegistradora)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from CAJA_REGISTRADORA where Id_Caja=@Id_Caja";
                command.Parameters.AddWithValue("@Id_Caja", cajaRegistradora.IdCaja);
                command.ExecuteNonQuery();
            }
        }
        public void EliminarHistorial(string estado)
        {
            List<CajaRegistradora> cajasRegitradoras = new List<CajaRegistradora>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from CAJA_REGISTRADORA where Estado=@Estado";
                command.Parameters.AddWithValue("@estado", estado);
                command.ExecuteNonQuery();
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        CajaRegistradora cajaRegistradora = DataReaderMapToCajaRegistradora(dataReader);
                        cajasRegitradoras.Add(cajaRegistradora);
                    }
                }
            }
        }
        public List<CajaRegistradora> ConsultarTodos()
        {
            List<CajaRegistradora> cajasRegitradoras = new List<CajaRegistradora>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select Id_Caja, Fecha_De_Apertura, Fecha_De_Cierre, Estado, Monto from CAJA_REGISTRADORA ";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        CajaRegistradora cajaRegistradora = DataReaderMapToCajaRegistradora(dataReader);
                        cajasRegitradoras.Add(cajaRegistradora);
                    }
                }
            }
            return cajasRegitradoras;
        }
        public List<CajaRegistradora> BuscarHistorial(string estado)
        {
            List<CajaRegistradora> cajasRegitradoras = new List<CajaRegistradora>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from CAJA_REGISTRADORA where Estado=@Estado";
                command.Parameters.AddWithValue("@Estado", estado);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        CajaRegistradora cajaRegistradora = DataReaderMapToCajaRegistradora(dataReader);
                        cajasRegitradoras.Add(cajaRegistradora);
                    }
                }
            }
            return cajasRegitradoras;
        }
        public CajaRegistradora BuscarPorEstado(string estado)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from CAJA_REGISTRADORA where Estado=@Estado";
                command.Parameters.AddWithValue("@Estado", estado);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToCajaRegistradora(dataReader);
            }
        }
        public CajaRegistradora BuscarPorIdentificacion(string identificacion)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from CAJA_REGISTRADORA where Id_Caja=@Id_Caja";
                command.Parameters.AddWithValue("@Id_Caja", identificacion);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToCajaRegistradora(dataReader);
            }
        }
        public void Modificar(CajaRegistradora cajaRegistradora)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update CAJA_REGISTRADORA set Fecha_De_Apertura=@Fecha_De_Apertura, Fecha_De_Cierre=@Fecha_De_Cierre, Estado=@Estado, Monto=@Monto
                                        where Id_Caja=@Id_Caja";
                command.Parameters.AddWithValue("@Id_Caja", cajaRegistradora.IdCaja);
                command.Parameters.AddWithValue("@Fecha_De_Apertura", cajaRegistradora.FechaDeApertura);
                command.Parameters.AddWithValue("@Fecha_De_Cierre", cajaRegistradora.FechaDeCierre);
                command.Parameters.AddWithValue("@Estado", cajaRegistradora.Estado);
                command.Parameters.AddWithValue("@Monto", cajaRegistradora.Monto);
                var filas = command.ExecuteNonQuery();
            }
        }
        private CajaRegistradora DataReaderMapToCajaRegistradora(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            CajaRegistradora cajaRegistradora = new CajaRegistradora();
            cajaRegistradora.IdCaja = (string)dataReader["Id_Caja"];
            cajaRegistradora.FechaDeApertura = (string)dataReader["Fecha_De_Apertura"];
            cajaRegistradora.FechaDeCierre = (string)dataReader["Fecha_De_Cierre"];
            cajaRegistradora.Estado = (string)dataReader["Estado"];
            cajaRegistradora.Monto = (int)dataReader["Monto"];
            return cajaRegistradora;
        }
        public int Totalizar()
        {

            return ConsultarTodos().Count();
        }
        public int TotalizarTipo(string tipo)
        {

            return ConsultarTodos().Where(p => p.Estado.Equals(tipo)).Count();
        }
    }
}
