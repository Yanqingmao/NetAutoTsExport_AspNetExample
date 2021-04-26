using System.Globalization;
using TsGenAspnetExample.Models;

namespace TsGenAspnetExample.Models
{
    [AlwaysIgnore]
    public class MyDbContext
    {
        public DateTimeFormatInfo Calendar { get; set; }
    }
}