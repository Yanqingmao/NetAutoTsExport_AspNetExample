using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TsGenAspnetExample.Models
{
    /// <summary>
    /// Wechat Order Information
    /// </summary>
    public class WechatOrder 
    {
        /// <summary>
        /// OrderId
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Order Number
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// Order State
        /// </summary>
        public EnumWechatOrderState CurrentState { get; set; }

        /// <summary>
        /// Wechat Order Check Result
        /// </summary>
        public CheckResult Result { get; set; }

        /// <summary>
        /// demostrate property with an interface
        /// </summary>
        public IName CreateUser { get; set; }

        /// <summary>
        /// the WechatOrder's work flow
        /// </summary>
        public WechatOrderWorkflow Workflow { get; set; }
    }
}