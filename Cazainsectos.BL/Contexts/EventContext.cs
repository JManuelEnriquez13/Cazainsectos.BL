using System;
using System.Collections.Generic;
using Cazainsectos.BL.Connections;
using Cazainsectos.BL.Models;
using Cazainsectos.BL.Utils;

namespace Cazainsectos.BL.Contexts
{
    public class EventContext
    {
        public int Insert(Event evt)
        {
            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_InsertEvent", connection,
                    CazainsectosConnection.SchemaCazainsectos);
                command.Parameters.AddWithValue("number", evt.Number);
                command.Parameters.AddWithValue("eventDate", evt.EventDate);
                command.Parameters.AddWithValue("nextDate", evt.NextDate);
                command.Parameters.AddWithValue("idCustomer", evt.IdCustomer);
                command.Parameters.AddWithValue("phoneNumber", evt.PhoneNumber);
                command.Parameters.AddWithValue("address", evt.Address);
                command.Parameters.AddWithValue("company", evt.Company);
                command.Parameters.AddWithValue("cost", evt.Cost);
                command.Parameters.AddWithValue("description", evt.Description);
                command.Parameters.AddWithValue("interiorProduct1", evt.InteriorProduct1);
                command.Parameters.AddWithValue("interiorProduct2", evt.InteriorProduct2);
                command.Parameters.AddWithValue("interiorProduct3", evt.InteriorProduct3);
                command.Parameters.AddWithValue("interiorBatch1", evt.InteriorBatch1);
                command.Parameters.AddWithValue("interiorBatch2", evt.InteriorBatch2);
                command.Parameters.AddWithValue("interiorBatch3", evt.InteriorBatch3);
                command.Parameters.AddWithValue("interiorDoseNo1", evt.InteriorDoseNo1);
                command.Parameters.AddWithValue("interiorDoseNo2", evt.InteriorDoseNo2);
                command.Parameters.AddWithValue("interiorDoseNo3", evt.InteriorDoseNo3);
                command.Parameters.AddWithValue("interiorDose1", evt.InteriorDose1);
                command.Parameters.AddWithValue("interiorDose2", evt.InteriorDose2);
                command.Parameters.AddWithValue("interiorDose3", evt.InteriorDose3);
                command.Parameters.AddWithValue("interiorPlague1", evt.InteriorPlague1);
                command.Parameters.AddWithValue("interiorPlague2", evt.InteriorPlague2);
                command.Parameters.AddWithValue("interiorPlague3", evt.InteriorPlague3);
                command.Parameters.AddWithValue("interiorMethod1", evt.InteriorMethod1);
                command.Parameters.AddWithValue("interiorMethod2", evt.InteriorMethod2);
                command.Parameters.AddWithValue("interiorMethod3", evt.InteriorMethod3);
                command.Parameters.AddWithValue("exteriorProduct1", evt.ExteriorProduct1);
                command.Parameters.AddWithValue("exteriorProduct2", evt.ExteriorProduct2);
                command.Parameters.AddWithValue("exteriorProduct3", evt.ExteriorProduct3);
                command.Parameters.AddWithValue("exteriorBatch1", evt.ExteriorBatch1);
                command.Parameters.AddWithValue("exteriorBatch2", evt.ExteriorBatch2);
                command.Parameters.AddWithValue("exteriorBatch3", evt.ExteriorBatch3);
                command.Parameters.AddWithValue("exteriorDoseNo1", evt.ExteriorDoseNo1);
                command.Parameters.AddWithValue("exteriorDoseNo2", evt.ExteriorDoseNo2);
                command.Parameters.AddWithValue("exteriorDoseNo3", evt.ExteriorDoseNo3);
                command.Parameters.AddWithValue("exteriorDose1", evt.ExteriorDose1);
                command.Parameters.AddWithValue("exteriorDose2", evt.ExteriorDose2);
                command.Parameters.AddWithValue("exteriorDose3", evt.ExteriorDose3);
                command.Parameters.AddWithValue("exteriorPlague1", evt.ExteriorPlague1);
                command.Parameters.AddWithValue("exteriorPlague2", evt.ExteriorPlague2);
                command.Parameters.AddWithValue("exteriorPlague3", evt.ExteriorPlague3);
                command.Parameters.AddWithValue("exteriorMethod1", evt.ExteriorMethod1);
                command.Parameters.AddWithValue("exteriorMethod2", evt.ExteriorMethod2);
                command.Parameters.AddWithValue("exteriorMethod3", evt.ExteriorMethod3);
                command.Parameters.AddWithValue("eventDuration", evt.EventDuration);
                command.Parameters.AddWithValue("uVTrap", evt.UVTrap);
                command.Parameters.AddWithValue("insectsTrap", evt.InsectsTrap);
                command.Parameters.AddWithValue("rodentsTrap", evt.RodentsTrap);
                command.Parameters.AddWithValue("idTechnician1", evt.IdTechnician1);
                command.Parameters.AddWithValue("idTechnician2", evt.IdTechnician2);
                command.Parameters.AddWithValue("idTechnician3", evt.IdTechnician3);
                command.Parameters.AddWithValue("startHour", evt.StartHour);
                command.Parameters.AddWithValue("endHour", evt.EndHour);
                command.Parameters.AddWithValue("driveTime", evt.DriveTime);
                command.Parameters.AddWithValue("comments", evt.Comments);
                command.Parameters.AddWithValue("isOrdered", evt.IsOrdered);
                command.Parameters.AddWithValue("purchaseOrderNo", evt.PurchaseOrderNo);
                command.Parameters.AddWithValue("isPayed", evt.IsPayed);
                command.Parameters.AddWithValue("idPaymentMethod", evt.IdPaymentMethod);
                command.Parameters.AddWithValue("isBilled", evt.IsBilled);
                command.Parameters.AddWithValue("billNo", evt.BillNo);
                command.Parameters.AddWithValue("isComplemented", evt.IsComplemented);
                command.Parameters.AddWithValue("complementNo", evt.ComplementNo);

                connection.Open();

                return Convert.ToInt32(command.ExecuteScalar().ToString());
            }
        }

        public void Update(Event evt)
        {
            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_UpdateEvent", connection,
                    CazainsectosConnection.SchemaCazainsectos);
                command.Parameters.AddWithValue("eventId", evt.Id);
                command.Parameters.AddWithValue("number", evt.Number);
                command.Parameters.AddWithValue("eventDate", evt.EventDate);
                command.Parameters.AddWithValue("nextDate", evt.NextDate);
                command.Parameters.AddWithValue("idCustomer", evt.IdCustomer);
                command.Parameters.AddWithValue("phoneNumber", evt.PhoneNumber);
                command.Parameters.AddWithValue("address", evt.Address);
                command.Parameters.AddWithValue("company", evt.Company);
                command.Parameters.AddWithValue("cost", evt.Cost);
                command.Parameters.AddWithValue("description", evt.Description);
                command.Parameters.AddWithValue("interiorProduct1", evt.InteriorProduct1);
                command.Parameters.AddWithValue("interiorProduct2", evt.InteriorProduct2);
                command.Parameters.AddWithValue("interiorProduct3", evt.InteriorProduct3);
                command.Parameters.AddWithValue("interiorBatch1", evt.InteriorBatch1);
                command.Parameters.AddWithValue("interiorBatch2", evt.InteriorBatch2);
                command.Parameters.AddWithValue("interiorBatch3", evt.InteriorBatch3);
                command.Parameters.AddWithValue("interiorDoseNo1", evt.InteriorDoseNo1);
                command.Parameters.AddWithValue("interiorDoseNo2", evt.InteriorDoseNo2);
                command.Parameters.AddWithValue("interiorDoseNo3", evt.InteriorDoseNo3);
                command.Parameters.AddWithValue("interiorDose1", evt.InteriorDose1);
                command.Parameters.AddWithValue("interiorDose2", evt.InteriorDose2);
                command.Parameters.AddWithValue("interiorDose3", evt.InteriorDose3);
                command.Parameters.AddWithValue("interiorPlague1", evt.InteriorPlague1);
                command.Parameters.AddWithValue("interiorPlague2", evt.InteriorPlague2);
                command.Parameters.AddWithValue("interiorPlague3", evt.InteriorPlague3);
                command.Parameters.AddWithValue("interiorMethod1", evt.InteriorMethod1);
                command.Parameters.AddWithValue("interiorMethod2", evt.InteriorMethod2);
                command.Parameters.AddWithValue("interiorMethod3", evt.InteriorMethod3);
                command.Parameters.AddWithValue("exteriorProduct1", evt.ExteriorProduct1);
                command.Parameters.AddWithValue("exteriorProduct2", evt.ExteriorProduct2);
                command.Parameters.AddWithValue("exteriorProduct3", evt.ExteriorProduct3);
                command.Parameters.AddWithValue("exteriorBatch1", evt.ExteriorBatch1);
                command.Parameters.AddWithValue("exteriorBatch2", evt.ExteriorBatch2);
                command.Parameters.AddWithValue("exteriorBatch3", evt.ExteriorBatch3);
                command.Parameters.AddWithValue("exteriorDoseNo1", evt.ExteriorDoseNo1);
                command.Parameters.AddWithValue("exteriorDoseNo2", evt.ExteriorDoseNo2);
                command.Parameters.AddWithValue("exteriorDoseNo3", evt.ExteriorDoseNo3);
                command.Parameters.AddWithValue("exteriorDose1", evt.ExteriorDose1);
                command.Parameters.AddWithValue("exteriorDose2", evt.ExteriorDose2);
                command.Parameters.AddWithValue("exteriorDose3", evt.ExteriorDose3);
                command.Parameters.AddWithValue("exteriorPlague1", evt.ExteriorPlague1);
                command.Parameters.AddWithValue("exteriorPlague2", evt.ExteriorPlague2);
                command.Parameters.AddWithValue("exteriorPlague3", evt.ExteriorPlague3);
                command.Parameters.AddWithValue("exteriorMethod1", evt.ExteriorMethod1);
                command.Parameters.AddWithValue("exteriorMethod2", evt.ExteriorMethod2);
                command.Parameters.AddWithValue("exteriorMethod3", evt.ExteriorMethod3);
                command.Parameters.AddWithValue("eventDuration", evt.EventDuration);
                command.Parameters.AddWithValue("uVTrap", evt.UVTrap);
                command.Parameters.AddWithValue("insectsTrap", evt.InsectsTrap);
                command.Parameters.AddWithValue("rodentsTrap", evt.RodentsTrap);
                command.Parameters.AddWithValue("idTechnician1", evt.IdTechnician1);
                command.Parameters.AddWithValue("idTechnician2", evt.IdTechnician2);
                command.Parameters.AddWithValue("idTechnician3", evt.IdTechnician3);
                command.Parameters.AddWithValue("startHour", evt.StartHour);
                command.Parameters.AddWithValue("endHour", evt.EndHour);
                command.Parameters.AddWithValue("driveTime", evt.DriveTime);
                command.Parameters.AddWithValue("comments", evt.Comments);
                command.Parameters.AddWithValue("isOrdered", evt.IsOrdered);
                command.Parameters.AddWithValue("purchaseOrderNo", evt.PurchaseOrderNo);
                command.Parameters.AddWithValue("isPayed", evt.IsPayed);
                command.Parameters.AddWithValue("idPaymentMethod", evt.IdPaymentMethod);
                command.Parameters.AddWithValue("isBilled", evt.IsBilled);
                command.Parameters.AddWithValue("billNo", evt.BillNo);
                command.Parameters.AddWithValue("isComplemented", evt.IsComplemented);
                command.Parameters.AddWithValue("complementNo", evt.ComplementNo);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void UpdatePaymentInfo(Event evt)
        {
            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_UpdateEventPaymentInfo", connection,
                    CazainsectosConnection.SchemaCazainsectos);
                command.Parameters.AddWithValue("eventId", evt.Id);
                command.Parameters.AddWithValue("isOrdered", evt.IsOrdered);
                command.Parameters.AddWithValue("purchaseOrderNo", evt.PurchaseOrderNo);
                command.Parameters.AddWithValue("isPayed", evt.IsPayed);
                command.Parameters.AddWithValue("idPaymentMethod", evt.IdPaymentMethod);
                command.Parameters.AddWithValue("isBilled", evt.IsBilled);
                command.Parameters.AddWithValue("billNo", evt.BillNo);
                command.Parameters.AddWithValue("isComplemented", evt.IsComplemented);
                command.Parameters.AddWithValue("complementNo", evt.ComplementNo);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_DeleteEvent", connection,
                    CazainsectosConnection.SchemaCazainsectos);
                command.Parameters.AddWithValue("eventId", id);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public List<EventView> Read()
        {
            var list = new List<EventView>();

            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_GetAllEvent", connection,
                    CazainsectosConnection.SchemaCazainsectos);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new EventView
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Number = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["Number"])),
                            EventDate = reader["EventDate"].ToString(),
                            NextDate = reader["NextDate"].ToString(),
                            IdCustomer = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IdCustomer"])),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Address = reader["Address"].ToString(),
                            Company = reader["Company"].ToString(),
                            Cost = Convert.ToDecimal(DBNullHelper.Null_If_DBNull(reader["Cost"])),
                            Description = reader["Description"].ToString(),
                            InteriorProduct1 = reader["InteriorProduct1"].ToString(),
                            InteriorProduct2 = reader["InteriorProduct2"].ToString(),
                            InteriorProduct3 = reader["InteriorProduct3"].ToString(),
                            InteriorBatch1 = reader["InteriorBatch1"].ToString(),
                            InteriorBatch2 = reader["InteriorBatch2"].ToString(),
                            InteriorBatch3 = reader["InteriorBatch3"].ToString(),
                            InteriorDoseNo1 = reader["InteriorDoseNo1"].ToString(),
                            InteriorDoseNo2 = reader["InteriorDoseNo2"].ToString(),
                            InteriorDoseNo3 = reader["InteriorDoseNo3"].ToString(),
                            InteriorDose1 = reader["InteriorDose1"].ToString(),
                            InteriorDose2 = reader["InteriorDose2"].ToString(),
                            InteriorDose3 = reader["InteriorDose3"].ToString(),
                            InteriorPlague1 = reader["InteriorPlague1"].ToString(),
                            InteriorPlague2 = reader["InteriorPlague2"].ToString(),
                            InteriorPlague3 = reader["InteriorPlague3"].ToString(),
                            InteriorMethod1 = reader["InteriorMethod1"].ToString(),
                            InteriorMethod2 = reader["InteriorMethod2"].ToString(),
                            InteriorMethod3 = reader["InteriorMethod3"].ToString(),
                            ExteriorProduct1 = reader["ExteriorProduct1"].ToString(),
                            ExteriorProduct2 = reader["ExteriorProduct2"].ToString(),
                            ExteriorProduct3 = reader["ExteriorProduct3"].ToString(),
                            ExteriorBatch1 = reader["ExteriorBatch1"].ToString(),
                            ExteriorBatch2 = reader["ExteriorBatch2"].ToString(),
                            ExteriorBatch3 = reader["ExteriorBatch3"].ToString(),
                            ExteriorDoseNo1 = reader["ExteriorDoseNo1"].ToString(),
                            ExteriorDoseNo2 = reader["ExteriorDoseNo2"].ToString(),
                            ExteriorDoseNo3 = reader["ExteriorDoseNo3"].ToString(),
                            ExteriorDose1 = reader["ExteriorDose1"].ToString(),
                            ExteriorDose2 = reader["ExteriorDose2"].ToString(),
                            ExteriorDose3 = reader["ExteriorDose3"].ToString(),
                            ExteriorPlague1 = reader["ExteriorPlague1"].ToString(),
                            ExteriorPlague2 = reader["ExteriorPlague2"].ToString(),
                            ExteriorPlague3 = reader["ExteriorPlague3"].ToString(),
                            ExteriorMethod1 = reader["ExteriorMethod1"].ToString(),
                            ExteriorMethod2 = reader["ExteriorMethod2"].ToString(),
                            ExteriorMethod3 = reader["ExteriorMethod3"].ToString(),
                            EventDuration = reader["EventDuration"].ToString(),
                            UVTrap = reader["UVTrap"].ToString(),
                            InsectsTrap = reader["InsectsTrap"].ToString(),
                            RodentsTrap = reader["RodentsTrap"].ToString(),
                            IdTechnician1 = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IdTechnician1"])),
                            IdTechnician2 = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IdTechnician2"])),
                            IdTechnician3 = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IdTechnician3"])),
                            StartHour = reader["StartHour"].ToString(),
                            EndHour = reader["EndHour"].ToString(),
                            DriveTime = reader["DriveTime"].ToString(),
                            Comments = reader["Comments"].ToString(),
                            IdPaymentMethod = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IdPaymentMethod"])),
                            IsPayed = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IsPayed"])),
                            IsOrdered = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IsOrdered"])),
                            PurchaseOrderNo = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["PurchaseOrderNo"])),
                            IsBilled = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IsBilled"])),
                            BillNo = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["BillNo"])),
                            IsComplemented = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IsComplemented"])),
                            ComplementNo = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["ComplementNo"])),
                            CustomerName = reader["CustomerName"].ToString(),
                            Plagues = reader["Plagues"].ToString(),
                            Technician1Name = reader["Technician1Name"].ToString(),
                            PaymentMethodName = reader["PaymentMethodName"].ToString()
                        };

                        list.Add(item);
                    }
                }

                return list;
            }
        }

        public Event Read(int id)
        {
            var item = new Event();

            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_GetEvent", connection,
                    CazainsectosConnection.SchemaCazainsectos);
                command.Parameters.AddWithValue("eventId", id);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        item = new Event
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Number = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["Number"])),
                            EventDate = reader["EventDate"].ToString(),
                            NextDate = reader["NextDate"].ToString(),
                            IdCustomer = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IdCustomer"])),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Address = reader["Address"].ToString(),
                            Company = reader["Company"].ToString(),
                            Cost = Convert.ToDecimal(DBNullHelper.Null_If_DBNull(reader["Cost"])),
                            Description = reader["Description"].ToString(),
                            InteriorProduct1 = reader["InteriorProduct1"].ToString(),
                            InteriorProduct2 = reader["InteriorProduct2"].ToString(),
                            InteriorProduct3 = reader["InteriorProduct3"].ToString(),
                            InteriorBatch1 = reader["InteriorBatch1"].ToString(),
                            InteriorBatch2 = reader["InteriorBatch2"].ToString(),
                            InteriorBatch3 = reader["InteriorBatch3"].ToString(),
                            InteriorDoseNo1 = reader["InteriorDoseNo1"].ToString(),
                            InteriorDoseNo2 = reader["InteriorDoseNo2"].ToString(),
                            InteriorDoseNo3 = reader["InteriorDoseNo3"].ToString(),
                            InteriorDose1 = reader["InteriorDose1"].ToString(),
                            InteriorDose2 = reader["InteriorDose2"].ToString(),
                            InteriorDose3 = reader["InteriorDose3"].ToString(),
                            InteriorPlague1 = reader["InteriorPlague1"].ToString(),
                            InteriorPlague2 = reader["InteriorPlague2"].ToString(),
                            InteriorPlague3 = reader["InteriorPlague3"].ToString(),
                            InteriorMethod1 = reader["InteriorMethod1"].ToString(),
                            InteriorMethod2 = reader["InteriorMethod2"].ToString(),
                            InteriorMethod3 = reader["InteriorMethod3"].ToString(),
                            ExteriorProduct1 = reader["ExteriorProduct1"].ToString(),
                            ExteriorProduct2 = reader["ExteriorProduct2"].ToString(),
                            ExteriorProduct3 = reader["ExteriorProduct3"].ToString(),
                            ExteriorBatch1 = reader["ExteriorBatch1"].ToString(),
                            ExteriorBatch2 = reader["ExteriorBatch2"].ToString(),
                            ExteriorBatch3 = reader["ExteriorBatch3"].ToString(),
                            ExteriorDoseNo1 = reader["ExteriorDoseNo1"].ToString(),
                            ExteriorDoseNo2 = reader["ExteriorDoseNo2"].ToString(),
                            ExteriorDoseNo3 = reader["ExteriorDoseNo3"].ToString(),
                            ExteriorDose1 = reader["ExteriorDose1"].ToString(),
                            ExteriorDose2 = reader["ExteriorDose2"].ToString(),
                            ExteriorDose3 = reader["ExteriorDose3"].ToString(),
                            ExteriorPlague1 = reader["ExteriorPlague1"].ToString(),
                            ExteriorPlague2 = reader["ExteriorPlague2"].ToString(),
                            ExteriorPlague3 = reader["ExteriorPlague3"].ToString(),
                            ExteriorMethod1 = reader["ExteriorMethod1"].ToString(),
                            ExteriorMethod2 = reader["ExteriorMethod2"].ToString(),
                            ExteriorMethod3 = reader["ExteriorMethod3"].ToString(),
                            EventDuration = reader["EventDuration"].ToString(),
                            UVTrap = reader["UVTrap"].ToString(),
                            InsectsTrap = reader["InsectsTrap"].ToString(),
                            RodentsTrap = reader["RodentsTrap"].ToString(),
                            IdTechnician1 = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IdTechnician1"])),
                            IdTechnician2 = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IdTechnician2"])),
                            IdTechnician3 = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IdTechnician3"])),
                            StartHour = reader["StartHour"].ToString(),
                            EndHour = reader["EndHour"].ToString(),
                            DriveTime = reader["DriveTime"].ToString(),
                            Comments = reader["Comments"].ToString(),
                            IdPaymentMethod = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IdPaymentMethod"])),
                            IsPayed = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IsPayed"])),
                            IsOrdered = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IsOrdered"])),
                            PurchaseOrderNo = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["PurchaseOrderNo"])),
                            IsBilled = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IsBilled"])),
                            BillNo = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["BillNo"])),
                            IsComplemented = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IsComplemented"])),
                            ComplementNo = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["ComplementNo"]))
                        };
                }

                return item;
            }
        }

        public Event GetByNumber(int eventNumber)
        {
            var item = new Event();

            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_GetEventByNumber", connection,
                    CazainsectosConnection.SchemaCazainsectos);
                command.Parameters.AddWithValue("eventNumber", eventNumber);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        item = new Event
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Number = Convert.ToInt32(reader["Number"]),
                            EventDate = reader["EventDate"].ToString(),
                            NextDate = reader["NextDate"].ToString(),
                            IdCustomer = Convert.ToInt32(reader["IdCustomer"]),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Address = reader["Address"].ToString(),
                            Company = reader["Company"].ToString(),
                            Cost = Convert.ToDecimal(reader["Cost"]),
                            Description = reader["Description"].ToString(),
                            InteriorProduct1 = reader["InteriorProduct1"].ToString(),
                            InteriorProduct2 = reader["InteriorProduct2"].ToString(),
                            InteriorProduct3 = reader["InteriorProduct3"].ToString(),
                            InteriorBatch1 = reader["InteriorBatch1"].ToString(),
                            InteriorBatch2 = reader["InteriorBatch2"].ToString(),
                            InteriorBatch3 = reader["InteriorBatch3"].ToString(),
                            InteriorDoseNo1 = reader["InteriorDoseNo1"].ToString(),
                            InteriorDoseNo2 = reader["InteriorDoseNo2"].ToString(),
                            InteriorDoseNo3 = reader["InteriorDoseNo3"].ToString(),
                            InteriorDose1 = reader["InteriorDose1"].ToString(),
                            InteriorDose2 = reader["InteriorDose2"].ToString(),
                            InteriorDose3 = reader["InteriorDose3"].ToString(),
                            InteriorPlague1 = reader["InteriorPlague1"].ToString(),
                            InteriorPlague2 = reader["InteriorPlague2"].ToString(),
                            InteriorPlague3 = reader["InteriorPlague3"].ToString(),
                            InteriorMethod1 = reader["InteriorMethod1"].ToString(),
                            InteriorMethod2 = reader["InteriorMethod2"].ToString(),
                            InteriorMethod3 = reader["InteriorMethod3"].ToString(),
                            ExteriorProduct1 = reader["ExteriorProduct1"].ToString(),
                            ExteriorProduct2 = reader["ExteriorProduct2"].ToString(),
                            ExteriorProduct3 = reader["ExteriorProduct3"].ToString(),
                            ExteriorBatch1 = reader["ExteriorBatch1"].ToString(),
                            ExteriorBatch2 = reader["ExteriorBatch2"].ToString(),
                            ExteriorBatch3 = reader["ExteriorBatch3"].ToString(),
                            ExteriorDoseNo1 = reader["ExteriorDoseNo1"].ToString(),
                            ExteriorDoseNo2 = reader["ExteriorDoseNo2"].ToString(),
                            ExteriorDoseNo3 = reader["ExteriorDoseNo3"].ToString(),
                            ExteriorDose1 = reader["ExteriorDose1"].ToString(),
                            ExteriorDose2 = reader["ExteriorDose2"].ToString(),
                            ExteriorDose3 = reader["ExteriorDose3"].ToString(),
                            ExteriorPlague1 = reader["ExteriorPlague1"].ToString(),
                            ExteriorPlague2 = reader["ExteriorPlague2"].ToString(),
                            ExteriorPlague3 = reader["ExteriorPlague3"].ToString(),
                            ExteriorMethod1 = reader["ExteriorMethod1"].ToString(),
                            ExteriorMethod2 = reader["ExteriorMethod2"].ToString(),
                            ExteriorMethod3 = reader["ExteriorMethod3"].ToString(),
                            EventDuration = reader["EventDuration"].ToString(),
                            UVTrap = reader["UVTrap"].ToString(),
                            InsectsTrap = reader["InsectsTrap"].ToString(),
                            RodentsTrap = reader["RodentsTrap"].ToString(),
                            IdTechnician1 = Convert.ToInt32(reader["IdTechnician1"]),
                            IdTechnician2 = Convert.ToInt32(reader["IdTechnician2"]),
                            IdTechnician3 = Convert.ToInt32(reader["IdTechnician3"]),
                            StartHour = reader["StartHour"].ToString(),
                            EndHour = reader["EndHour"].ToString(),
                            DriveTime = reader["DriveTime"].ToString(),
                            Comments = reader["Comments"].ToString(),
                            IdPaymentMethod = Convert.ToInt32(reader["IdPaymentMethod"]),
                            IsPayed = Convert.ToInt32(reader["IsPayed"]),
                            IsOrdered = Convert.ToInt32(reader["IsOrdered"]),
                            PurchaseOrderNo = Convert.ToInt32(reader["PurchaseOrderNo"]),
                            IsBilled = Convert.ToInt32(reader["IsBilled"]),
                            BillNo = Convert.ToInt32(reader["BillNo"]),
                            IsComplemented = Convert.ToInt32(reader["IsComplemented"]),
                            ComplementNo = Convert.ToInt32(reader["ComplementNo"])
                        };
                }

                return item;
            }
        }
    }
}