using System;

namespace System.Collections.Generic {
    public interface IReadOnlyCollection<out T> : IEnumerable<T> {
        int Count { get; }
    }

    public interface IReadOnlyList<out T> : IReadOnlyCollection<T> {
        T this[int index] { get; }
    }

    public interface IReadOnlyDictionary<TKey, TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>> {
        TValue this[TKey key] { get; }
        IEnumerable<TKey> Keys { get; }
        IEnumerable<TValue> Values { get; }
    }
}
