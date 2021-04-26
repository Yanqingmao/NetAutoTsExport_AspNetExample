using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TsGenAspnetExample.Models
{
    /// <summary>
    /// enumerate of WechatOrder state
    /// </summary>
    public enum EnumWechatOrderState
    {
        /// <summary>
        /// New
        /// </summary>
        New,

        /// <summary>
        /// Wait the user pay
        /// </summary>
        WaitPay,

        /// <summary>
        /// user payed
        /// </summary>
        Payed,

        /// <summary>
        /// complete the order
        /// </summary>
        Complete,

        /// <summary>
        /// user payed failure or user dont pay
        /// </summary>
        Failure
    }
}