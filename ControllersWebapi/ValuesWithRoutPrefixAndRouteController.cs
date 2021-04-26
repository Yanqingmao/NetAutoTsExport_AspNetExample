using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace TsGenAspnetExample.Controllers
{
    /// <summary>
    /// WebApi Controller with RoutePrefixAttribute and RouteAttribute. <br/>
    /// The RouteAttribute defined here will replace the default webapi route. <br/>
    /// The route value is same as the <see cref="ValuesController"/>, but there is RoutePrefixAttribute here.    
    /// </summary>
    [System.Web.Http.RoutePrefix("tp2000")] 
    [System.Web.Http.Route("api/values/{id?}")] 
    public class ValuesWithRoutPrefixAndRouteController : ApiController
    {
        /// <summary>
        /// RouteAttribute defined on action will replace the route on controller or default webapi route.
        /// </summary>
        /// <returns></returns>
        [System.Web.Http.Route("api/Get/{id?}")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// /tp2000/api/values/
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}