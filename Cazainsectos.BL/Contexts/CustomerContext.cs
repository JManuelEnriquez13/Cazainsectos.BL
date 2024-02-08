using System;
using System.Collections.Generic;
using Cazainsectos.BL.Connections;
using Cazainsectos.BL.Models;
using Cazainsectos.BL.Utils;

namespace Cazainsectos.BL.Contexts
{
    public class CustomerContext
    {
        public int Insert(Customer customer)
        {
            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_InsertCustomer", connection,
                    CazainsectosConnection.SchemaCazainsectos);
                command.Parameters.AddWithValue("idPrefix", customer.IdPrefix);
                command.Parameters.AddWithValue("name", customer.Name);
                command.Parameters.AddWithValue("lastName", customer.LastName);
                command.Parameters.AddWithValue("address", customer.Address);
                command.Parameters.AddWithValue("neighborhood", customer.Neighborhood);
                command.Parameters.AddWithValue("city", customer.City);
                command.Parameters.AddWithValue("zipCode", customer.ZipCode);
                command.Parameters.AddWithValue("phoneNumber", customer.PhoneNumber);
                command.Parameters.AddWithValue("email", customer.Email);
                command.Parameters.AddWithValue("idCompany", customer.IdCompany);
                command.Parameters.AddWithValue("rfc", customer.Rfc);
                command.Parameters.AddWithValue("whatsappReminder", customer.WhatsappReminder);

                connection.Open();

                return Convert.ToInt32(command.ExecuteScalar().ToString());
            }
        }

        public void Update(Customer customer)
        {
            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_UpdateCustomer", connection,
                    CazainsectosConnection.SchemaCazainsectos);
                command.Parameters.AddWithValue("customerId", customer.Id);
                command.Parameters.AddWithValue("idPrefix", customer.IdPrefix);
                command.Parameters.AddWithValue("name", customer.Name);
                command.Parameters.AddWithValue("lastName", customer.LastName);
                command.Parameters.AddWithValue("address", customer.Address);
                command.Parameters.AddWithValue("neighborhood", customer.Neighborhood);
                command.Parameters.AddWithValue("city", customer.City);
                command.Parameters.AddWithValue("zipCode", customer.ZipCode);
                command.Parameters.AddWithValue("phoneNumber", customer.PhoneNumber);
                command.Parameters.AddWithValue("email", customer.Email);
                command.Parameters.AddWithValue("idCompany", customer.IdCompany);
                command.Parameters.AddWithValue("rfc", customer.Rfc);
                command.Parameters.AddWithValue("whatsappReminder", customer.WhatsappReminder);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_DeleteCustomer", connection,
                    CazainsectosConnection.SchemaCazainsectos);
                command.Parameters.AddWithValue("customerId", id);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public List<CustomerView> Read()
        {
            var list = new List<CustomerView>();

            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_GetAllCustomer", connection,
                    CazainsectosConnection.SchemaCazainsectos);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new CustomerView
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            IdPrefix = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IdPrefix"])),
                            Name = reader["Name"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Email = reader["Email"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            IdCompany = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IdCompany"])),
                            Rfc = reader["Rfc"].ToString(),
                            PrefixName = reader["PrefixName"].ToString(),
                            CompanyName = reader["CompanyName"].ToString(),
                            Address = reader["Address"].ToString(),
                            WhatsappReminder = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["WhatsappReminder"]))
                        };

                        list.Add(item);
                    }
                }

                return list;
            }
        }

        public Customer Read(int id)
        {
            var item = new Customer();

            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_GetCustomer", connection,
                    CazainsectosConnection.SchemaCazainsectos);
                command.Parameters.AddWithValue("customerId", id);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        item = new Customer
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            IdPrefix = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IdPrefix"])),
                            Name = reader["Name"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Address = reader["Address"].ToString(),
                            Neighborhood = reader["Neighborhood"].ToString(),
                            City = reader["City"].ToString(),
                            ZipCode = reader["ZipCode"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Email = reader["Email"].ToString(),
                            IdCompany = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IdCompany"])),
                            Rfc = reader["Rfc"].ToString(),
                            WhatsappReminder = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["WhatsappReminder"]))
                        };
                }

                return item;
            }
        }
    }
}