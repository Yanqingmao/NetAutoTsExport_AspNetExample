using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using TsGenAspnetExample.Models;

namespace TsGenAspnetExample.Controllers
{
    [RouteArea("ra", AreaPrefix = "{lang=zh-CN}/ra")]
    [RoutePrefix("rp")]
    public class TestRouteAreaAndRoutePrefixController : AbstractGenericDbContextController<MyDbContext, Animal>
    {
        // GET: Test
        public string Index()
        {
            return "abcd";
        }

        /// <summary>
        /// 可以通过 /abc/ra/rp/hello 或者 /xyz/ra/rp/Hello 访问
        /// abc   xyz 都将填充到 lang 参数。
        /// /xyz/ra/rp/h 无法访问
        /// </summary>
        /// <returns></returns>
        [Route("hello")]
        [ActionName("h")]
        public string Hello(string lang)
        {
            return JsonConvert.SerializeObject(new Family { PersonCoun = 5, Name = lang });
        }

        /// <summary>
        /// 通过 /abc/ra/rp/h 无法访问
        /// 貌似定义了 RoutePrefix 和 RouteArea时，必须定义有 Route标注。
        /// 而 ActionName 则只用到 没有 RoutePrefix 和 RouteArea 2个标注时才有用;
        /// </summary>
        /// <returns></returns>
        [ActionName("h")]
        public string World(string lang)
        {
            return JsonConvert.SerializeObject(new Family { PersonCoun = 5, Name = lang });
        }

        /// <summary>
        /// 可以通过 /abc/ra/rp/hello/name 或者 /xyz/ra/rp/Hello/dawei 访问
        /// abc   xyz 都将填充到 lang 参数。
        /// </summary>
        /// <returns></returns>
        [Route("say/{name=daiwei}")]
        public string Say(string lang, string name)
        {
            return JsonConvert.SerializeObject(new Family { PersonCoun = 12, Name = $"{lang}---{name}" });
        }
    }

    public class Family
    {
        public int PersonCoun { get; set; }

        public string Name { get; set;  }
    }
}