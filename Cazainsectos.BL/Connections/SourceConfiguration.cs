using Microsoft.Extensions.Configuration;
using System.IO;

namespace Cazainsectos.BL.Connections
{
    public class SourceConfiguration
    {
        private readonly string _mySQLConnection;

        public SourceConfiguration()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            var root = configurationBuilder.Build();
            _mySQLConnection = root.GetConnectionString("MySQLConnection");
        }

        public string MySQLConnection
        {
            get => _mySQLConnection;
        }
    }
}