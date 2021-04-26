using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TsGenAspnetExample.Models
{

    public class Manager : Person
    {
        public string Duty { get; set; }

        public List<Person> DownPersons { get; set; }
    }
}