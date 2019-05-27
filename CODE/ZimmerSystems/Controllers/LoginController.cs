using System;
using System.Data.SqlClient;
using ZimmerSystems.DataBases;
using ZimmerSystems.DataBases.ViewModel;

namespace ZimmerSystems.Controllers
{
    public class LoginController
    {
        public UserVM ConsultarUsuario(string user, string password)
        {
            UserVM UserVM = new UserVM();
            try
            {
                using (SqlConnection Conn = Conection.ObtnerConecion())
                {
                    SqlCommand comando = new SqlCommand(string.Format(
                        "SELECT * FROM CAT_USERS WHERE CAT_USERS.USERNAME = '{0}' AND PASSWORD = '{1}' ", user, password), Conn);
                        
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        UserVM.ID = reader.GetInt32(0);
                        UserVM.UserName = reader.GetString(1);
                        UserVM.Password = reader.GetString(2);
                        UserVM.FirstName = reader.GetString(3);
                        UserVM.LastName = reader.GetString(4);
                        UserVM.RolId = reader.GetInt32(5);
                        UserVM.Address = reader.GetString(6);
                        UserVM.ZipCode = reader.GetInt32(7);
                        UserVM.Phone = reader.GetString(8);
                        UserVM.CelPhone = reader.GetString(9);
                        UserVM.Active = reader.GetBoolean(10);
                    }

                    Conn.Close();
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return UserVM;
        }

        public bool ValidationEmptyText(string user, string passowrd)
        {
            bool validation = false;

            if (!user.Equals("") || !passowrd.Equals(""))
                validation = true;
            
            return validation;
        }
    }
}
