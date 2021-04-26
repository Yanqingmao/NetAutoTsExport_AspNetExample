using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TsGenAspnetExample.Models
{

    /// <summary>
    /// Manager, used to test loop depends to <see cref="Employee"/>
    /// </summary>
    public class Manager : Employee
    {
        /// <summary>
        /// Duty
        /// </summary>
        public string Duty { get; set; }

        /// <summary>
        /// the Employee manged by this manager
        /// </summary>
        public List<Employee> DownPersons { get; set; }
    }
}