using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TsGenAspnetExample.Models
{
    /// <summary>
    /// Abstract class of Animal
    /// </summary>
    public abstract class Animal : IName
    {
        /// <summary>
        /// name of animal
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// animal type
        /// </summary>
        public EnumAnimalType AnimalType { get; set; }
    }
}