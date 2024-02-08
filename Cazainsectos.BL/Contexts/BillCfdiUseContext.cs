using System;
using System.Collections.Generic;
using Cazainsectos.BL.Connections;
using Cazainsectos.BL.Models;

namespace Cazainsectos.BL.Contexts
{
    public class BillCfdiUseContext
    {
        public List<BillCfdiUseView> Read()
        {
            var list = new List<BillCfdiUseView>();

            using (var connection = CazainsectosConnection.NewConnection())
            {
                var command = CazainsectosConnection.NewStoredProcedure("usp_GetAllBillCfdiUse", connection,
                    CazainsectosConnection.SchemaCazainsectos);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new BillCfdiUseView
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString()
                        };

                        list.Add(item);
                    }
                }

                return list;
            }
        }
    }
}