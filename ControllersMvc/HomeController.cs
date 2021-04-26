using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TsGenAspnetExample.Attributes;
using TsGenAspnetExample.Models;

namespace TsGenAspnetExample.Controllers
{
    /// <summary>
    /// HomeController, extend是 from Generic Controller with one generic type parameter
    /// </summary>
    public class HomeController : AbstractGenericDbContextController<MyDbContext>
    {
        /// <summary>
        /// the <see cref="MyDbContext"/> with AlwaysIgnoreAttribute,
        /// so it will not export to the client.
        /// Has <see cref="JsonResultTypeAttribute"/>,so the result will be <see cref="Dog"/>
        /// </summary>
        /// <param name="dbContext"></param>
        /// <returns></returns>
        [JsonResultType(ResultType = typeof(Dog))]
        public JsonResult Index(MyDbContext dbContext)
        {
            return new JsonResult
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = new Dog
                {
                    Name = "Xiaomao",
                }
            };
        }

        /// <summary>
        /// JsonResult will convert to any.
        /// </summary>
        /// <param name="dbContext"></param>
        /// <returns>JsonResult will converted to any type</returns>
        public JsonResult Welcome(MyDbContext dbContext)
        {
            return new JsonResult
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = new Dog
                {
                    Name = "Xiaomao",
                }
            };
        }


        /// <summary>
        /// the <see cref="MyDbContext"/> with AlwaysIgnoreAttribute,
        /// so it will not export to the client.
        /// and the client function will skip the dbContext parameter. <br/>
        /// 
        /// Task&lt;WechatOrder&gt; should be converted to WechatOrder when exported;
        /// </summary>
        /// <param name="dbContext"></param>
        /// <returns>JsonResult will converted to any type</returns>
        public Task<WechatOrder> OrderHandle(MyDbContext dbContext)
        {
            return Task.FromResult(new WechatOrder
            {

            });
        }


        /// <summary>
        /// return tuple instance.
        /// </summary>
        /// <returns></returns>
        public (CheckResult, Employee[]) GenericValueType()
        {
            return (null, null);
        }

        /// <summary>
        /// return the generic type instance
        /// </summary>
        /// <returns></returns>
        public GenericWorkFlow<Dog, EnumAnimalType> TestGenericWorkFlow()
        {
            return null;
        }
    }
}