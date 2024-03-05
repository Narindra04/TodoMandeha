using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TodoMandeha.Models
{
    public class DBConnexion
    {
        public static NpgsqlConnection connectionString =
            new NpgsqlConnection(ConfigurationManager.ConnectionStrings["todolist"].ConnectionString);

        public static bool VerifierUtilisateur(Utilisateur utilisateur)
        {
            var request = "SELECT * FROM public.\"User\" WHERE username='" + utilisateur.Username + "' AND password='" + utilisateur.Password + "'";
            var hasUser = false;
            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand(request, connectionString);
                var reader = cmd.ExecuteReader();
                hasUser = reader.HasRows;
                connectionString.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return hasUser;
        }

        public static List<Tache> retrouverTaches(string utilisateur)
        {
            var req = "SELECT * FROM public.\"Tache\" WHERE username= '" +utilisateur+"' ";
            var hasTask = new List<Tache>();

            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand(req, connectionString);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var Task = new Tache(reader.GetInt32(0), reader["description"].ToString(), reader["username"].ToString(), reader.GetBoolean(3));
                    hasTask.Add(Task);
                }
                connectionString.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return hasTask;
        }

        public static void AjoutTache(Tache tache)
        {
            var hasTask = new List<Tache>();
            var req = "INSERT INTO public.\"Tache\" (description, username, state) VALUES ('" + tache.Description + "' , '" + tache.Username + "'," + tache.State + ")";


            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand(req, connectionString);
                cmd.ExecuteNonQuery();
                hasTask = retrouverTaches(tache.Username);
                connectionString.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}