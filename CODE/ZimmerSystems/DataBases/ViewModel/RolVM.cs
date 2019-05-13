namespace ZimmerSystems.DataBases.ViewModel
{
    public class RolVM : CommonVM
    {
        public RolVM() { }

        public RolVM(RolVM r)
        {
            this.ID = r.ID;
            this.Description = r.Description;
            this.Active = r.Active;
        }
    }
}
