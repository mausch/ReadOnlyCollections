ReadOnlyCollections
===================

Backported read-only collection interfaces and extensions/adapters around them

This repository contains two projects:

ReadOnlyCollectionsInterfaces is a backport of the new IReadOnly* interfaces in .NET 4.5, making these available to .NET 2.0 up to .NET 4.0

ReadOnlyCollectionsExtensions provides extension methods around these interfaces, converting or exposing IList<T> as IReadOnlyList<T>, etc
