using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace TsGenAspnetExample.Controllers
{
   // [RouteArea("tatp")] //无法访问  这个不起作用
    [System.Web.Http.RoutePrefix("taatp")]
    // [System.Web.Http.Route("api/tatpv/{id?}")]    ==>注释前， taatp/api/tatpv/123 可以访问
    // 但是注释后， taatp/api/TestAreaTestPrefixValues/123    无法访问， 必须定义 Route, 看起来定义了 RoutePrefix, 必须还定义 Route
    public class TestAreaTestPrefixValuesController : ApiController
    {
        // GET api/<controller>
        // [System.Web.Http.Route("api/tatpv/{id?}")]  // 定义了 RoutePrefix 时，在方法上定义 Route 不起作用 taatp/api/taptv/123 无法访问
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
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