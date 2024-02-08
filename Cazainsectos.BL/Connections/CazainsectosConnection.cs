using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace Cazainsectos.BL.Connections
{
    public class CazainsectosConnection
    {
        public static string SchemaCazainsectos => "cazainsectos";

        public static MySqlConnection NewConnection()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString);
        }

        public static MySqlCommand NewStoredProcedure(string spName, MySqlConnection connection, string schema)
        {
            spName = schema + "." + spName;

            return new MySqlCommand(spName, connection)
                { CommandType = CommandType.StoredProcedure, CommandTimeout = 300 };
        }
    }
}