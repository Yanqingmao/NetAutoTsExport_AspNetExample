using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace TsGenAspnetExample.Controllers
{
    [Route("tr/{action}")]
    public class TestRouteController : Controller
    {
        /// <summary>
        /// 可以通过 /tr 访问，但是无法通过 /tr/index 访问
        /// Route 放在控制器上时，将调用控制器中某个没有定义 Route 的操作，
        /// 如果有多个操作定义没有定义 Route ， 则异常
        /// </summary>
        /// <returns></returns>
        public string Index()
        {
            return "abcd";
        }

        /// <summary>
        /// 可以通过 /tr 访问，但是无法通过 /tr/index 访问
        /// Route 放在控制器上时，将调用控制器中某个没有定义 Route 的操作，
        /// 如果有多个操作定义没有定义 Route ， 则异常
        /// </summary>
        /// <returns></returns>
        public string Ask()
        {
            return "abcdef";
        }

        /// <summary>
        /// 可以通过 /hello 
        /// 但是 /tr/hello 无法访问
        /// 定义在 action 上的 route 将覆盖定义在 Controller 上的 route
        /// </summary>
        /// <returns></returns>
        [Route("hello")]
        [ActionName("h")]
        public string Hello(string lang)
        {
            return JsonConvert.SerializeObject(new Family { PersonCoun = 5, Name = lang });
        }

        /// <summary>
        /// 可以通过 /abc/ra/rp/hello/name 或者 /xyz/ra/rp/Hello/dawei 访问
        /// abc   xyz 都将填充到 lang 参数。
        /// </summary>
        /// <returns></returns>
        // [Route("/rsay/{name=daiwei}")]  // 定义了 Route 时，不能定义 / 开头的路由
        [Route("rsay/{name=daiwei}")]
        public string RootSay(string lang, string name)
        {
            return JsonConvert.SerializeObject(new Family { PersonCoun = 12, Name = $"{lang}---{name}" });
        }
    }

}