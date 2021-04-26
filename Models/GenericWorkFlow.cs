using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TsGenAspnetExample.Models
{
    /// <summary>
    /// generic work flow
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TState"></typeparam>
    public class GenericWorkFlow<TEntity, TState>
    {
        /// <summary>
        /// the instance of business object
        /// </summary>
        public TEntity EntityInstance { get; set; }
        /// <summary>
        /// current state of bussiness object
        /// </summary>
        public TState Current { get; set; }
        /// <summary>
        /// the next state of bussiness object
        /// </summary>
        public TState Next { get; set; }
    }
}