using NUnit.Framework;
using ReadOnlyCollectionsExtensions;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void AsReadOnlySet()
        {
            var set = new HashSet<int>(new[] { 1, 2, 3 });
            IReadOnlySet<int> readonlySet = set.AsReadOnlySet();
            CollectionAssert.AreEqual(expected: set, actual: readonlySet);
        }

        [Test]
        public void ToReadOnlySet()
        {
            var set = new[] { 1, 2, 3 };
            IReadOnlySet<int> readonlySet = set.ToReadOnlySet();
            CollectionAssert.AreEqual(expected: set, actual: readonlySet);
        }
    }
}