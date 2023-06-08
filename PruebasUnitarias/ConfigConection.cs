using System.Configuration;

namespace PruebasUnitarias
{
    internal class ConfigConnection
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        public static string ProviderName = ConfigurationManager.ConnectionStrings["conexion"].ProviderName;
    }
}
