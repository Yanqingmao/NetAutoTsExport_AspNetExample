using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TsGenAspnetExample.Models
{
    /// <summary>
    /// the Cat defined a AlwaysExport attribute, so it and its referer class will export to client 
    /// since it havn't been used by any controller.
    /// </summary>
    [AlwaysIgnore]
    public class Cat : Animal
    {
        public Cat()
        {
            this.AnimalType = EnumAnimalType.Cat;
        }

        /// <summary>
        /// the Owner defined a AlwaysIgnore attribute, so this property wouldn't export to the client.
        /// </summary>
        [AlwaysIgnore]
        public Person Owner { get; set; }

        /// <summary>
        /// the Owner defined a JsonIgnore attribute, so this property wouldn't export to the client.
        /// </summary>
        [JsonIgnore]
        public Person OriginalOwner { get; set; }
    }
}