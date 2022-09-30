using System.Collections.Generic;
using ValentinRoyerCsharpProjet.DAL;
using ValentinRoyerCsharpProjet.Model;

namespace ValentinRoyerCsharpProjet.Controller;

public class Manager
{
    CompteDao _compteDao = new();
    ClientDao _clientDao = new();


    public List<Client> ChargementListClients()
    {
        return (_clientDao.GetClients());
    }

    public List<Compte> ChargementListComptes(Client client)
    {
        return (_compteDao.GetComptes(client));
    }

    public void CrediterCompte(Compte compte, int val)
    {
        _compteDao.CrediterCompte(compte, val);
    }

    public void DebiterCompte(Compte compte, int val)
    {
        _compteDao.DebiterCompte(compte, val);
    }

    public void DecouvertCompte(Compte compte, int val)
    {
        _compteDao.DecouvertCompte(compte, val);
    }

    public void ModifClient(Client client, string adresse)
    {
        _clientDao.ModifClient(client, adresse);
    }
}