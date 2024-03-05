namespace TodoMandeha.Models
{
    public class Inscription
    {
        private string _utiliasteurid;
        private string _utilisateurnom;
        private string _utilisateurprenom;
        private string _utilisateuradresse;
        private string _utilsateuremail;
        private string _password;
        private string _comfirmpassword;

        //Constructeur avec id
        public Inscription(string utiliasteurid, string utilisateurnom, string utilisateurprenom, string utilisateuradresse, string utilsateuremail, string password, string comfirmpassword)
        {
            _utiliasteurid = utiliasteurid;
            _utilisateurnom = utilisateurnom;
            _utilisateurprenom = utilisateurprenom;
            _utilisateuradresse = utilisateuradresse;
            _utilsateuremail = utilsateuremail;
            _password = password;
            _comfirmpassword = comfirmpassword;
        }

        //get and set
        public string Utiliasteurid { get => _utiliasteurid; set => _utiliasteurid = value; }
        public string Utilisateurnom { get => _utilisateurnom; set => _utilisateurnom = value; }
        public string Utilisateurprenom { get => _utilisateurprenom; set => _utilisateurprenom = value; }
        public string Utilisateuradresse { get => _utilisateuradresse; set => _utilisateuradresse = value; }
        public string Utilsateuremail { get => _utilsateuremail; set => _utilsateuremail = value; }
        public string Password { get => _password; set => _password = value; }
        public string Comfirmpassword { get => _comfirmpassword; set => _comfirmpassword = value; }

        //contructeur sans id
        public Inscription(string utilisateurnom, string utilisateurprenom, string utilisateuradresse, string utilsateuremail, string password, string comfirmpassword)
        {
            _utilisateurnom = utilisateurnom;
            _utilisateurprenom = utilisateurprenom;
            _utilisateuradresse = utilisateuradresse;
            _utilsateuremail = utilsateuremail;
            _password = password;
            _comfirmpassword = comfirmpassword;
        }

        //
        public Inscription()
        {
        }
    }
}