using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Datos
{
    public class PapeleraRepository
    {
        private string ruta = @"HistorialDeCajas.txt";
        public void Guardar(Papelera papelera)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($"{papelera.Id_CajaDelete};{papelera.FechaDeAperturaDelete};{papelera.FechaDeCierreDelete};{papelera.EstadoDelete};{papelera.MontoDelete}");
            escritor.Close();
            file.Close();
        }
        public List<Papelera> Consultar()
        {
            List<Papelera> papeleras = new List<Papelera>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(ruta);
            var linea = "";
            while ((linea = lector.ReadLine()) != null)
            {
                string[] dato = linea.Split(';');
                Papelera papelera = new Papelera()
                {
                    Id_CajaDelete = dato[0],
                    FechaDeAperturaDelete = dato[1],
                    FechaDeCierreDelete = dato[2],
                    EstadoDelete = dato[3],
                    MontoDelete = double.Parse(dato[4])
                };
                papeleras.Add(papelera);
            }
            lector.Close();
            file.Close();
            return papeleras;
        }
        public bool FiltroIdentificaicon(string identificacion)
        {
            List<Papelera> papeleras = new List<Papelera>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(ruta);
            var linea = "";
            while ((linea = lector.ReadLine()) != null)
            {
                string[] dato = linea.Split(';');
                if (dato[0].Equals(identificacion))
                {
                    lector.Close();
                    file.Close();
                    return true;
                }
            }
            lector.Close();
            file.Close();
            return false;

        }
        private bool EsEncontrado(string identificacioRegistrada, string identificacionBuscada)
        {
            return identificacioRegistrada == identificacionBuscada;
        }
        public void Modificar(Papelera papelera, string identificacion)
        {
            List<Papelera> papeleras = new List<Papelera>();
            papeleras = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach (var item in papeleras)
            {
                if (!EsEncontrado(item.Id_CajaDelete, identificacion))
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(papelera);
                }
            }
        }
        public void EliminarHistorial()
        {
            File.Delete(ruta);
        }
        public void Eliminar(string id)
        {
            List<Papelera> papeleras = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();

            foreach (var item in papeleras)
            {
                if (!item.Id_CajaDelete.Equals(id))
                {
                    Guardar(item);
                }
            }
        }
    }
}
