using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TsGenAspnetExample.Models
{
    public enum EnumOrderState
    {
        New,

        WaitPay,

        Payed,

        Complete,

        Failure
    }
}