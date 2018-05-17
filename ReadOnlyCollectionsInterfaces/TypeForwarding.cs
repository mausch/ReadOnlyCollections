#if NET45
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: TypeForwardedTo(typeof(IReadOnlyCollection<>))]
[assembly: TypeForwardedTo(typeof(IReadOnlyList<>))]
[assembly: TypeForwardedTo(typeof(IReadOnlyDictionary<,>))]
#endif