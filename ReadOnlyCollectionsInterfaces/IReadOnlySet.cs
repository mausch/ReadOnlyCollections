using System;

namespace System.Collections.Generic
{
    /// <summary>
    /// Provides a readonly abstraction of a set.
    /// </summary>
    /// <typeparam name="T">The type of elements in the set.</typeparam>
    public interface IReadOnlySet<T> : IEnumerable<T>, IReadOnlyCollection<T>
    {
        /// <summary>
        /// Determines whether the current set is a proper (strict) subset of a specified collection.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns>true if the current set is a proper subset of other; otherwise false.</returns>
        bool IsProperSubsetOf(IEnumerable<T> other);

        /// <summary>
        /// Determines whether the current set is a proper (strict) superset of a specified collection.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns>true if the collection is a proper superset of other; otherwise false.</returns>
        bool IsProperSupersetOf(IEnumerable<T> other);

        /// <summary>
        /// Determine whether the current set is a subset of a specified collection.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns>true if the current set is a subset of other; otherwise false.</returns>
        bool IsSubsetOf(IEnumerable<T> other);

        /// <summary>
        /// Determine whether the current set is a super set of a specified collection.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns>true if the current set is a subset of other; otherwise false.</returns>
        bool IsSupersetOf(IEnumerable<T> other);

        /// <summary>
        /// Determines whether the current set overlaps with the specified collection.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns>true if the current set and other share at least one common element; otherwise, false.</returns>
        bool Overlaps(IEnumerable<T> other);

        /// <summary>
        /// Determines whether the current set and the specified collection contain the same elements.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns>true if the current set is equal to other; otherwise, false.</returns>
        bool SetEquals(IEnumerable<T> other);

        /// <summary>
        /// Determines if the set contains a specific item.
        /// </summary>
        /// <param name="item">The item to check if the set contains.</param>
        /// <returns>true if found; otherwise false.</returns>
        bool Contains(T item);
    }
}
