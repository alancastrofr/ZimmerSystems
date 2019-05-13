using System.Configuration;
using System.Data.SqlClient;

namespace ZimmerSystems.DataBases
{
    public class Conection
    {
        public static SqlConnection ObtnerConecion()
        {
            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs_db"].ConnectionString);
            Conn.Open();

            return Conn;
        }
    }
}
