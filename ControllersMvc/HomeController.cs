using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TsGenAspnetExample.Models;

namespace TsGenAspnetExample.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class HomeController : AbstractGenericDbContextController<MyDbContext>
    {
        /// <summary>
        /// the <see cref="MyDbContext"/> with AlwaysIgnoreAttribute,
        /// so it will not export to the client.
        /// and the client function will skip the dbContext parameter.
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
        /// the <see cref="MyDbContext"/> with AlwaysIgnoreAttribute,
        /// so it will not export to the client.
        /// and the client function will skip the dbContext parameter.
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
        /// and the client function will skip the dbContext parameter.
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
        /// 返回  (CheckResult, Person[])  这个类型..看看客户端输出啥
        /// </summary>
        /// <returns></returns>
        public (CheckResult, Person[]) GenericValueType()
        {
            return (null, null);
        }

        /// <summary>
        /// 用于测试泛型类型作为输出结果时，是否只输出一个实体类定义;
        /// 而不是输出多个实体类定义
        /// </summary>
        /// <returns></returns>
        public GenericWorkFlow<Dog, EnumAnimalType> TestGenericWorkFlow()
        {
            return null;
        }
    }
}