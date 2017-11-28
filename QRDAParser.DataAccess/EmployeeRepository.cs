using System;
using System.Collections.Generic;
using System.Linq;
using QRDAParser.DataAccess.IRepositories;
using QRDAParsing.Data;
using QRDAParsing.Model;

namespace QRDAParser.DataAccess
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private ApplicationDbContext empcontext;
        public EmployeeRepository(ApplicationDbContext context)
        {
            this.empcontext = context;
        }

        /// <summary>
        /// Repository call to set new Employees Detail
        /// Author : Praveen Bhatt
        /// </summary>
        /// <param name="addEmployee"></param>
        void IEmployeeRepository.Add(Employee addEmployee)
        {
            try
            {
                empcontext.Employee.Add(addEmployee);
                empcontext.SaveChanges();
            }
            catch (Exception e) 
            {
                throw;
            }
        }


        /// <summary>
        /// Repository call to retrieve every Employees Detail
        /// Author : Praveen Bhatt
        /// </summary>
        /// <returns></returns>
        IEnumerable<Employee> IEmployeeRepository.GetAll()
        {
            try
            {
                return empcontext.Employee.ToList();
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
