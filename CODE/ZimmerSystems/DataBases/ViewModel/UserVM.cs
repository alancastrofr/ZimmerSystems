using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimmerSystems.DataBases.ViewModel
{
    public class UserVM
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RolId { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string Phone { get; set; }
        public string CelPhone { get; set; }
        public bool Active { get; set; }
        public int Pantalla { get; set; }

        public UserVM() { }

        public UserVM(UserVM u)
        {
            this.ID = u.ID;
            this.UserName = u.UserName;
            this.Password = u.Password;
            this.FirstName = u.FirstName;
            this.LastName = u.LastName;
            this.RolId = u.RolId;
            this.Address = u.Address;
            this.ZipCode = u.ZipCode;
            this.Phone = u.Phone;
            this.CelPhone = u.CelPhone;
            this.Active = u.Active;
            this.Pantalla = u.Pantalla;
        }

    }
}
