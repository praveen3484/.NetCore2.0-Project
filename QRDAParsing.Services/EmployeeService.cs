using System;
using System.Collections.Generic;
using QRDAParser.DataAccess.IRepositories;
using QRDAParsing.Model;
using QRDAParsing.Services.IServices;

namespace QRDAParsing.Services
{
    public class EmployeeService : IEmployeeService
    {
        public readonly IEmployeeRepository empRepository;
        public EmployeeService(IEmployeeRepository _empRepository)
        {
            empRepository = _empRepository;
        }

        /// <summary>
        /// Service call to add a new Employee ,
        /// Author : Praveen Bhatt
        /// </summary>
        /// <param name="addEmp"></param>
        void IEmployeeService.AddEmployee(Employee addEmp)
        {
            try
            {
                empRepository.Add(addEmp);
            }
            catch (Exception e) 
            {
                throw;
            }
        }

        /// <summary>
        /// Service call to retrieve every Employees Detail ,
        /// Author : Praveen Bhatt
        /// </summary>
        /// <returns></returns>
        IEnumerable<Employee> IEmployeeService.GetAllEmployees()
        {
            try
            {
                return empRepository.GetAll();

            }
            catch (Exception ex)   
            {

                throw;
            }
        }
    }
}
