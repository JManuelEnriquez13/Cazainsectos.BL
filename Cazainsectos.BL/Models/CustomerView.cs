namespace Cazainsectos.BL.Models
{
    public class CustomerView : Customer
    {
        public string CompanyName { get; set; }

        public string PrefixName { get; set; }

        public string Fullname => Name + " " + LastName;

        public string SearchProperty => Name + " " + LastName;
    }
}