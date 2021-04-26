using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TsGenAspnetExample.Attributes;

namespace TsGenAspnetExample.Models
{
    /// <summary>
    /// struct test
    /// </summary>
    [AlwaysExport]
    public struct WechatOrderOwner : IName
    {
        /// <summary>
        /// the name of Owner
        /// </summary>
        public string Name { get; set; }
    }
}