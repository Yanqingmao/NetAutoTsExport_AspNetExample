using System;
using System.Collections.Generic;
using System.Text;

namespace TsGenAspnetExample.Models
{
    /// <summary>
    /// 对数据进行检查的结果
    /// </summary>
    public struct CheckResult
    {
        /// <summary>
        /// 是否存在错误
        /// </summary>
        public bool HasError { get; private set; }

        /// <summary>
        /// 错误原因
        /// </summary>
        public string ErrorReason { get; private set; }

        /// <summary>
        /// 将字符串隐式转换为一个错误的 CheckResult 对象;
        /// </summary>
        /// <param name="errorInfo"></param>
        public static implicit operator CheckResult(string errorInfo)
        {
            if (errorInfo == null) return CheckResult.Ok;
            return new CheckResult { HasError = true, ErrorReason = errorInfo };
        }

        /// <summary>
        /// 无错误的结果
        /// </summary>
        public static CheckResult Ok = new CheckResult { HasError = false };
    }
}
