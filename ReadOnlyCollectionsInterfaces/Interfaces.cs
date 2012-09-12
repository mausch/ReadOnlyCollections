using System;

namespace System.Collections.Generic {
#if NET40
    public interface IReadOnlyCollection<out T> : IEnumerable<T> {
#elif NET20 || NET35
    public interface IReadOnlyCollection<T> : IEnumerable<T> {
#endif
        int Count { get; }
    }
#if NET40
    public interface IReadOnlyList<out T> : IReadOnlyCollection<T> {
#elif NET20 || NET35
    public interface IReadOnlyList<T> : IReadOnlyCollection<T> {
#endif
        T this[int index] { get; }
    }

    public interface IReadOnlyDictionary<TKey, TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>> {
        TValue this[TKey key] { get; }
        IEnumerable<TKey> Keys { get; }
        IEnumerable<TValue> Values { get; }
    }
}
