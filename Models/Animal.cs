using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TsGenAspnetExample.Models
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Animal : IName
    {
        public string Name { get; set; }

        public EnumAnimalType AnimalType { get; set; }
    }
}