using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TsGenAspnetExample.Controllers;

namespace TsGenAspnetExample.Models
{
    /// <summary>
    /// <see cref="HomeController.Index(MyDbContext)"/>
    /// this action has a <see cref="JsonResultTypeAttribute">JsonResultType(typeof(Dog))]</see>,
    /// so this class will export to client.
    /// </summary>
    public class Dog : Animal
    {
        /// <summary>
        /// 
        /// </summary>
        public Dog()
        {
            this.AnimalType = EnumAnimalType.Dog;
        }
    }
}