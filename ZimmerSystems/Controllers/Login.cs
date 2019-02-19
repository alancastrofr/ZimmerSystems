using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimmerSystems.Controllers
{
    public class Login
    {
        bool ValidateUser(string user, string password)
        {
            try
            {
                if (ValidationEmptyText(user, password))
                {

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
