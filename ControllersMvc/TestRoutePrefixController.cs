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
    /// define controller with RoutePrefixAtribute;
    /// If defined RoutePrefixAtribute, but not defined the RouteAttribute on the action,
    /// the action should accessed accord the default route.
    /// </summary>
    [RoutePrefix("rp")]
    public class TestRoutePrefixController : Controller
    {
        /// <summary>
        /// /TestRoutePrefix/index ==> ok<br/>
        /// /rp/index ==> 404
        /// </summary>
        /// <returns></returns>
        public string Index()
        {
            return $"{this.Request.Url} -- { DateTime.Now}";
        }

        /// <summary>
        /// /rp/hello ==> ok<br/>
        /// /TestRoutePrefix/hello ==> 404 
        /// </summary>
        /// <returns></returns>
        [Route("hello")]
        public string Hello()
        {
            return $"{this.Request.Url} -- " + JsonConvert.SerializeObject(new Family { PersonCoun = 5 });
        }

        /// <summary>
        /// /rp/hello   ==> ok<br/>
        /// /rp/hello/daiwei ==> ok<br/>
        /// </summary>
        /// <returns></returns>
        [Route("say/{name=daiwei}")]
        public string Say(string name)
        {
            return $"{this.Request.Url} -- " + JsonConvert.SerializeObject(new Family { PersonCoun = 12, Name = name });
        }
    }

}