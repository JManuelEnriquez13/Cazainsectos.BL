namespace Cazainsectos.BL.Models
{
    public class Unsubscription
    {
        public int IdCustomer { get; set; }

        public string PhoneNumber { get; set; }

        public string Reason { get; set; }

        public string Comments { get; set; }
    }
}