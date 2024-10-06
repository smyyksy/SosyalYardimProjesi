using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SosyalYardimProjesi
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString = "Server=.;Database=SosyalYardimDB;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
