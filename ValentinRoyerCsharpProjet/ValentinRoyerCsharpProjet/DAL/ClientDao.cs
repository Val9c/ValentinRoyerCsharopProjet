using System;
using System.Collections.Generic;
using System.Windows;
using MySql.Data.MySqlClient;
using ValentinRoyerCsharpProjet.Model;

namespace ValentinRoyerCsharpProjet.DAL;

public class ClientDao
{
    private ConnectionSql _maConnectionSql;


    private MySqlCommand _ocom;


    public List<Client> GetClients()
    {
        List<Client> listClients = new List<Client>();

        try
        {
            _maConnectionSql = ConnectionSql.GetInstance(InfoLogSql.ProviderMysql, InfoLogSql.DataBaseMysql,
                InfoLogSql.UidMysql,
                InfoLogSql.MdpMysql);


            _maConnectionSql.OpenConnection();


            _ocom = _maConnectionSql.ReqExec("Select * from client");


            MySqlDataReader reader = _ocom.ExecuteReader();

            Client client;


            while (reader.Read())
            {
                int idClient = (int) reader.GetValue(0);
                string prenom = (string) reader.GetValue(1);
                string nom = (string) reader.GetValue(2);
                string adresse = (string) reader.GetValue(3);

                client = new Client(idClient, nom, prenom, adresse);

                listClients.Add(client);
            }


            reader.Close();

            _maConnectionSql.CloseConnection();
        }


        catch (Exception emp)
        {
            MessageBox.Show(emp.Message);
        }

        return (listClients);
    }

    public void ModifClient(Client client, string adresse)
    {
        try
        {
            _maConnectionSql = ConnectionSql.GetInstance(InfoLogSql.ProviderMysql, InfoLogSql.DataBaseMysql,
                InfoLogSql.UidMysql,
                InfoLogSql.MdpMysql);


            _maConnectionSql.OpenConnection();


            _ocom = _maConnectionSql.ReqExec("UPDATE client set adresse = " + " ' " + adresse + " ' " +
                                             " where idClient = " +
                                             client.IdClient + ";");
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