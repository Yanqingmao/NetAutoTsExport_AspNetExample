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
    /// define controller with RouteAreaAtribute and RoutePrefixAtribute;<br/>
    /// the AreaPrefix property in RouteAreaAtribute has default value.<br/>
    /// If defined RoutePrefixAtribute and RoutePrefixAtribute, but not defined the RouteAttribute on the action,
    /// the action should accessed by default route.
    /// </summary>
    [RouteArea("ra", AreaPrefix = "{lang=zh-CN}/ra")]
    [RoutePrefix("rp")]
    public class TestRouteAreaAndRoutePrefixController : AbstractGenericDbContextController<MyDbContext, Animal>
    {
        /// <summary>
        /// default get, with no any parameter;<br/>
        /// /abc/ra/rp/TestRouteAreaAndRoutePrefix/index => 404 <br/>        
        /// /TestRouteAreaAndRoutePrefix/index  ==> ok
        /// </summary>
        /// <returns></returns>
        public string Index()
        {
            return $"{this.Request.Url} -- {DateTime.Now}";
        }

        /// <summary>
        /// /abc/ra/rp/hello ==> ok <br/>
        /// /xyz/ra/rp/hello ==> ok <br/>
        /// /TestRouteAreaAndRoutePrefix/h ==> 404 <br/>
        /// /xyz/ra/rp/TestRouteAreaAndRoutePrefix/h ==> 404 <br/>
        /// </summary>
        /// <returns></returns>
        [Route("hello")]
        [ActionName("h")]
        public string Hello(string lang)
        {
            return $"{this.Request.Url} -- " + JsonConvert.SerializeObject(new Family { PersonCoun = 5, Name = lang });
        }

        /// <summary>
        /// /abc/ra/rp/h ==> 404
        /// /TestRouteAreaAndRoutePrefix/w  ==> ok
        /// </summary>
        /// <returns></returns>
        [ActionName("w")]
        public string World(string lang)
        {
            return $"{this.Request.Url} -- " + JsonConvert.SerializeObject(new Family { PersonCoun = 5, Name = lang });
        }

        /// <summary>
        /// /abc/ra/rp/hello/name  ==> ok
        /// /xyz/ra/rp/Hello/dawei  ==> ok
        /// </summary>
        /// <returns></returns>
        [Route("say/{name=daiwei}")]
        public string Say(string lang, string name)
        {
            return $"{this.Request.Url} -- " + JsonConvert.SerializeObject(new Family { PersonCoun = 12, Name = $"{lang}---{name}" });
        }
    }

}