using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace ValentinRoyerCsharpProjet.DAL;

class ConnectionSql
{
    private static ConnectionSql _connection = null;

    private MySqlConnection _oleCn;

    private static readonly object Mylock = new object();

    private string _connString;


    private ConnectionSql(string unProvider, string uneDataBase, string unUid, string unMdp)
    {
        try
        {
            _connString = "SERVER=" + unProvider + ";" + "DATABASE=" +
                          uneDataBase + ";" + "UID=" + unUid + ";" + "PASSWORD=" + unMdp + ";";
            try
            {
                _oleCn = new MySqlConnection(_connString);
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }
        catch (Exception emp)
        {
            throw (emp);
        }
    }


    public static ConnectionSql GetInstance(string unProvider, string uneDataBase, string unUid, string unMdp)
    {
        try
        {
            if (null == _connection)
            {
                _connection = new ConnectionSql(unProvider, uneDataBase, unUid, unMdp);
            }
        }
        catch (Exception emp)
        {
            throw (emp);
        }

        return _connection;
    }


    public void OpenConnection()
    {
        if (_oleCn.State == System.Data.ConnectionState.Closed)
            _oleCn.Open();
    }

    public void CloseConnection()
    {
        if (_oleCn.State == System.Data.ConnectionState.Open)
            _oleCn.Close();
    }


    public bool IsOpen()
    {
        bool res = false;
        if (_oleCn.State == System.Data.ConnectionState.Open)
        {
            res = true;
        }

        return (res);
    }

    public MySqlCommand ReqExec(string req)
    {
        MySqlCommand mysqlCom = new MySqlCommand(req, this._oleCn);
        return (mysqlCom);
    }
}