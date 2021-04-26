using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using TsGenAspnetExample.Models;

namespace TsGenAspnetExample.Controllers
{
    /// <summary>
    /// define controller with RouteAtribute; <br/>
    /// when defined RouteAttribute, this will replace the default route;
    /// </summary>
    [Route("tr/{action}")]
    public class TestRouteController : Controller
    {
        /// <summary>
        /// /tr/index ==> ok <br/>
        /// /TestRoute/Index ==> 404
        /// </summary>
        /// <returns></returns>
        public string Index()
        {
            return $"{this.Request.Url} -- { DateTime.Now}";
        }

        /// <summary>
        /// /hello ==> ok  <br/>
        /// /TestRoute/h ==> 404 (replace the default route defined on controller)   <br/>
        /// /tr/h ==> 404  (replac the RouteAttribute defined on controller)  <br/>
        /// /hello/h => 404 (without action on the RouteAttribute defined on this action)  <br/>
        /// </summary>
        /// <returns></returns>
        [Route("hello")]
        [ActionName("h")]
        public string Hello(string lang)
        {
            return $"{this.Request.Url} -- " + JsonConvert.SerializeObject(new Family { PersonCoun = 5, Name = lang });
        }

        /// <summary>
        /// /rsay ==> ok
        /// /rsay/Yanqingmao ==> ok
        /// </summary>
        /// <returns></returns>
        [Route("rsay/{name=daiwei}")]
        public string RootSay(string lang, string name)
        {
            return $"{this.Request.Url} -- " + JsonConvert.SerializeObject(new Family { PersonCoun = 12, Name = $"{lang}---{name}" });
        }
    }

}