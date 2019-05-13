using System;

namespace ZimmerSystems.DataBases.ViewModel
{
    public class RequestVM
    {
        public int Folio { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateSolution { get; set; }
        public int EquipmentID { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string S_N { get; set; }
        public string ErrorDescription { get; set; }
        public string CancelDescription { get; set; }
        public string Status { get; set; }

        public RequestVM() { }

        public RequestVM(RequestVM r)
        {
            this.Folio = r.Folio;
            this.Name = r.Name;
            this.LastName = r.LastName;
            this.Phone = r.Phone;
            this.Address = r.Address;
            this.Date = r.Date;
            this.DateSolution = r.DateSolution;
            this.EquipmentID = r.EquipmentID;
            this.Model = r.Model;
            this.Brand = r.Brand;
            this.Color = r.Color;
            this.S_N = r.S_N;
            this.ErrorDescription = r.ErrorDescription;
            this.CancelDescription = r.CancelDescription;
            this.Status = r.Status;
        }
    }
}
