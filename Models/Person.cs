using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TsGenAspnetExample.Models
{
    public class Person 
    {
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Manager Upper { get; set; }
    }

}