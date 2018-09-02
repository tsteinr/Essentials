using System;

namespace Essentials
{
    /// <summary>
    /// Guard
    /// </summary>
    public static class Guard
    {
        /// <summary>
        /// ArgumentNotNull
        /// </summary>
        /// <param name="value"></param>
        /// <param name="message"></param>
        public static void ArgumentNotNull(Object value, String message)
        {
            if (value == null)
            {
                throw new ArgumentNullException(String.IsNullOrEmpty(message) ? nameof(value) : message);
            }
        }
    }
}
