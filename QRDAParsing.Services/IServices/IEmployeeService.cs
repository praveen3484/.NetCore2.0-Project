using System;
using System.Collections.Generic;
using System.Text;
using QRDAParsing.Model;

namespace QRDAParsing.Services.IServices
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
        void AddEmployee(Employee addEmp);  
    }
}
