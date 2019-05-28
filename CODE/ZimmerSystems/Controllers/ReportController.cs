using System;
using System.Data.SqlClient;
using ZimmerSystems.DataBases;

namespace ZimmerSystems.Controllers
{
    public class ReportController
    {
        public bool ReportSearchLastMonth(int reportType)
        {
            bool Exitoso = false;

            try
            {
                using (SqlConnection Conn = Conection.ObtnerConecion())
                {
                    SqlCommand comando = new SqlCommand(string.Format(
                        "SELECT * FROM CAT_QUESET  WHERE DATE < '{0}'  AND DATE > '{1}' ",  DateTime.Today, DateTime.Today.AddMonths(-1) ), Conn);
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        Exitoso = true;
                    }

                    Conn.Close();

                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return Exitoso;
        }
    }
}
