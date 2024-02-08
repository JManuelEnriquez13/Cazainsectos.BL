namespace Cazainsectos.BL.Models
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LegalName { get; set; }

        public string Address { get; set; }

        public string Neighborhood { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public string Rfc { get; set; }

        public string BillEmail { get; set; }

        public string BillAddress { get; set; }

        public string BillNeighborhood { get; set; }

        public string BillCity { get; set; }

        public string BillZipCode { get; set; }

        public int IdBillEntityType { get; set; }

        public int IdBillPaymentMethod { get; set; }

        public int IdBillPaymentType { get; set; }

        public int IdBillCfdiUse { get; set; }

        public string BillComments { get; set; }

        public int WhatsappReminder { get; set; }
    }
}