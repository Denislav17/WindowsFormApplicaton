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

        private String _firstName;
        private String _lastName;
        private String _userName;
        private String _password;
        private String _company;
        private String _position;
        private DateTime _regDate;

        public void setUsername(string username)
        {
            _userName = username;
        }

        public void setPassword(string password)
        {
            _password = password;
        }

        public String getUsername()
        {
            return _userName;
        }

        public String getPassword()
        {
            return _password;
        }

        public void setFirstName(string fname)
        {
            _firstName = fname;
        }

        public String getFirstName()
        {
            return _firstName;
        }

        public void setLastName(string lname)
        {
            _lastName = lname;
        }

        public String getLastName()
        {
            return _lastName;
        }

        public void setCompany(string company)
        {
            _company = company;
        }

        public String getCompany()
        {
            return _company;
        }

        public void setPosition(string position)
        {
            _position = position;
        }

        public String getPosition()
        {
            return _position;
        }

        public void setRegDate(DateTime regDate)
        {
            _regDate = regDate;
        }

        public DateTime getRegDate()
        {
            return _regDate;
        }



    }
}
