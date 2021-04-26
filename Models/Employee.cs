using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TsGenAspnetExample.Models
{
    /// <summary>
    /// Employee, used to test loop depends to <see cref="Manager"/>
    /// </summary>
    public class Employee : IName
    {
        /// <summary>
        /// name of Employee
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// age of this employee
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// the upper manager
        /// </summary>
        public Manager Upper { get; set; }
    }

}