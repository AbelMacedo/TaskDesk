using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace TaskDesk.Data
{
    internal static class Database
    {
        private static readonly string connectionString =
            "Server=Abel\\SQLEXPRESS;Database=TaskDeskDB;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}

