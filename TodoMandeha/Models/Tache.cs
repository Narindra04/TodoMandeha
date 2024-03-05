using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoMandeha.Models
{
    public class Tache
    {

        private int _tacheid;
        private string _username;
        private string _description;
        private bool _state;

        public Tache() { }

        public Tache(int tacheid, string username, string description, bool state)
        {
            _tacheid = tacheid;
            _username = username;
            _description = description;
            _state = state;
        }
        public Tache (int tacheid, string username, string description)
        {
            _tacheid= tacheid;
            _username = username;
            _description = description;
        }
        public int Tacheid
        {
            get { return _tacheid; }
            set { _tacheid = value; }
        }



        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }


        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }



        public bool State
        {
            get { return _state; }
            set { _state = value; }
        }
    }
}