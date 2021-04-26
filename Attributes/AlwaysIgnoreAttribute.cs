using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TsGenAspnetExample.Attributes
{
    /// <summary>
    /// Define a attribute class which wouldn't export the class to the client
    /// evenif this class is used by one controller act as a input parameter.
    /// but will export when it is used by a controller act as a outout result.
    /// </summary>
    public class AlwaysIgnoreAttribute : Attribute
    {
    }
}