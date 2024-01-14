using System;
using System.Collections.Generic;

namespace Intro.Lesson10
{
    public static class ListExtensions
    {
        public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> list, Func<T, bool> predicate) {

            foreach (var item in list) {
                if (predicate(item)) {
                    yield return item;
                }
            }
        }
    }
}