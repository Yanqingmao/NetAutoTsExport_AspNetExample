using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TsGenAspnetExample.Controllers
{
    /// <summary>
    /// controller, all action defined Http***Attribute.
    /// </summary>
    public class ValuesWithHttpMethodOnActionController : ApiController
    {
        /// <summary>
        /// HttpGet method, the id should be assignd in the route.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="lang"></param>
        /// <returns></returns>
        [HttpGet]
        public string Test(int id, string lang)
        {
            return $"abcd -- {id} -- {lang}";
        }

        /// <summary>
        ///  HttpGet method, the id shouldnt' be assignd in the route.
        /// </summary>
        /// <param name="lang"></param>
        /// <returns></returns>
        [HttpGet]
        public string Test(string lang)
        {
            return $"abcd -- 无Id -- {lang}";
        }

        /// <summary>
        /// HttpPost method, the id shouldnt' be assignd in the route.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public string Get(int id)
        {
            return $"abcd -- {id}";
        }
    }
}
