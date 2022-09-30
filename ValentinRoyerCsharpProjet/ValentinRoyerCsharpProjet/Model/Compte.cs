namespace ValentinRoyerCsharpProjet.Model
{
    public class Compte
    {
        private int _idCompte;
        private int _solde;
        private int _decouvert;
        private int _idClient;
        private string _typeCompte;
        private int _taux;


        public Compte(int idCompte, int solde, int decouvert, int idClient, string typeCompte, int taux)
        {
            _idCompte = idCompte;
            _solde = solde;
            _decouvert = decouvert;
            _idClient = idClient;
            _typeCompte = typeCompte;
            _taux = taux;
        }


        public int IdCompte
        {
            get { return _idCompte; }
            set { _idCompte = value; }
        }

        public int Solde
        {
            get { return _solde; }
            set { _solde = value; }
        }

        public int Decouvert
        {
            get { return _decouvert; }
            set { _decouvert = value; }
        }

        public int Client
        {
            get { return _idClient; }
            set { _idClient = value; }
        }

        public string TypeCompte
        {
            get { return _typeCompte; }
            set { _typeCompte = value; }
        }

        public int Taux
        {
            get { return _taux; }
            set { _taux = value; }
        }

        public override string ToString()

        {
            return ("N° Compte: " + IdCompte + ", Type de compte: " + TypeCompte + ", Taux: " + Taux + ", Solde: " +
                    Solde + ", Découvert: " + Decouvert);
        }
    }
}