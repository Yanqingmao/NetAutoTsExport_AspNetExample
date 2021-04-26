using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TsGenAspnetExample.Models;

namespace TsGenAspnetExample.Controllers
{
    /// <summary>
    /// use the default webapi route <see cref="WebApiConfig.Register(HttpConfiguration)"/>
    /// using name of Method for HttpMethod.
    /// </summary>
    public class ValuesController : ApiController
    {
        /// <summary>
        /// handle the get request when these is no id parameter in route.
        /// </summary>
        /// <returns></returns>
        // GET api/<controller>
        public IEnumerable<Manager> get()
        {
            return new Manager[] 
            {  
                new Manager { Name = $"Get--{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}"},
                new Manager { Name = $"Get--{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}", Duty = "管理员"}
            };
        }

        /// <summary>
        /// handle the get request when these is id parameter in route.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<controller>/5
        public Employee Get(int id)
        {
            return new Employee { Name = $"Get--{id}--{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}" };
        }

        /// <summary>
        /// handle the post request 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        // POST api/<controller>
        public Employee Post([FromBody] Employee value)
        {
            return new Employee 
            { 
                    Name = $"Post--{value.Name}--{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}",
                    Age = new Random().Next(30) 
            };
        }

        /// <summary>
        /// handle the Put request
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        // PUT api/<controller>/5
        public Employee Put(int id, [FromBody] Employee value)
        {
            return new Employee { Name = $"Put---{id}---{value.Name}---{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}" };
        }

        /// <summary>
        /// handle the Options request
        /// </summary>
        /// <returns></returns>
        public Employee Options()
        {
            return new Employee {  };
        }
        /// <summary>
        /// handle the Patch request
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        // Patch api/<controller>/5
        public Employee Patch(int id, [FromBody] Employee value)
        {
            return new Employee { Name = $"Patch---{id}---{value.Name}---{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}" };
        }
        /// <summary>
        /// handle the Delete request
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // DELETE api/<controller>/5
        public Employee Delete(int id)
        {
            return new Employee { Name = $"Delete---{id}------{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}" };
        }
    }
}