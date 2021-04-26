using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TsGenAspnetExample.Models;

namespace TsGenAspnetExample.Controllers
{
    /// <summary>
    /// 抽象的泛型控制器类,带1个泛型参数;
    /// </summary>
    /// <typeparam name="TDbContext"></typeparam>
    public abstract class AbstractGenericDbContextController<TDbContext> : Controller
    {
        public string TestParent()
        {
            return "abc";
        }
    }

    /// <summary>
    /// 抽象的泛型控制器类,带2个泛型参数;
    /// </summary>
    /// <typeparam name="TDbContext"></typeparam>
    public abstract class AbstractGenericDbContextController<TDbContext, TModel> : Controller
    {

    }
}