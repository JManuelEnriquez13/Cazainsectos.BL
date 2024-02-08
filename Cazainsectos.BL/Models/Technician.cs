using System;

namespace Cazainsectos.BL.Models
{
    public class Technician
    {
        private string _hireDate;

        private string _leaveDate;
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string HireDate
        {
            get
            {
                if (!string.IsNullOrEmpty(_hireDate)) _hireDate = Convert.ToDateTime(_hireDate).ToString("dd/MM/yyyy");

                return _hireDate;
            }
            set => _hireDate = value;
        }

        public string LeaveDate
        {
            get
            {
                if (!string.IsNullOrEmpty(_leaveDate))
                    _leaveDate = Convert.ToDateTime(_leaveDate).ToString("dd/MM/yyyy");

                return _leaveDate;
            }
            set => _leaveDate = value;
        }

        public string LeaveCause { get; set; }

        public int Active { get; set; }
    }
}