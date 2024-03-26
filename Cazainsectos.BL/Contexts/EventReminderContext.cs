using System;
using System.Collections.Generic;
using Cazainsectos.BL.Connections;
using Cazainsectos.BL.Models;

namespace Cazainsectos.BL.Contexts
{
    public class EventReminderContext
    {
        public int Insert(EventReminderView eventReminder)
        {
            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_InsertEventReminder", connection,
                    CazainsectosConnection.SchemaCazainsectos);
                command.Parameters.AddWithValue("eventId", eventReminder.Id);
                command.Parameters.AddWithValue("priority", eventReminder.Priority);
                command.Parameters.AddWithValue("category", eventReminder.Category);

                connection.Open();

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public List<EventReminderView> GetLeftReminder(int dayLapse, int priority)
        {
            var list = new List<EventReminderView>();

            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_GetLeftReminder", connection,
                    CazainsectosConnection.SchemaCazainsectos);
                command.Parameters.AddWithValue("dayLapse", dayLapse);
                command.Parameters.AddWithValue("priority", priority);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new EventReminderView
                        {
                            CustomerName = reader["CustomerName"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Company = reader["CompanyName"].ToString(),
                            Id = Convert.ToInt32(reader["LastEventId"]),
                            CustomerType = reader["CustomerType"].ToString(),
                            Number = reader["LastEventNumber"] == DBNull.Value
                                ? (int?)null
                                : Convert.ToInt32(reader["LastEventNumber"]),
                            DayLapse = Convert.ToInt32(reader["DayLapse"]),
                            EventType = reader["EventType"].ToString()
                        };

                        list.Add(item);
                    }
                }

                return list;
            }
        }
    }
}