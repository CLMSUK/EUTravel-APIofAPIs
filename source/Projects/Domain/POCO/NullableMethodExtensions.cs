using System;
using System.Globalization;

namespace EuTravel_2.BO
{
    public static class NullableMethodExtensions
    {
        public static string ToString<T>(this T? target, string format) where T : struct, IFormattable
        {
            return target?.ToString(format, CultureInfo.InvariantCulture);
        }

        public static object GetValueOrDefault(this object me, object defaultNumber)
        {
            return me;
        }
    }
}
