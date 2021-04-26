using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TsGenAspnetExample.Models;

namespace TsGenAspnetExample.Controllers
{
    /// <summary>
    /// Generic Controller with one Generic Type Parameter
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
    /// Generic Controller with two Generic Type Parameters
    /// </summary>
    /// <typeparam name="TDbContext"></typeparam>
    public abstract class AbstractGenericDbContextController<TDbContext, TModel> : Controller
    {

    }
}