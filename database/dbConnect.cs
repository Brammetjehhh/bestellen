using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;

namespace database
{
    public class DbConnect
    {
        const string _csConnectionString = "Server=localhost;Database=killerapp;Uid=root;Pwd=;Sslmode=none";
        MySqlConnection _mscConnection = new MySqlConnection(_csConnectionString);
        private bool OpenConnection()
        {
            bool bResult = true;
            bool iResult = true;
            try
            {
                _mscConnection.Open();
            }
            catch (Exception e)
            {
                bResult = false;
            }
            return bResult;
            return iResult;
        }

        private string Read(string query)
        {
            string antwoord = "leeg";
            MySqlCommand cmd = new MySqlCommand(query, _mscConnection);
            _mscConnection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                antwoord = reader.GetString(0);
            }
            _mscConnection.Close();
            return antwoord;
        }

        public string getPassword(string username)
        {
            return Read($"SELECT password FROM user WHERE username = '{username}'");
        }

        public string getProducts()
        {
            return Read($"SELECT * FROM product");
        }
    }
}
