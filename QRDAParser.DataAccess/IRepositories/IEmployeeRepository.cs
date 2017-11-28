using System;
using System.Collections.Generic;
using System.Text;
using QRDAParsing.Model;

namespace QRDAParser.DataAccess.IRepositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        void Add(Employee addEmployee); 
    }
}
