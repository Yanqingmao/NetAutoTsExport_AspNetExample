using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TsGenAspnetExample.Controllers
{
    public class NoRouteValuesController : ApiController
    {
        [HttpGet]
        public string Test(int id, string lang)
        {
            return $"abcd -- {id} -- {lang}";
        }

        //[Route("/xapi/Values/{id}")] //  ==> api/values/123  // 不能定义 / 开头的 route
        //[HttpGet]
        //public string Test1(int id, string lang)
        //{
        //    return $"abcd -- {id} -- {lang}";
        //}

        [HttpGet]
        public string Test(string lang)
        {
            return $"abcd -- 无Id -- {lang}";
        }
        [HttpPost]
        public string Get(int id)
        {
            return $"abcd -- {id}";
        }
    }
}
