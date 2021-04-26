using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TsGenAspnetExample.Models;

namespace TsGenAspnetExample.Controllers
{
    // [RoutePrefix("vv")]
    // [Route("api/{controller}/{id}")] 出错，直接路由不能使用参数 'controller'
    // [Route("api/<controller>/{id}")] //找不到 api/Values/123  api/values/Test/123
    // [Route("api/<controller>")]  // 在控制器“Values”上找不到与该请求匹配的操作。
     [Route("api/Values/{id?}")] 
    // [Route("api/Values/{id}")] // api/values 将出错,因为 必须给定 id
    public class ValuesController : ApiController
    {
        // [Route("api/Values/{id?}")]  ==> api/values/123 
        //[Route("api/Values/{id}")] //  ==> api/values/123 
        [HttpGet]
        public string Test(int id, string lang)
        {
            return $"abcd -- {id} -- {lang}";
        }

        // [Route("api/Values/{id?}")]  ==》 api/values/ 
        [HttpGet]
        public Dictionary<string, Person> Test(string lang)
        {
            SortedDictionary<Person, string> xx;
            SortedSet<Person> yy;
            var person1 = new Person { Name = "Daiwei" };
            var person2 = new Person { Name = lang };
            return new Dictionary<string, Person>
            {
                { person1.Name, person1 },
                { person2.Name, person2  }
            };
        }
        [HttpPost]
        public List<string> Get(int id)
        {
            return new List<string> { $"abcd -- {id}" };
        }
    }
}
