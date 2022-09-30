using System;
using System.Collections.Generic;
using System.Windows;
using MySql.Data.MySqlClient;
using ValentinRoyerCsharpProjet.Model;

namespace ValentinRoyerCsharpProjet.DAL;

public class CompteDao
{
    private Client _compteClient;

    private ConnectionSql _maConnectionSql;


    private MySqlCommand _ocom;


    public List<Compte> GetComptes(Client cl)
    {
        List<Compte> listComptes = new List<Compte>();

        try
        {
            _maConnectionSql = ConnectionSql.GetInstance(InfoLogSql.ProviderMysql, InfoLogSql.DataBaseMysql,
                InfoLogSql.UidMysql,
                InfoLogSql.MdpMysql);


            _maConnectionSql.OpenConnection();


            _ocom = _maConnectionSql.ReqExec("Select * from compte where idClient= " + cl.IdClient);

            MySqlDataReader reader = _ocom.ExecuteReader();


            while (reader.Read())
            {
                int idCompte = (int) reader.GetValue(0);
                int solde = (int) reader.GetValue(1);
                int decouvert = (int) reader.GetValue(2);
                int idClient = (int) reader.GetValue(3);
                string typeCompte = (string) reader.GetValue(4);
                int taux = (int) reader.GetValue(5);

                Compte c = new Compte(idCompte, solde, decouvert, idClient, typeCompte, taux);

                listComptes.Add(c);
            }

            reader.Close();

            _maConnectionSql.CloseConnection();

            return (listComptes);
        }

        catch (Exception emp)
        {
            MessageBox.Show(emp.Message);
        }

        return (listComptes);
    }


    public void CrediterCompte(Compte compte, int val)
    {
        try
        {
            _maConnectionSql = ConnectionSql.GetInstance(InfoLogSql.ProviderMysql, InfoLogSql.DataBaseMysql,
                InfoLogSql.UidMysql,
                InfoLogSql.MdpMysql);


            _maConnectionSql.OpenConnection();

            var newValeur = compte.Solde + val;

            _ocom = _maConnectionSql.ReqExec("UPDATE compte set Solde = " + newValeur + " where idCompte = " +
                                           compte.IdCompte + ";");
            _ocom.ExecuteNonQuery();

            _maConnectionSql.CloseConnection();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void DebiterCompte(Compte compte, int val)
    {
        try
        {
            _maConnectionSql = ConnectionSql.GetInstance(InfoLogSql.ProviderMysql, InfoLogSql.DataBaseMysql,
                InfoLogSql.UidMysql,
                InfoLogSql.MdpMysql);


            _maConnectionSql.OpenConnection();

            var newValeur = compte.Solde - val;

            _ocom = _maConnectionSql.ReqExec("UPDATE compte set Solde = " + newValeur + " where idCompte = " +
                                           compte.IdCompte + ";");
            _ocom.ExecuteNonQuery();

            _maConnectionSql.CloseConnection();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void DecouvertCompte(Compte compte, int val)
    {
        try
        {
            _maConnectionSql = ConnectionSql.GetInstance(InfoLogSql.ProviderMysql, InfoLogSql.DataBaseMysql,
                InfoLogSql.UidMysql,
                InfoLogSql.MdpMysql);


            _maConnectionSql.OpenConnection();


            _ocom = _maConnectionSql.ReqExec("UPDATE compte set Decouvert = " + val + " where idCompte = " +
                                           compte.IdCompte + ";");
            _ocom.ExecuteNonQuery();

            _maConnectionSql.CloseConnection();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}