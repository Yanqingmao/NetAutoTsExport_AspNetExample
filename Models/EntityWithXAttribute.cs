using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using TsGenAspnetExample.Attributes;

namespace TsGenAspnetExample.Models
{
    /// <summary>
    /// Class with XAttribut. Test if ca export System.Xml.Linq assembly.
    /// </summary>
    [AlwaysExport]
    public class EntityWithXAttribute
    {
        /// <summary>
        /// test if ca export System.Xml.Linq assembly.
        /// </summary>
        public XAttribute XAttribute { get; set; }
    }
}
