using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TsGenAspnetExample.Models
{
    /// <summary>
    /// 微信订单定义
    /// </summary>
    public class WechatOrder 
    {
        public int Id { get; set; }

        public string OrderNumber { get; set; }

        public EnumOrderState CurrentState { get; set; }

        public CheckResult Result { get; set; }

        /// <summary>
        /// 接口
        /// </summary>
        public IName CreateUser { get; set; }
    }
}