using System;

namespace WouldLike.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime TrimMillisecond(this DateTime input)
        {
            return new DateTime(
                input.Year,
                input.Month,
                input.Day,
                input.Hour,
                input.Minute,
                input.Second,
                millisecond: 0,
                input.Kind);
        }
    }
}
