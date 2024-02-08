using System.Collections.Generic;

namespace Cazainsectos.BL.Models
{
    public class CalendarEvent
    {
        public CalendarEvent()
        {
            attendees = new List<Attendee>();
        }

        public string kind { get; set; }

        public string summary { get; set; }

        public Creator creator { get; set; }

        public Organizer organizer { get; set; }

        public Start start { get; set; }

        public End end { get; set; }

        public List<Attendee> attendees { get; set; }
    }

    public class Creator
    {
        public string email { get; set; }
        public bool self { get; set; }
    }

    public class Organizer
    {
        public string email { get; set; }
        public bool self { get; set; }
    }

    public class Start
    {
        public string dateTime { get; set; }
    }

    public class End
    {
        public string dateTime { get; set; }
    }

    public class Attendee
    {
        public string email { get; set; }
        public string responseStatus { get; set; }
    }
}