using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace question1.Models
{
    public class Department
    {
        public long id;             //may be unnecessary with unique address
        public string name;
        public string address;
    }

    public class Employee
    {
        public long id;
        public string firstName;
        public string lastName;
        public string jobTitle;
        public string residenceAddress;
    }
}
