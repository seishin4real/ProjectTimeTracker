using System;
using System.Collections.Generic;
using System.Linq;

using ProjectTimeTracker.Models;

namespace ProjectTimeTracker
{
    public static class Extensions
    {
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> list, Action<T> action)
        {
            var items = list as T[] ?? list.ToArray();
            foreach (var item in items)
            {
                action(item);
            }

            return items;
        }

        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek = DayOfWeek.Monday)
        {
            var diff = dt.DayOfWeek - startOfWeek;
            if (diff < 0)
            {
                diff += 7;
            }
            return dt.AddDays(-1 * diff).Date;
        }
        public static DateTime EndOfWeek(this DateTime dt, DayOfWeek startOfWeek = DayOfWeek.Monday) => dt.StartOfWeek(startOfWeek).AddDays(6);
        public static DateTime StartOfMonth(this DateTime dt) => new DateTime(dt.Year, dt.Month, 1);
        public static DateTime EndOfMonth(this DateTime dt) => new DateTime(dt.Year, dt.Month, 1).AddDays(-1).AddMonths(1);

        public static (TimeSpan TotalTime, (DateTime Day, TimeSpan Time)[] Days) SumTimes(this IEnumerable<ProjectEntry> items)
        {
            var days = items.GroupBy(i => i.Start.Date)
                .Select(g => (
                    Day: g.Key,
                    Time: TimeSpan.FromTicks(g.Sum(i => ((i.End ?? DateTime.Now) - i.Start).Ticks))
                ))
                .ToArray();

            var totalTime = TimeSpan.FromTicks(days.Sum(r => r.Time.Ticks));

            return (totalTime, days);
        }
    }
}
