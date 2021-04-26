using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using TsGenAspnetExample.Attributes;

namespace TsGenAspnetExample.Models
{
    /// <summary>
    /// the Cat defined a AlwaysExport attribute, so it and its referer class will export to client 
    /// even if it havn't been used by any controller.
    /// </summary>
    [AlwaysIgnore]
    public class Cat : Animal
    {
        /// <summary>
        /// construct
        /// </summary>
        public Cat()
        {
            // assign the animaltype, it will exported to the TypeScript client
            this.AnimalType = EnumAnimalType.Cat;
        }

        /// <summary>
        /// the Owner defined a AlwaysIgnore attribute, 
        /// so this property wouldn't export to the client.
        /// </summary>
        [AlwaysIgnore]
        public Employee Owner { get; set; }

        /// <summary>
        /// the Owner defined a JsonIgnore attribute, 
        /// so this property wouldn't export to the client.
        /// </summary>
        [JsonIgnore]
        public Employee OriginalOwner { get; set; }
    }
}