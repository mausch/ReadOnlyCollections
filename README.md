ReadOnlyCollections
===================

Backported read-only collection interfaces and extensions/adapters around them.

This repository contains two projects:

**ReadOnlyCollectionsInterfaces** is a backport of the new IReadOnly* interfaces, making them available to .NET 2.0 up to .NET 4.6.2

The interfaces are:

- [IReadOnlyCollection&lt;T&gt;](http://msdn.microsoft.com/en-us/library/hh192385.aspx)
- [IReadOnlyList&lt;T&gt;](http://msdn.microsoft.com/en-us/library/hh881542.aspx)
- [IReadOnlyDictionary&lt;TKey, TValue&gt;](http://msdn.microsoft.com/en-us/library/hh136548.aspx)
- [IReadOnlySet&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlyset-1) (only for .NET 3.5+)

**ReadOnlyCollectionsExtensions** provides minimal extension methods around these interfaces, converting or exposing IList<T> as IReadOnlyList<T>, etc
These are designed to be similar to `System.Linq.Enumerable.ToList()`, etc

```
IReadOnlyCollection<T> AsReadOnlyCollection<T>(this ICollection<T> source)
IReadOnlyList<T> AsReadOnlyList<T>(this IList<T> source)
IReadOnlyList<T> ToReadOnlyList<T>(this IEnumerable<T> source)
IReadOnlyDictionary<TKey, TValue> ToReadOnlyDictionary<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector, IEqualityComparer<TKey> comparer)
IReadOnlyDictionary<TKey, TValue> ToReadOnlyDictionary<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector)
IReadOnlyDictionary<TKey, TValue> ToReadOnlyDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> dict)
IReadOnlyDictionary<TKey, TValue> ToReadOnlyDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> dict, IEqualityComparer<TKey> comparer)
IReadOnlyDictionary<TKey, TValue> AsReadOnlyDictionary<TKey, TValue>(this IDictionary<TKey, TValue> dict)
IReadOnlySet<T> AsReadOnlySet<T>(this ISet<T> source)
IReadOnlySet<T> ToReadOnlySet<T>(this IEnumerable<T> source)
```

[**Binaries available on NuGet.**](https://nuget.org/packages?q=ReadOnlyCollection)
