using System;
using System.Collections.Generic;
using System.Text;

namespace TsGenAspnetExample.Models
{
    /// <summary>
    /// Check result for all object
    /// </summary>
    public struct CheckResult
    {
        /// <summary>
        /// Whether exists error
        /// </summary>
        public bool HasError { get; private set; }

        /// <summary>
        /// when HasError=true, the error reason
        /// </summary>
        public string ErrorReason { get; private set; }

        /// <summary>
        /// implicit convert string to CheckResult instance
        /// </summary>
        /// <param name="errorInfo"></param>
        public static implicit operator CheckResult(string errorInfo)
        {
            if (errorInfo == null) return CheckResult.Ok;
            return new CheckResult { HasError = true, ErrorReason = errorInfo };
        }

        /// <summary>
        /// CheckResult instance without error
        /// </summary>
        public static CheckResult Ok = new CheckResult { HasError = false };
    }
}
