using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _piataAZ.Entities
{
    public class Employee
    {
        
        private String _username;
        private String _password;
        private String _name;
        private String _role;

        public Employee(String username, String password, String name, String role)
        {
            _username = username;
            _password = password;
            _name = name;
            _role = role;
        }

        public String getRole()
        {
            return _role;
        }

        public String getName()
        {
            return _name;
        }

        public String getUserName()
        {
            return _username;
        }

    }
}
