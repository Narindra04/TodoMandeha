using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoMandeha.Models
{
    public class Utilisateur
    {
        private string _username;
        private string _password;
        public string Password { get => _password; set => _password = value; }
        public string Username { get => _username; set => _username = value; }

        public Utilisateur() { }
        public Utilisateur(string username, string password)
        {
            _username = username;
            _password = password;
        }
    }
}