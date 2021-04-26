using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TsGenAspnetExample.Attributes
{
    /// <summary>
    /// Define a attribute class which will export the class to the client
    /// evenif this class doesn't been used by any controller.
    /// </summary>
    public class AlwaysExportAttribute : Attribute
    {
    }
}