using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QRDAParsing.Model;
using QRDAParsing.Services.IServices;
using Microsoft.AspNetCore.Cors;

namespace QRDAParsing.Controllers
{
    [EnableCors("SiteCorsPolicy")]
    //[EnableCors("AllowSpecificOrigin")]
    [Produces("application/json")]
    [Route("api/Employee/[Action]")]
    public class EmployeeController : Controller
    {
        IEmployeeService empservice;
        
        public EmployeeController(IEmployeeService _empservice)
        {
            empservice = _empservice;
        }

        /// <summary>
        /// Get the list of all the employees,
        /// Author : Praveen bhatt
        /// </summary>
        /// <returns></returns>
        // GET: api/Employee
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            try
            {
                var result = empservice.GetAllEmployees();
                return Ok(result);
            }
            catch (Exception e)
            {
                throw;
            }
        }


        /// <summary>
        /// Set the employee details into PostGreSQL,
        /// Author : Praveen bhatt
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        public IActionResult SetEmployee([FromBody]Employee emp)
        {
            try
            {
                empservice.AddEmployee(emp);
                return Ok(true);
            }
            catch (Exception e)   
            {
                throw;
            }
        }

       
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        //// GET: api/Employee/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        
        //// POST: api/Employee
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}
        
        //// PUT: api/Employee/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}
        
        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
