using System;
using System.Data.SqlClient;
using ZimmerSystems.DataBases;
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
            bool Exitoso = false;

            try
            {
                using (SqlConnection Conn = Conection.ObtnerConecion())
                {
                    SqlCommand comando = new SqlCommand(string.Format(
                        "INSERT INTO CAT_QUESET (FOLIO, NAME, LAST_NAME, PHONE, ADDRESS, DATE, DATE_SOLUTION, EQUIPMENTID, MODEL, BRAND, COLOR, S_N, STATUS) " +
                                " VALUES ('{0}', '{1}', '{2}', '{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}') ", requestVM.Folio, requestVM.Name, requestVM.LastName, requestVM.Phone, 
                                                                                                                                requestVM.Address, requestVM.Date, requestVM.DateSolution, requestVM.EquipmentID, requestVM.Model, requestVM.Brand, requestVM.Color, requestVM.S_N, requestVM.Status), Conn);
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
            try
            {
                using (SqlConnection Conn = Conection.ObtnerConecion())
                {
                    SqlCommand comando = new SqlCommand(string.Format(
                        "UPDATE CAT_QUESET PHONE = '{0}', DATE_SOLUTION = '{1}' , ERROR_DESCRIPTION = '{2}' WHERE ID = '{3}'", requestVM.Phone, requestVM.DateSolution, requestVM.ErrorDescription, requestVM.Folio), Conn);
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        validation = true;
                    }

                    Conn.Close();

                }
            }
            catch (Exception ex)
            {
                throw;
            }

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

            try
            {
                using (SqlConnection Conn = Conection.ObtnerConecion())
                {
                    SqlCommand comando = new SqlCommand(string.Format(
                        "UPDATE CAT_QUESET CANCEL_DESCRIPTION = '{0}', STATUS = '{1}' WHERE ID = '{2}'", requestVM.CancelDescription, requestVM.Status, requestVM.Folio), Conn);
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        validation = true;

                    }

                    Conn.Close();

                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return validation;
        }        
    }
}
