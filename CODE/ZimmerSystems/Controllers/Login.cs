using System;
using System.Data.SqlClient;
using ZimmerSystems.DataBases;
using ZimmerSystems.DataBases.ViewModel;

namespace ZimmerSystems.Controllers
{
    public class Login
    {
        bool ValidateUser(string user, string password)
        {
            bool resultado = false;
            try
            {
                if (ValidationEmptyText(user, password))
                {
                    using (SqlConnection Conn = Conection.ObtnerConecion())
                    {
                        SqlCommand comando = new SqlCommand(string.Format(
                            "SELECT ID, USERNAME, PASSWORD, FIRST_NAME, LAST_NAME, ROLID, ADDRESS, ZIPCODE, PHONE, CELPHONE, ACTIVE FROM ZimmerSystems.dbo.CAT_USERS " +
                            "WHERE ZimmerSystems.dbo.CAT_USERS.USERNAME = {0} , ZimmerSystems.dbo.CAT_USERS.PASSWORD = {1} ", user, password), Conn);
                        SqlDataReader reader = comando.ExecuteReader();

                        while (reader.Read())
                        {
                            UserVM UserVM = new UserVM();
                            UserVM.ID = reader.GetInt32(0);
                            UserVM.UserName = reader.GetString(1);
                            UserVM.Password = reader.GetString(2);
                            UserVM.FirstName = reader.GetString(3);
                            UserVM.LastName = reader.GetDateTime(4);
                            UserVM.RolId = reader.GetDateTime(5);
                            UserVM.Address = reader.GetDateTime(5);
                            UserVM.ZipCode = reader.GetDateTime(5);
                            UserVM.Phone = reader.GetDateTime(5);
                            UserVM.CelPhone = reader.GetDateTime(5);
                            UserVM.Active = reader.GetDateTime(5);
                            Lista.Add(EventosVM);
                        }
                        conexion.Close();
                    }

                }                
            }
            catch (Exception)
            {

                throw;
            }

            return true;
        }

        bool ValidationEmptyText(string user, string passowrd)
        {
            bool validation = false;

            if (!user.Equals("") || !passowrd.Equals(""))
                validation = true;
            
            return validation;
        }
    }
}
