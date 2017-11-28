using System;
using System.ComponentModel.DataAnnotations;

namespace QRDAParsing.Model
{
    public class Employee
    {
      
        public int ID{ get; set; }
        public string Emp_Name { get; set; }
        public int Emp_Age { get; set; }
        public string Address { get; set; }
        public string Emp_Phone_No { get; set; }

    }
}
