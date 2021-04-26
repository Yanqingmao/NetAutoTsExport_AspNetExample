using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TsGenAspnetExample.Models
{

    /// <summary>
    /// 泛型工作流类定义
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TState"></typeparam>
    public class GenericWorkFlow<TEntity, TState>
    {
        /// <summary>
        /// 实体实例
        /// </summary>
        public TEntity EntityInstance { get; set; }
        /// <summary>
        /// 当前状态
        /// </summary>
        public TState Current { get; set; }
        /// <summary>
        /// 下一个状态
        /// </summary>
        public TState Next { get; set; }
    }
}