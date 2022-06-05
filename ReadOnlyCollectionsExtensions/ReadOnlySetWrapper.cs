using System;
using System.Collections;
using System.Collections.Generic;

namespace ReadOnlyCollectionsExtensions
{
    public class ReadOnlySetWrapper<T>: IReadOnlySet<T>
    {
#if NET35
        private readonly HashSet<T> _set;

        public ReadOnlySetWrapper(HashSet<T> set)
        {
            _set = set;
        }
#else
        private readonly ISet<T> _set;

        public ReadOnlySetWrapper(ISet<T> set)
        {
            _set = set;
        }
#endif

        public bool IsProperSubsetOf(IEnumerable<T> other) => 
            _set.IsProperSubsetOf(other);

        /// <summary>
        /// Determines whether the current set is a proper (strict) superset of a specified collection.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns>true if the collection is a proper superset of other; otherwise false.</returns>
        public bool IsProperSupersetOf(IEnumerable<T> other) => 
            _set.IsProperSupersetOf(other);

        public bool IsSubsetOf(IEnumerable<T> other) => 
            _set.IsSubsetOf(other);

        public bool IsSupersetOf(IEnumerable<T> other) => 
            _set.IsSupersetOf(other);

        public bool Overlaps(IEnumerable<T> other) => 
            _set.Overlaps(other);

        public bool SetEquals(IEnumerable<T> other) => 
            _set.SetEquals(other);

        public int Count =>
            _set.Count;

        public bool Contains(T item) =>
            _set.Contains(item);

        public IEnumerator<T> GetEnumerator()
        {
            return _set.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _set.GetEnumerator();
        }
    }
}
