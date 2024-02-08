namespace Cazainsectos.BL.Models
{
    public class TechnicianView : Technician
    {
        public string Fullname => Name + " " + LastName;

        public string SearchProperty => Fullname;
    }
}