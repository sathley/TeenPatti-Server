using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TeenPatti.Model
{
    public static class Extensions
    {
        public static bool IsTrue(this string isTrue)
        {
            return string.IsNullOrWhiteSpace(isTrue) == false && "|1|y|yes|true|on|".IndexOf(isTrue, StringComparison.InvariantCultureIgnoreCase) != -1;
        }

        public static string RemoveSpecialChars(this string input)
        {
            return Regex.Replace(input, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled);
        }

        public static void AddOrUpdateRange<TK, TV>(this Dictionary<TK, TV> destination, Dictionary<TK, TV> source)
        {
            if (source == null)
                return;
            foreach (var key in source.Keys)
                destination[key] = source[key];
        }

        

        public static TValue ValueOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> map, TKey key, TValue defaultValue)
        {
            TValue value;
            if (map != null && map.TryGetValue(key, out value) == true && value != null)
                return value;
            else return defaultValue;
        }

        

        public static IDictionary<TKey, TValue> ToThreadSafeDictionary<TKey, TValue>(this IEnumerable<TValue> list, Func<TValue, TKey> keySelector)
        {
            var dictionary = new ConcurrentDictionary<TKey, TValue>();
            if (list != null && list.Count() > 0)
            {
                list.For(item => dictionary[keySelector(item)] = item);
            }
            return dictionary;
        }

        public static void For<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            var list = enumerable as List<T>;
            if (list != null)
                list.ForEach(action);
            else
                foreach (var item in enumerable)
                    action(item);
        }
    }
}
