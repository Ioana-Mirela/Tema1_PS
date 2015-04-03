using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _piataAZ.Entities
{
    public class Report
    {
        private Employee _employee;
        private int _nbAds;

        public Report(Employee employee, int nbAds)
        {
            _employee = employee;
            _nbAds = nbAds;
        }

        public Employee getEmployee()
        {
            return _employee;
        }

        public int getNbAds()
        {
            return _nbAds;
        }

    }
}
