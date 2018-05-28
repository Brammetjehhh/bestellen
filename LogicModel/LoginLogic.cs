using System;
using System.Collections.Generic;
using System.Text;
using database;

namespace LogicLayer
{
    public class LoginLogic
    {
        DbConnect db = new DbConnect();
        public string Login(string username, string password)
        {
            string antwoord = "";

            if (db.getPassword(username) == password)
            {
                antwoord = username;
            }
            else
            {
                return null;
            }
            return antwoord;
        }
    }
}
