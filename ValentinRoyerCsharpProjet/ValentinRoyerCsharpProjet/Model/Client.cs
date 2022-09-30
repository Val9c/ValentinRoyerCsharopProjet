using System.Collections.Generic;

namespace ValentinRoyerCsharpProjet.Model;

public class Client
{
    private int _idClient;
    private string _prenom;
    private string _nom;
    private string _adresse;
    private List<Compte> _comptes = new List<Compte>();

    public Client(int idClient, string nom, string prenom, string adresse)
    {
        _idClient = idClient;
        _nom = nom;
        _prenom = prenom;
        _adresse = adresse;
    }

    public int IdClient
    {
        get { return _idClient; }
        set { _idClient = value; }
    }

    public string Prénom
    {
        get { return _prenom; }
        set { _prenom = value; }
    }

    public string Nom
    {
        get { return _nom; }
        set { _nom = value; }
    }


    public string Adresse
    {
        get { return _adresse; }
        set { _adresse = value; }
    }

    public override string ToString()

    {
        return ("N°Client: " + IdClient + ", Nom: " + Nom + ", Prénom: " + Prénom + ", Adresse: " + Adresse);
    }
}