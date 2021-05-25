using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    class Login
    {
        public bool checkLogin(string username, string password)
        {
            if (username.ToLower() == "mady" && password == "1234")
            {
                return true;
            }
            return false;
        }
    }
}
