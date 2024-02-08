namespace Cazainsectos.BL.Models
{
    public class EventView : Event
    {
        public string CustomerName { get; set; }

        public string Plagues { get; set; }

        public string Technician1Name { get; set; }

        public string PaymentMethodName { get; set; }
    }
}