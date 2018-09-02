using System;
using System.Collections.Generic;
using System.Text;

namespace Essentials.Extensions
{
    /// <summary>
    /// Extensions for Boolean
    /// </summary>
    public static class BooleanExtensions
    {
        /// <summary>
        /// Converts Boolean into Int16
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static Int16 ToInt16(this Boolean instance) => Convert.ToInt16(instance);
    }
}
