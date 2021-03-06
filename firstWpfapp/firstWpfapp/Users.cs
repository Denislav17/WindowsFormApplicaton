﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstWpfapp
{
    public class Users
    {

        public Users()
        {

        }
        private int _id;
        private String _firstName;
        private String _lastName;
        private String _userName;
        private String _password;
        private String _company;
        private String _position;
        private DateTime _regDate;
        private String _cardNumber;
        
        public void setId(int id)
        {
            _id = id;
        }

        public int getId()
        {
            return _id;
        }

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

        public void setCardNumber(string cardNumber)
        {
            _cardNumber = cardNumber;
        }

        public String getCardNumber()
        {
            return _cardNumber;
        }

        public DateTime getRegDate()
        {
            return _regDate;
        }

        public String toString()
        {
            return _firstName + " " + _lastName;
        }



    }
}
