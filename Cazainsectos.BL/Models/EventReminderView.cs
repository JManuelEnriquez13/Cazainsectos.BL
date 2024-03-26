namespace Cazainsectos.BL.Models
{
    public class EventReminderView : EventView
    {
        public string CustomerType { get; set; }
        public int Priority { get; set; }
        public string Category { get; set; }
        public int DayLapse { get; set; }
    }
}