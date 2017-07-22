using System;
using System.Collections.Generic;
using System.Linq;

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
    }
}
