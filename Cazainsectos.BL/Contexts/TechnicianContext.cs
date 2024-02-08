using System;
using System.Collections.Generic;
using Cazainsectos.BL.Connections;
using Cazainsectos.BL.Models;
using Cazainsectos.BL.Utils;

namespace Cazainsectos.BL.Contexts
{
    public class TechnicianContext
    {
        public int Insert(Technician technician)
        {
            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_InsertTechnician", connection,
                    CazainsectosConnection.SchemaCazainsectos);
                command.Parameters.AddWithValue("name", technician.Name);
                command.Parameters.AddWithValue("lastName", technician.LastName);
                command.Parameters.AddWithValue("address", technician.Address);
                command.Parameters.AddWithValue("city", technician.City);
                command.Parameters.AddWithValue("zipCode", technician.ZipCode);
                command.Parameters.AddWithValue("phoneNumber", technician.PhoneNumber);
                command.Parameters.AddWithValue("email", technician.Email);
                command.Parameters.AddWithValue("hireDate", technician.HireDate);
                command.Parameters.AddWithValue("leaveDate", technician.LeaveDate);
                command.Parameters.AddWithValue("leaveCause", technician.LeaveCause);
                command.Parameters.AddWithValue("active", technician.Active);

                connection.Open();

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public void Update(Technician technician)
        {
            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_UpdateTechnician", connection,
                    CazainsectosConnection.SchemaCazainsectos);
                command.Parameters.AddWithValue("technicianId", technician.Id);
                command.Parameters.AddWithValue("name", technician.Name);
                command.Parameters.AddWithValue("lastName", technician.LastName);
                command.Parameters.AddWithValue("address", technician.Address);
                command.Parameters.AddWithValue("city", technician.City);
                command.Parameters.AddWithValue("zipCode", technician.ZipCode);
                command.Parameters.AddWithValue("phoneNumber", technician.PhoneNumber);
                command.Parameters.AddWithValue("email", technician.Email);
                command.Parameters.AddWithValue("hireDate", technician.HireDate);
                command.Parameters.AddWithValue("leaveDate", technician.LeaveDate);
                command.Parameters.AddWithValue("leaveCause", technician.LeaveCause);
                command.Parameters.AddWithValue("active", technician.Active);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_DeleteTechnician", connection,
                    CazainsectosConnection.SchemaCazainsectos);
                command.Parameters.AddWithValue("technicianId", id);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public List<TechnicianView> Read()
        {
            var list = new List<TechnicianView>();

            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_GetAllTechnician", connection,
                    CazainsectosConnection.SchemaCazainsectos);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new TechnicianView
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Address = reader["Address"].ToString(),
                            City = reader["City"].ToString(),
                            ZipCode = reader["ZipCode"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Email = reader["Email"].ToString(),
                            HireDate = reader["HireDate"].ToString(),
                            LeaveDate = reader["LeaveDate"].ToString(),
                            LeaveCause = reader["LeaveCause"].ToString(),
                            Active = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["Active"]))
                        };

                        list.Add(item);
                    }
                }

                return list;
            }
        }

        public Technician Read(int id)
        {
            var item = new Technician();

            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_GetTechnician", connection,
                    CazainsectosConnection.SchemaCazainsectos);
                command.Parameters.AddWithValue("technicianId", id);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        item = new Technician
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Address = reader["Address"].ToString(),
                            City = reader["City"].ToString(),
                            ZipCode = reader["ZipCode"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Email = reader["Email"].ToString(),
                            HireDate = reader["HireDate"].ToString(),
                            LeaveDate = reader["LeaveDate"].ToString(),
                            LeaveCause = reader["LeaveCause"].ToString(),
                            Active = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["Active"]))
                        };
                }

                return item;
            }
        }
    }
}