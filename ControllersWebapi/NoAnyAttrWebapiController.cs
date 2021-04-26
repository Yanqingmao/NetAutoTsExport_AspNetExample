using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TsGenAspnetExample.Models;

namespace TsGenAspnetExample.Controllers
{
    public class NoAnyAttrWebapiController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Manager> get()
        {
            return new Manager[] 
            {  
                new Manager { Name = $"Get--{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}"},
                new Manager { Name = $"Get--{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}", Duty = "管理员"}
            };
        }

        // GET api/<controller>/5
        public Person Get(int id)
        {
            return new Person { Name = $"Get--{id}--{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}" };
        }

        // POST api/<controller>
        public Person Post([FromBody] Person value)
        {
            return new Person { Name = $"Post--{value.Name}--{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}" };
        }

        // PUT api/<controller>/5
        public Person Put(int id, [FromBody] Person value)
        {
            return new Person { Name = $"Put---{id}---{value.Name}---{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}" };
        }
        public Person Options()
        {
            return new Person {  };
        }
        // Patch api/<controller>/5
        public Person Patch(int id, [FromBody] Person value)
        {
            return new Person { Name = $"Patch---{id}---{value.Name}---{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}" };
        }

        // DELETE api/<controller>/5
        public Person Delete(int id)
        {
            return new Person { Name = $"Delete---{id}------{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}" };
        }
    }
}