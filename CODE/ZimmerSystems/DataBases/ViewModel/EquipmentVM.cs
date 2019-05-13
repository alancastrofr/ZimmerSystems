namespace ZimmerSystems.DataBases.ViewModel
{
    public class EquipmentVM : CommonVM
    {
        public EquipmentVM() { }

        public EquipmentVM(EquipmentVM e)
        {
            this.ID = e.ID;
            this.Description = e.Description;
            this.Active = e.Active;
        }
    }
}
