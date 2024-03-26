using Cazainsectos.BL.Connections;
using Cazainsectos.BL.Models;

namespace Cazainsectos.BL.Contexts
{
    public class UnsubscriptionContext
    {
        public void Insert(Unsubscription unsubscription)
        {
            using (var connection = CazainsectosConnection.NewConnectionWeb())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_InsertUnsubscription", connection,
                    CazainsectosConnection.SchemaCazainsectos);
                command.Parameters.AddWithValue("idCustomer", unsubscription.IdCustomer);
                command.Parameters.AddWithValue("phoneNumber", unsubscription.PhoneNumber);
                command.Parameters.AddWithValue("reason", unsubscription.Reason);
                command.Parameters.AddWithValue("comments", unsubscription.Comments);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}