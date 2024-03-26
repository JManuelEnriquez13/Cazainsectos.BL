using System;

namespace Cazainsectos.BL.Models
{
    public class Event
    {
        private string _eventDate;

        private string _nextDate;
        public int Id { get; set; }

        public int? Number { get; set; }

        public string EventDate
        {
            get
            {
                if (!string.IsNullOrEmpty(_eventDate))
                    _eventDate = Convert.ToDateTime(_eventDate).ToString("dd/MM/yyyy");

                return _eventDate;
            }
            set => _eventDate = value;
        }

        public string NextDate
        {
            get
            {
                if (!string.IsNullOrEmpty(_nextDate)) _nextDate = Convert.ToDateTime(_nextDate).ToString("dd/MM/yyyy");

                return _nextDate;
            }
            set => _nextDate = value;
        }

        public int IdCustomer { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string Company { get; set; }

        public decimal? Cost { get; set; }

        public string Description { get; set; }

        public string InteriorProduct1 { get; set; }

        public string InteriorProduct2 { get; set; }

        public string InteriorProduct3 { get; set; }

        public string InteriorBatch1 { get; set; }

        public string InteriorBatch2 { get; set; }

        public string InteriorBatch3 { get; set; }

        public string InteriorDoseNo1 { get; set; }

        public string InteriorDoseNo2 { get; set; }

        public string InteriorDoseNo3 { get; set; }

        public string InteriorDose1 { get; set; }

        public string InteriorDose2 { get; set; }

        public string InteriorDose3 { get; set; }

        public string InteriorPlague1 { get; set; }

        public string InteriorPlague2 { get; set; }

        public string InteriorPlague3 { get; set; }

        public string InteriorMethod1 { get; set; }

        public string InteriorMethod2 { get; set; }

        public string InteriorMethod3 { get; set; }

        public string ExteriorProduct1 { get; set; }

        public string ExteriorProduct2 { get; set; }

        public string ExteriorProduct3 { get; set; }

        public string ExteriorBatch1 { get; set; }

        public string ExteriorBatch2 { get; set; }

        public string ExteriorBatch3 { get; set; }

        public string ExteriorDoseNo1 { get; set; }

        public string ExteriorDoseNo2 { get; set; }

        public string ExteriorDoseNo3 { get; set; }

        public string ExteriorDose1 { get; set; }

        public string ExteriorDose2 { get; set; }

        public string ExteriorDose3 { get; set; }

        public string ExteriorPlague1 { get; set; }

        public string ExteriorPlague2 { get; set; }

        public string ExteriorPlague3 { get; set; }

        public string ExteriorMethod1 { get; set; }

        public string ExteriorMethod2 { get; set; }

        public string ExteriorMethod3 { get; set; }

        public string EventDuration { get; set; }

        public string UVTrap { get; set; }

        public string InsectsTrap { get; set; }

        public string RodentsTrap { get; set; }

        public int IdTechnician1 { get; set; }

        public int IdTechnician2 { get; set; }

        public int IdTechnician3 { get; set; }

        public string StartHour { get; set; }

        public string EndHour { get; set; }

        public string DriveTime { get; set; }

        public string Comments { get; set; }

        public int IsOrdered { get; set; }

        public int? PurchaseOrderNo { get; set; }

        public int IsPayed { get; set; }

        public int IdPaymentMethod { get; set; }

        public int IsBilled { get; set; }

        public int? BillNo { get; set; }

        public int IsComplemented { get; set; }

        public int? ComplementNo { get; set; }

        public string EventType { get; set; }
    }
}