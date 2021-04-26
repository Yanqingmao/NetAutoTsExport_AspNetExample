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
    /// WebApi controller with RouteAttribute; <br/>
    /// </summary>
    // [Route("api/{controller}/{id}")] error, cannot use {controller} in route
     [Route("api/ValuesWithRoute/{id?}")] 
    public class ValuesWithRouteController : ApiController
    {
        /// <summary>
        /// HttpGet method <br/>
        /// when url contains id, will use this action handle the get method.<br/>
        /// /api/ValuesWithRoute/123?lang=123  ==> ok
        /// </summary>
        [HttpGet]
        public string TestGet(int id, string lang)
        {
            return $"{this.Request.RequestUri} -- {id} -- {lang}";
        }

        /// <summary>
        /// HttpGet method <br/>
        /// when url dont contains id, will use this action handle the get method.<br/>
        /// /api/ValuesWithRoute/?lang=123  ==> ok
        /// </summary>
        /// <param name="lang"></param>
        /// <returns>return instance of Dictionary,it should be mapped to Record.</returns>
        [HttpGet]
        public Dictionary<string, Employee> TestGet(string lang)
        {
            var person1 = new Employee { Name = "Daiwei" };
            var person2 = new Employee { Name = lang };
            return new Dictionary<string, Employee>
            {
                { person1.Name, person1 },
                { person2.Name, person2  }
            };
        }

        /// <summary>
        /// HttpPost method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public List<string> TestPost(int id)
        {
            return new List<string> { $"{this.Request.RequestUri} -- {id}" };
        }
    }
}
