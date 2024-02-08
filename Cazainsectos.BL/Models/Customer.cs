namespace Cazainsectos.BL.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public int IdPrefix { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Neighborhood { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int IdCompany { get; set; }

        public string Rfc { get; set; }

        public int WhatsappReminder { get; set; }
    }
}