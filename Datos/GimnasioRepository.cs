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
        public void Guardar(Gimnasio drogueria)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into GIMNASIO (Id_Gimnasio, Nombre_De_Gimnasio, NIT, CodigoCamara, Frase_Distintiva, Regimen, PBX,Direccion,Telefono) 
                                        values (@Id_Gimnasio, @Nombre_De_Gimnasio, @NIT, @CodigoCamara, @Frase_Distintiva, @Regimen, @PBX, @Direccion, @Telefono)";
                command.Parameters.AddWithValue("@Id_Gimnasio", drogueria.IdGimnasio);
                command.Parameters.AddWithValue("@Nombre_De_Gimnasio", drogueria.NombreGimnasio);
                command.Parameters.AddWithValue("@NIT", drogueria.NIT);
                command.Parameters.AddWithValue("@CodigoCamara", drogueria.CodigoDeCamara);
                command.Parameters.AddWithValue("@Frase_Distintiva", drogueria.FraseDistintiva);
                command.Parameters.AddWithValue("@Regimen", drogueria.Regimen);
                command.Parameters.AddWithValue("@PBX", drogueria.PBX);
                command.Parameters.AddWithValue("@Direccion", drogueria.Direccion);
                command.Parameters.AddWithValue("@Telefono", drogueria.Telefono);
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
                        Gimnasio drogueria = DataReaderMapToGimnasio(dataReader);
                        cajas.Add(drogueria);
                    }
                }
            }
            return cajas;
        }
        public void Modificar(Gimnasio drogueria)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update GIMNASIO set Nombre_De_Gimnasio=@Nombre_De_Gimnasio, NIT=@NIT, CodigoCamara=@CodigoCamara, Frase_Distintiva=@Frase_Distintiva, Regimen=@Regimen, PBX=@PBX, Direccion=@Direccion, Telefono=@Telefono
                                        where Id_Gimnasio=@Id_Gimnasio";
                command.Parameters.AddWithValue("@Id_Gimnasio", drogueria.IdGimnasio);
                command.Parameters.AddWithValue("@Nombre_De_Gimnasio", drogueria.NombreGimnasio);
                command.Parameters.AddWithValue("@NIT", drogueria.NIT);
                command.Parameters.AddWithValue("@CodigoCamara", drogueria.CodigoDeCamara);
                command.Parameters.AddWithValue("@Frase_Distintiva", drogueria.FraseDistintiva);
                command.Parameters.AddWithValue("@Regimen", drogueria.Regimen);
                command.Parameters.AddWithValue("@PBX", drogueria.PBX);
                command.Parameters.AddWithValue("@Direccion", drogueria.Direccion);
                command.Parameters.AddWithValue("@Telefono", drogueria.Telefono);
                var filas = command.ExecuteNonQuery();
            }
        }
        public Gimnasio BuscarPorId(string nit)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from GIMNASIO where Id_Gimnasio=@Id_Gimnasio";
                command.Parameters.AddWithValue("@Id_Gimnasio", nit);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToGimnasio(dataReader);
            }
        }
        public void Eliminar(Gimnasio drogueria)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from GIMNASIO where Id_Gimnasio=@Id_Gimnasio";
                command.Parameters.AddWithValue("@Id_Gimnasio", drogueria.IdGimnasio);
                command.ExecuteNonQuery();
            }
        }
        private Gimnasio DataReaderMapToGimnasio(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Gimnasio drogueria = new Gimnasio();
            drogueria.IdGimnasio = (string)dataReader["Id_Gimnasio"];
            drogueria.NombreGimnasio = (string)dataReader["Nombre_De_Gimnasio"];
            drogueria.NIT = (string)dataReader["NIT"];
            drogueria.CodigoDeCamara = (string)dataReader["CodigoCamara"];
            drogueria.FraseDistintiva = (string)dataReader["Frase_Distintiva"];
            drogueria.Regimen = (string)dataReader["Regimen"];
            drogueria.PBX = (string)dataReader["PBX"];
            drogueria.Direccion = (string)dataReader["Direccion"];
            drogueria.Telefono = (string)dataReader["Telefono"];
            return drogueria;
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
