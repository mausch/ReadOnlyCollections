using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadOnlyCollectionsExtensions {
    public static class ExtensionMethods {
        public static IReadOnlyCollection<T> AsReadOnlyCollection<T>(this ICollection<T> source) {
            return new ReadOnlyCollectionWrapper<T>(source);
        }

        public static IReadOnlyList<T> AsReadOnlyList<T>(this IList<T> source) {
            return new ReadOnlyListWrapper<T>(source);
        }

        public static IReadOnlyList<T> ToReadOnlyList<T>(this IEnumerable<T> source) {
            return source.ToList().AsReadOnlyList();
        }

        public static IReadOnlyDictionary<TKey, TValue> ToReadOnlyDictionary<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector, IEqualityComparer<TKey> comparer) {
            return new ReadOnlyDictionaryWrapper<TKey, TValue>(source.ToDictionary(keySelector, valueSelector, comparer));
        }

        public static IReadOnlyDictionary<TKey, TValue> ToReadOnlyDictionary<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector) {
            return new ReadOnlyDictionaryWrapper<TKey, TValue>(source.ToDictionary(keySelector, valueSelector));
        }

        public static IReadOnlyDictionary<TKey, TValue> ToReadOnlyDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> dict) {
            return new ReadOnlyDictionaryWrapper<TKey, TValue>(dict.ToDictionary(x => x.Key, x => x.Value));
        }

        public static IReadOnlyDictionary<TKey, TValue> ToReadOnlyDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> dict, IEqualityComparer<TKey> comparer) {
            return new ReadOnlyDictionaryWrapper<TKey, TValue>(dict.ToDictionary(x => x.Key, x => x.Value, comparer));
        }

        public static IReadOnlyDictionary<TKey, TValue> AsReadOnlyDictionary<TKey, TValue>(this IDictionary<TKey, TValue> dict) {
            return new ReadOnlyDictionaryWrapper<TKey, TValue>(dict);
        }
    }
}
