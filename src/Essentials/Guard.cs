using System;

namespace Essentials
{
    public static class Guard
    {
        public static void ArgumentNotNull(Object value, String message)
        {
            if (value == null)
            {
                throw new ArgumentNullException(String.IsNullOrEmpty(message) ? nameof(value) : message);
            }
        }
    }
}
