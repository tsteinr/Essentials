using System;
using System.Collections.Generic;
using System.Text;

namespace Essentials.Extensions
{
    /// <summary>
    /// Extensions for Int16
    /// </summary>
    public static class Int16Extensions
    {
        /// <summary>
        /// Converts Int16 into Boolean
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static Boolean ToBoolean(this Int16 instance) => Convert.ToBoolean(instance);
    }
}
