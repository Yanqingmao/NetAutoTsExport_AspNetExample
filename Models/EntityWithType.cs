using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace TsGenAspnetExample.Models
{
    /// <summary>
    /// 
    /// </summary>
    [AlwaysExport]
    public class EntityWithType
    {
        ///// <summary>
        ///// 带有一个 Type属性的类
        ///// </summary>
        //public Type ThisType { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //public XmlDocument XmlDocument { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //public XmlDocumentType XmlDocumentType { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //public XDocumentType XDocumentType { get; set; }

        //public XElement XElement { get; set; }

        public XAttribute XAttribute { get; set; }
        ///// 
        //public EntityWithType Left { get; set; }
        // public EntityWithType Right { get; set; }
    }
}
