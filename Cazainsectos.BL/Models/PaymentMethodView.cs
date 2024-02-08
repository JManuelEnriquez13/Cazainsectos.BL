namespace Cazainsectos.BL.Models
{
    public class PaymentMethodView : PaymentMethod
    {
        public string SearchProperty => Name;
    }
}