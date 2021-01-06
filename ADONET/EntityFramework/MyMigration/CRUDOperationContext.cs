using Microsoft.EntityFrameworkCore;
using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EntityFramework.MyMigration
{
    public class CRUDOperationContext:DbContext
    {
        private string connectionstring;
        public CRUDOperationContext(DbContextOptionsBuilder optionsBuilder)
        {

            connectionstring = "Data Source=192.168.50.95;Initial Catalog=sprathipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
