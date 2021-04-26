using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TsGenAspnetExample.Models
{
    public class OrderWorkflow
    {
        public WechatOrder Animal { get; set; }

        public GenericWorkFlow<WechatOrder, EnumOrderState>[] NextFlow { get; set; }
    }
}