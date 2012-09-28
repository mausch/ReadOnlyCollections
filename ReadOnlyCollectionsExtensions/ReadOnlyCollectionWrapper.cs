using System.Collections;
using System.Collections.Generic;

namespace ReadOnlyCollectionsExtensions.Wrappers {
    public class ReadOnlyCollectionWrapper<T> : IReadOnlyCollection<T> {
        private readonly ICollection<T> source;

        public ReadOnlyCollectionWrapper(ICollection<T> source) {
            this.source = source;
        }

        public IEnumerator<T> GetEnumerator() {
            return source.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return source.GetEnumerator();
        }

        public int Count {
            get { return source.Count; }
        }
    }
}