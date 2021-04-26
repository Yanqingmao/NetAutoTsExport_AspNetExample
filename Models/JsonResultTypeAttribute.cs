﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TsGenAspnetExample.Models
{
    /// <summary>
    /// Define a attribute class which mark a action will return a JsonResult 
    /// and the value or data type of JsonResult will be the <see cref="JsonResultTypeAttribute.ResultType"/>.
    /// </summary>
    public class JsonResultTypeAttribute : Attribute
    {
        public JsonResultTypeAttribute()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public Type ResultType { get; set; }
    }
}