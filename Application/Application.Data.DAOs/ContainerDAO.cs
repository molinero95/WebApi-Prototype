using Application.Common.Entities.Containers;
using Application.Common.Entities.Containers.Lines;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Application.Data.DAOs
{
    public class ContainerDAO
    {
        public ContainerDAO() { }

        public Container GetContainer(int id, SqlTransaction transaction)
        {
            string sql = "SELECT * FROM Container WHERE ID = @Id";
            Container container = transaction.Connection.Query<Container>(sql, new { Id = id }, transaction)?.ToList()?.First();
            sql = "SELECT * FROM ContainerLines Where ContainerId = @Id";
            List<ContainerLine> lines = transaction.Connection.Query<ContainerLine>(sql, new { Id = id }, transaction)?.ToList();
            if (container != null)
                container.Lines = lines;
            return container;
        }

    }
}
