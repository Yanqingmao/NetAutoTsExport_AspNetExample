using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace TsGenAspnetExample.Controllers
{
    [RouteArea("ra", AreaPrefix = "{lang=zh-CN}/ra")]
    public class TestRouteAreaController : Controller
    {
        /// <summary>
        /// 这儿不可以通过 /rp/index 或者 /rp 访问，因为其未定义有 Route标注
        /// </summary>
        // GET: Test
        public string Index()
        {
            return "abcd";
        }

        /// <summary>
        /// 可以通过 /abc/ra/hello 或者 /xyz/ra/Hello 访问
        /// abc   xyz 都将填充到 lang 参数。
        /// </summary>
        /// <returns></returns>
        [Route("hello")]
        public string Hello(string lang)
        {
            return JsonConvert.SerializeObject(new Family { PersonCoun = 5 , Name = lang});
        }


        /// <summary>
        /// 可以通过 /abc/ra/hello/name 或者 /xyz/ra/Hello/dawei 访问
        /// abc   xyz 都将填充到 lang 参数。
        /// </summary>
        /// <returns></returns>
        [Route("say/{name=daiwei}")]
        public string Say(string lang, string name)
        {
            return JsonConvert.SerializeObject(new Family { PersonCoun = 12, Name = $"{lang}---{name}"});
        }


        /// <summary>
        /// 可以通过 /abc/ra/hello/name 或者 /xyz/ra/Hello/dawei 访问
        /// abc   xyz 都将填充到 lang 参数。
        /// </summary>
        /// <returns></returns>
        // [Route("/rsay/{name=daiwei}")] // 定义了 RouteArea 时，不能定义 / 开头的路由
        [Route("rsay/{name=daiwei}")]
        public string RootSay(string lang, string name)
        {
            return JsonConvert.SerializeObject(new Family { PersonCoun = 12, Name = $"{lang}---{name}" });
        }
    }

}