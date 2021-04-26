using System.Globalization;
using TsGenAspnetExample.Attributes;
using TsGenAspnetExample.Models;

namespace TsGenAspnetExample.Models
{
    /// <summary>
    /// will not exported to the client.
    /// </summary>
    [AlwaysIgnore]
    public class MyDbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTimeFormatInfo Calendar { get; set; }
    }
}