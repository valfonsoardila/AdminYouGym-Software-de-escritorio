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
    public class GimnasioRepository
    {
        private readonly SqlConnection _connection;
        public GimnasioRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar(Gimnasio gimnasio)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into GIMNASIO (Id_Gimnasio, Nombre_De_Gimnasio, NIT, CodigoCamara, Frase_Distintiva, Regimen, PBX, Direccion, Telefono) 
                                        values (@Id_Gimnasio, @Nombre_De_Gimnasio, @NIT, @CodigoCamara, @Frase_Distintiva, @Regimen, @PBX, @Direccion, @Telefono)";
                command.Parameters.AddWithValue("@Id_Gimnasio", gimnasio.IdGimnasio);
                command.Parameters.AddWithValue("@Nombre_De_Gimnasio", gimnasio.NombreGimnasio);
                command.Parameters.AddWithValue("@NIT", gimnasio.NIT);
                command.Parameters.AddWithValue("@CodigoCamara", gimnasio.CodigoDeCamara);
                command.Parameters.AddWithValue("@Frase_Distintiva", gimnasio.FraseDistintiva);
                command.Parameters.AddWithValue("@Regimen", gimnasio.Regimen);
                command.Parameters.AddWithValue("@PBX", gimnasio.PBX);
                command.Parameters.AddWithValue("@Direccion", gimnasio.Direccion);
                command.Parameters.AddWithValue("@Telefono", gimnasio.Telefono);
                var filas = command.ExecuteNonQuery();
            }
        }
        public List<Gimnasio> ConsultarTodos()
        {
            List<Gimnasio> cajas = new List<Gimnasio>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select Id_Gimnasio, Nombre_De_Gimnasio, NIT, CodigoCamara, Frase_Distintiva, Regimen, PBX, Direccion, Telefono from GIMNASIO";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Gimnasio gimnasio = DataReaderMapToGimnasio(dataReader);
                        cajas.Add(gimnasio);
                    }
                }
            }
            return cajas;
        }
        public void Modificar(Gimnasio gimnasio)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update GIMNASIO set Nombre_De_Gimnasio=@Nombre_De_Gimnasio, NIT=@NIT, CodigoCamara=@CodigoCamara, Frase_Distintiva=@Frase_Distintiva, Regimen=@Regimen, PBX=@PBX, Direccion=@Direccion, Telefono=@Telefono
                                        where Id_Gimnasio=@Id_Gimnasio";
                command.Parameters.AddWithValue("@Id_Gimnasio", gimnasio.IdGimnasio);
                command.Parameters.AddWithValue("@Nombre_De_Gimnasio", gimnasio.NombreGimnasio);
                command.Parameters.AddWithValue("@NIT", gimnasio.NIT);
                command.Parameters.AddWithValue("@CodigoCamara", gimnasio.CodigoDeCamara);
                command.Parameters.AddWithValue("@Frase_Distintiva", gimnasio.FraseDistintiva);
                command.Parameters.AddWithValue("@Regimen", gimnasio.Regimen);
                command.Parameters.AddWithValue("@PBX", gimnasio.PBX);
                command.Parameters.AddWithValue("@Direccion", gimnasio.Direccion);
                command.Parameters.AddWithValue("@Telefono", gimnasio.Telefono);
                var filas = command.ExecuteNonQuery();
            }
        }
        public Gimnasio BuscarPorId(string id)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from GIMNASIO where Id_Gimnasio=@Id_Gimnasio";
                command.Parameters.AddWithValue("@Id_Gimnasio", id);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToGimnasio(dataReader);
            }
        }
        public void Eliminar(Gimnasio gimnasio)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from GIMNASIO where Id_Gimnasio=@Id_Gimnasio";
                command.Parameters.AddWithValue("@Id_Gimnasio", gimnasio.IdGimnasio);
                command.ExecuteNonQuery();
            }
        }
        private Gimnasio DataReaderMapToGimnasio(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Gimnasio gimnasio = new Gimnasio();
            gimnasio.IdGimnasio = (string)dataReader["Id_Gimnasio"];
            gimnasio.NombreGimnasio = (string)dataReader["Nombre_De_Gimnasio"];
            gimnasio.NIT = (string)dataReader["NIT"];
            gimnasio.CodigoDeCamara = (string)dataReader["CodigoCamara"];
            gimnasio.FraseDistintiva = (string)dataReader["Frase_Distintiva"];
            gimnasio.Regimen = (string)dataReader["Regimen"];
            gimnasio.PBX = (string)dataReader["PBX"];
            gimnasio.Direccion = (string)dataReader["Direccion"];
            gimnasio.Telefono = (string)dataReader["Telefono"];
            return gimnasio;
        }
        public int Totalizar()
        {
            return ConsultarTodos().Count();
        }
        public int TotalizarTipo(string tipo)
        {

            return ConsultarTodos().Where(p => p.IdGimnasio.Equals(tipo)).Count();
        }
    }
}
