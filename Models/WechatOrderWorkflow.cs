using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TsGenAspnetExample.Models
{
    /// <summary>
    /// wechatorder's work flow
    /// </summary>
    public class WechatOrderWorkflow
    {
        /// <summary>
        /// wechat order instance
        /// </summary>
        public WechatOrder Animal { get; set; }

        /// <summary>
        /// the next work flow
        /// </summary>
        public GenericWorkFlow<WechatOrder, EnumWechatOrderState>[] NextFlow { get; set; }
    }
}