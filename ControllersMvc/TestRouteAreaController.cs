using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using TsGenAspnetExample.Models;

namespace TsGenAspnetExample.Controllers
{    /// <summary>
     /// define controller with RouteAreaAtribute. <br/>
     /// the AreaPrefix property in RouteAreaAtribute has default value.<br/>
     /// If defined RouteAreaAtribute, but not defined the RouteAttribute on the action,
     /// the action should accessed accord the default route.
     /// </summary>
    [RouteArea("ra", AreaPrefix = "{lang=zh-CN}/ra")]
    public class TestRouteAreaController : Controller
    {
        /// <summary>
        /// /abc/ra/index ==> 404  <br/>
        /// /TestRouteArea/Index ==> ok <br/>
        /// </summary>
        // GET: Test
        public string Index()
        {
            return $"{this.Request.Url} -- { DateTime.Now}";
        }

        /// <summary>
        /// /abc/ra/hello ==> ok  <br/>
        /// /TestRouteArea/Hello ==> 404  
        /// </summary>
        /// <returns></returns>
        [Route("hello")]
        public string Hello(string lang)
        {
            return $"{this.Request.Url} -- " + JsonConvert.SerializeObject(new Family { PersonCoun = 5 , Name = lang});
        }


        /// <summary>
        /// /abc/ra/say/name ==> ok  <br/>
        /// /xyz/ra/say/dawei   ==> ok 
        /// </summary>
        /// <returns></returns>
        [Route("say/{name=daiwei}")]
        public string Say(string lang, string name)
        {
            return $"{this.Request.Url} -- " + JsonConvert.SerializeObject(new Family { PersonCoun = 12, Name = $"{lang}---{name}"});
        }


        /// <summary>
        /// /abc/ra/rsay/name ==> ok  <br/>
        /// /xyz/ra/rsay/   ==> ok 
        /// </summary>
        /// <returns></returns>
        [Route("rsay/{name=daiwei}")]
        public string RootSay(string lang, string name)
        {
            return $"{this.Request.Url} -- " + JsonConvert.SerializeObject(new Family { PersonCoun = 12, Name = $"{lang}---{name}" });
        }
    }

}