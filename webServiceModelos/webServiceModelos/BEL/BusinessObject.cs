using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webServiceModelos.BLL
{
    public class BusinessObject
    {
        private string _firstName;

        public string firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private int _edad;

        public int edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        private String _address;

        public String address
        {
            get { return _address; }
            set { _address = value; }
        }


        private String _city;

        public String city
        {
            get { return _city; }
            set { _city = value; }
        }

        private DateTime _lastLogin;

        public DateTime lastLogin
        {
            get { return _lastLogin; }
            set { _lastLogin = value; }
        }

        public BusinessObject(string firstName, string lastName, int edad, string address, string city, DateTime lastLogin)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.edad = edad;
            this.address = address;
            this.city = city;
            this.lastLogin = lastLogin;
        }


    }
}
