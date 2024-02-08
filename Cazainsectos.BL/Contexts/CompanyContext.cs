using System;
using System.Collections.Generic;
using Cazainsectos.BL.Connections;
using Cazainsectos.BL.Models;
using Cazainsectos.BL.Utils;

namespace Cazainsectos.BL.Contexts
{
    public class CompanyContext
    {
        public int Insert(Company company)
        {
            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_InsertCompany", connection,
                    CazainsectosConnection.SchemaCazainsectos);
                command.Parameters.AddWithValue("name", company.Name);
                command.Parameters.AddWithValue("legalName", company.LegalName);
                command.Parameters.AddWithValue("address", company.Address);
                command.Parameters.AddWithValue("city", company.City);
                command.Parameters.AddWithValue("zipCode", company.ZipCode);
                command.Parameters.AddWithValue("rfc", company.Rfc);
                command.Parameters.AddWithValue("billEmail", company.BillEmail);
                command.Parameters.AddWithValue("billAddress", company.BillAddress);
                command.Parameters.AddWithValue("billZipCode", company.BillZipCode);
                command.Parameters.AddWithValue("idBillEntityType", company.IdBillEntityType);
                command.Parameters.AddWithValue("idBillPaymentMethod", company.IdBillPaymentMethod);
                command.Parameters.AddWithValue("idBillPaymentType", company.IdBillPaymentType);
                command.Parameters.AddWithValue("idBillCfdiUse", company.IdBillCfdiUse);
                command.Parameters.AddWithValue("billComments", company.BillComments);
                command.Parameters.AddWithValue("whatsappReminder", company.WhatsappReminder);

                connection.Open();

                return Convert.ToInt32(command.ExecuteScalar().ToString());
            }
        }

        public void Update(Company company)
        {
            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_UpdateCompany", connection,
                    CazainsectosConnection.SchemaCazainsectos);
                command.Parameters.AddWithValue("companyId", company.Id);
                command.Parameters.AddWithValue("name", company.Name);
                command.Parameters.AddWithValue("legalName", company.LegalName);
                command.Parameters.AddWithValue("address", company.Address);
                command.Parameters.AddWithValue("neighborhood", company.Neighborhood);
                command.Parameters.AddWithValue("city", company.City);
                command.Parameters.AddWithValue("zipCode", company.ZipCode);
                command.Parameters.AddWithValue("rfc", company.Rfc);
                command.Parameters.AddWithValue("billEmail", company.BillEmail);
                command.Parameters.AddWithValue("billAddress", company.BillAddress);
                command.Parameters.AddWithValue("billNeighborhood", company.BillNeighborhood);
                command.Parameters.AddWithValue("billCity", company.BillCity);
                command.Parameters.AddWithValue("billZipCode", company.BillZipCode);
                command.Parameters.AddWithValue("idBillEntityType", company.IdBillEntityType);
                command.Parameters.AddWithValue("idBillPaymentMethod", company.IdBillPaymentMethod);
                command.Parameters.AddWithValue("idBillPaymentType", company.IdBillPaymentType);
                command.Parameters.AddWithValue("idBillCfdiUse", company.IdBillCfdiUse);
                command.Parameters.AddWithValue("billComments", company.BillComments);
                command.Parameters.AddWithValue("whatsappReminder", company.WhatsappReminder);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_DeleteCompany", connection,
                    CazainsectosConnection.SchemaCazainsectos);
                command.Parameters.AddWithValue("companyId", id);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public List<CompanyView> Read()
        {
            var list = new List<CompanyView>();

            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_GetAllCompany", connection,
                    CazainsectosConnection.SchemaCazainsectos);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new CompanyView
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            LegalName = reader["LegalName"].ToString(),
                            Address = reader["Address"].ToString(),
                            Neighborhood = reader["Neighborhood"].ToString(),
                            City = reader["City"].ToString(),
                            ZipCode = reader["ZipCode"].ToString(),
                            WhatsappReminder = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["WhatsappReminder"]))
                        };

                        list.Add(item);
                    }
                }

                return list;
            }
        }

        public Company Read(int id)
        {
            var item = new Company();

            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_GetCompany", connection,
                    CazainsectosConnection.SchemaCazainsectos);
                command.Parameters.AddWithValue("companyId", id);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        item = new Company
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            LegalName = reader["LegalName"].ToString(),
                            Address = reader["Address"].ToString(),
                            Neighborhood = reader["Neighborhood"].ToString(),
                            City = reader["City"].ToString(),
                            ZipCode = reader["ZipCode"].ToString(),
                            Rfc = reader["Rfc"].ToString(),
                            BillEmail = reader["BillEmail"].ToString(),
                            BillAddress = reader["BillAddress"].ToString(),
                            BillNeighborhood = reader["BillNeighborhood"].ToString(),
                            BillCity = reader["BillCity"].ToString(),
                            BillZipCode = reader["BillZipCode"].ToString(),
                            IdBillEntityType = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IdBillEntityType"])),
                            IdBillPaymentMethod =
                                Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IdBillPaymentMethod"])),
                            IdBillPaymentType =
                                Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IdBillPaymentType"])),
                            IdBillCfdiUse = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["IdBillCfdiUse"])),
                            BillComments = reader["BillComments"].ToString(),
                            WhatsappReminder = Convert.ToInt32(DBNullHelper.Null_If_DBNull(reader["WhatsappReminder"]))
                        };
                }

                return item;
            }
        }
    }
}