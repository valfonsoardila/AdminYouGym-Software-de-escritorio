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
    public class PlanDeEjercicioRepository
    {
        private readonly SqlConnection _connection;
        public PlanDeEjercicioRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar2(PlanDeEjercicio planDeEjercicio)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Insert Into SERVICIO(Id_Plan_De_Ejercicio, Tipo_De_Tiempo, Numero_DiasMeses, Fecha_De_Entreno, Sesion, Objetivo, Estado, Ciclo, Id_Cliente, Tipo_Id_Cliente, Nombre_Cliente, Descripcion_Plan_Ejercicio, Precio) " +
                    "Values (@Id_Plan_De_Ejercicio, @Tipo_De_Tiempo, @Numero_DiasMeses, @Fecha_De_Entreno, @Sesion, @Objetivo, @Estado, @Ciclo, @Id_Cliente, @Tipo_Id_Cliente, @Nombre_Cliente, @Descripcion_Plan_Ejercicio, @Precio)";
                //command.Parameters.Add("@Id", SqlDbType.VarChar).Value = persona.Identificacion;
                command.Parameters.AddWithValue("@Id_Plan_De_Ejercicio", planDeEjercicio.IdPlanDeEjercicio);
                command.Parameters.AddWithValue("@Tipo_De_Tiempo", planDeEjercicio.TipoDeTiempo);
                command.Parameters.AddWithValue("@Numero_DiasMeses", planDeEjercicio.NumeroDiasMeses);
                command.Parameters.AddWithValue("@Fecha_De_Entreno", planDeEjercicio.FechaDeEntreno);
                command.Parameters.AddWithValue("@Jornada", planDeEjercicio.Jornada);
                command.Parameters.AddWithValue("@Objetivo", planDeEjercicio.Objetivo);
                command.Parameters.AddWithValue("@Estado", planDeEjercicio.Estado);
                command.Parameters.AddWithValue("@Ciclo", planDeEjercicio.Ciclo);
                command.Parameters.AddWithValue("@Descripcion_Plan_Ejercicio", planDeEjercicio.DescripcionPlanEjercicio);
                command.Parameters.AddWithValue("@Precio", planDeEjercicio.Precio);
                command.ExecuteNonQuery();

            }
        }
        public void Guardar(PlanDeEjercicio planDeEjercicio)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into SERVICIO (Id_Plan_De_Ejercicio, Tipo_De_Tiempo, Numero_DiasMeses, Fecha_De_Entreno, Sesion, Objetivo, Estado, Ciclo, Id_Cliente, Tipo_Id_Cliente, Nombre_Cliente, Descripcion_Plan_Ejercicio, Precio) 
                                        values (@Id_Plan_De_Ejercicio, @Tipo_De_Tiempo, @Numero_DiasMeses, @Fecha_De_Entreno, @Sesion, @Objetivo, @Estado, @Ciclo, @Id_Cliente, @Tipo_Id_Cliente, @Nombre_Cliente, @Descripcion_Plan_Ejercicio, @Precio)";
                command.Parameters.AddWithValue("@Id_Plan_De_Ejercicio", planDeEjercicio.IdPlanDeEjercicio);
                command.Parameters.AddWithValue("@Tipo_De_Tiempo", planDeEjercicio.TipoDeTiempo);
                command.Parameters.AddWithValue("@Numero_DiasMeses", planDeEjercicio.NumeroDiasMeses);
                command.Parameters.AddWithValue("@Fecha_De_Entreno", planDeEjercicio.FechaDeEntreno);
                command.Parameters.AddWithValue("@Jornada", planDeEjercicio.Jornada);
                command.Parameters.AddWithValue("@Objetivo", planDeEjercicio.Objetivo);
                command.Parameters.AddWithValue("@Estado", planDeEjercicio.Estado);
                command.Parameters.AddWithValue("@Ciclo", planDeEjercicio.Ciclo);
                command.Parameters.AddWithValue("@Descripcion_Plan_Ejercicio", planDeEjercicio.DescripcionPlanEjercicio);
                command.Parameters.AddWithValue("@Precio", planDeEjercicio.Precio);
                var filas = command.ExecuteNonQuery();
            }
        }
        public void Eliminar(PlanDeEjercicio planDeEjercicio)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from SERVICIO where Id_Plan_De_Ejercicio = @Id_Plan_De_Ejercicio";
                command.Parameters.AddWithValue("@Id_Plan_De_Ejercicio", planDeEjercicio.IdPlanDeEjercicio);
                command.ExecuteNonQuery();
            }
        }
        public List<PlanDeEjercicio> ConsultarTodos()
        {
            List<PlanDeEjercicio> planesDeEjercicios = new List<PlanDeEjercicio>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select Id_Plan_De_Ejercicio, Tipo_De_Tiempo, Numero_DiasMeses, Fecha_De_Entreno, Sesion, Objetivo, Estado, Ciclo, Id_Cliente, Tipo_Id_Cliente, Nombre_Cliente, Descripcion_Plan_Ejercicio, Precio from SERVICIO";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        PlanDeEjercicio planDeEjercicio = DataReaderMapToPlanDeEjercicio(dataReader);
                        planesDeEjercicios.Add(planDeEjercicio);
                    }
                }
            }
            return planesDeEjercicios;
        }
        public PlanDeEjercicio BuscarPorIdentificacion(string id)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from SERVICIO where Id_Plan_De_Ejercicio = @Id_Plan_De_Ejercicio";
                command.Parameters.AddWithValue("@Id_Plan_De_Ejercicio", id);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToPlanDeEjercicio(dataReader);
            }
        }
        public void Modificar(PlanDeEjercicio planDeEjercicio)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update SERVICIO set Tipo_De_Tiempo=@Tipo_De_Tiempo, Numero_DiasMeses=@Numero_DiasMeses, Fecha_De_Entreno=@Fecha_De_Entreno, Sesion=@Sesion, Objetivo=@Objetivo, Estado=@Estado, Ciclo = @Ciclo, Id_Cliente=@Id_Cliente, Tipo_Id_Cliente=@Tipo_Id_Cliente, Nombre_Cliente=@Nombre_Cliente, Descripcion_Plan_Ejercicio=@Descripcion_Plan_Ejercicio, Precio=@Precio
                                        where Id_Plan_De_Ejercicio = @Id_Plan_De_Ejercicio";
                command.Parameters.AddWithValue("@Id_Plan_De_Ejercicio", planDeEjercicio.IdPlanDeEjercicio);
                command.Parameters.AddWithValue("@Tipo_De_Tiempo", planDeEjercicio.TipoDeTiempo);
                command.Parameters.AddWithValue("@Numero_DiasMeses", planDeEjercicio.NumeroDiasMeses);
                command.Parameters.AddWithValue("@Fecha_De_Entreno", planDeEjercicio.FechaDeEntreno);
                command.Parameters.AddWithValue("@Jornada", planDeEjercicio.Jornada);
                command.Parameters.AddWithValue("@Objetivo", planDeEjercicio.Objetivo);
                command.Parameters.AddWithValue("@Estado", planDeEjercicio.Estado);
                command.Parameters.AddWithValue("@Ciclo", planDeEjercicio.Ciclo);
                command.Parameters.AddWithValue("@Descripcion_Plan_Ejercicio", planDeEjercicio.DescripcionPlanEjercicio);
                command.Parameters.AddWithValue("@Precio", planDeEjercicio.Precio);
                var filas = command.ExecuteNonQuery();
            }
        }
        private PlanDeEjercicio DataReaderMapToPlanDeEjercicio(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            PlanDeEjercicio planDeEjercicio = new PlanDeEjercicio();
            planDeEjercicio.IdPlanDeEjercicio = (string)dataReader["Id_Plan_De_Ejercicio"];
            planDeEjercicio.TipoDeTiempo = (string)dataReader["Tipo_De_Tiempo"];
            planDeEjercicio.NumeroDiasMeses = (int)dataReader["Numero_DiasMeses"];
            planDeEjercicio.FechaDeEntreno = (DateTime)dataReader["Fecha_De_Entreno"];
            planDeEjercicio.Jornada = (string)dataReader["Jornada"];
            planDeEjercicio.Objetivo = (string)dataReader["Objetivo"];
            planDeEjercicio.Estado = (string)dataReader["Estado"];
            planDeEjercicio.Ciclo = (string)dataReader["Ciclo"];
            planDeEjercicio.DescripcionPlanEjercicio = (string)dataReader["Descripcion_Plan_Ejercicio"];
            planDeEjercicio.Precio = (double)dataReader["Precio"];
            return planDeEjercicio;
        }
        public int Totalizar()
        {

            return ConsultarTodos().Count();
        }
        public int TotalizarTipo(string tipo)
        {
            return ConsultarTodos().Where(p => p.Jornada.Equals(tipo)).Count();
        }
    }
}
