using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstWpfapp
{
    class Users
    {

        public Users()
        {

        }

        private String _username;
        private String _password;
        private DateTime _lastLogged;

        public void setUsername(string username)
        {
            _username = username;
        }

        public void setPassword(string password)
        {
            _password = password;
        }

        public String getUsername()
        {
            return _username;
        }

        public String getPassword()
        {
            return _password;
        }

        public void setLastLogged(DateTime lastLogged)
        {
            _lastLogged = lastLogged;
        }

        public DateTime getLastLogged()
        {
            return _lastLogged;
        }



    }
}
