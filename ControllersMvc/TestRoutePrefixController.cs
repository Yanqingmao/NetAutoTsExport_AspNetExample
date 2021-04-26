using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace TsGenAspnetExample.Controllers
{
    /// <summary>
    /// 测试 RoutePrefix
    /// 定义了 RoutePrefix,  则方法必须定义有 Route标注才可以访问
    /// </summary>
    [RoutePrefix("rp")]
    public class TestRoutePrefixController : Controller
    {
        /// <summary>
        /// 这儿不可以通过 /rp/index 或者 /rp 访问，因为其未定义有 Route标注
        /// </summary>
        /// <returns></returns>
        public string Index()
        {
            return "abcd";
        }

        /// <summary>
        /// 可以通过 /rp/hello 或者 /rp/Hello 访问
        /// 但是 /rp/hello/daiwei  出错
        /// </summary>
        /// <returns></returns>
        [Route("hello")]
        public string Hello()
        {
            return JsonConvert.SerializeObject(new Family { PersonCoun = 5 });
        }


        /// <summary>
        /// 可以通过 /rp/say 或者 /rp/say/xxx 访问
        /// </summary>
        /// <returns></returns>
        [Route("say/{name=daiwei}")]
        public string Say(string name)
        {
            return JsonConvert.SerializeObject(new Family { PersonCoun = 12, Name = name });
        }

        /// <summary>
        /// 可以通过 /rp/say 或者 /rp/say/xxx 访问
        /// </summary>
        /// <returns></returns>
        // [Route("/rsay/{name=daiwei}")]  // 定义了 RoutePrefix时，不能定义 / 开头的路由
        [Route("rsay/{name=daiwei}")]
        public string RootSay(string name)
        {
            return JsonConvert.SerializeObject(new Family { PersonCoun = 12, Name = name });
        }
    }

}