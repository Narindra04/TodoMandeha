using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TodoMandeha.Models
{
    public static class DBConnexion
    {
        public static NpgsqlConnection connectionString =
            new NpgsqlConnection(ConfigurationManager.ConnectionStrings["todolist"].ConnectionString);
    }
}