using ZimmerSystems.DataBases.ViewModel;

namespace ZimmerSystems.Controllers
{
    public class SolicitudController
    {
        public bool ValidationEmptyTextNewRequest(RequestVM requestVM)
        {
            bool validation = false;

            if (!requestVM.Name.Equals("") && !requestVM.LastName.Equals("") && !requestVM.Phone.Equals("") && !requestVM.Address.Equals("") && !requestVM.DateSolution.Equals("") && 
                !requestVM.EquipmentID.Equals("")  && !requestVM.Model.Equals("") && !requestVM.Color.Equals("") && !requestVM.S_N.Equals(""))
            {
                validation = true;
            }

            return validation;
        }

        public bool CreateRequest(RequestVM requestVM)
        {
            bool validation = false;

            return validation;
        }

        public bool ValidationEmptyTextChangeRequest(RequestVM requestVM)
        {
            bool validation = false;

            if (!requestVM.Name.Equals("") && !requestVM.LastName.Equals("") && !requestVM.Phone.Equals("") && !requestVM.Address.Equals("") && !requestVM.DateSolution.Equals("") &&
                !requestVM.EquipmentID.Equals("") && !requestVM.Model.Equals("") && !requestVM.Color.Equals("") && !requestVM.S_N.Equals(""))
            {
                validation = true;
            }

            return validation;
        }

        public bool ChangeRequest(RequestVM requestVM)
        {
            bool validation = false;

            return validation;
        }

        public bool ValidationEmptyTextCancelRequest(RequestVM requestVM)
        {
            bool validation = false;

            if (!requestVM.CancelDescription.Equals(""))
            {
                validation = true;
            }

            return validation;
        }

        public bool CancelRequest(RequestVM requestVM)
        {
            bool validation = false;

            return validation;
        }
    }
}
