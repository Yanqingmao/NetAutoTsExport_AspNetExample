using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace TsGenAspnetExample.Controllers
{
    [System.Web.Http.RoutePrefix("tp2000")] // RoutePrefix , 默认路由将不起作用，必须在控制器或者Action上定义 Roue
    // 如果同时定义了路由，则 Action上定义的路由将覆盖 Controller 上定义的路由
    [System.Web.Http.Route("api/values/{id?}")]
    public class TestPrefixValuesController : ApiController
    {
        [System.Web.Http.Route("api/Get/{id?}")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

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