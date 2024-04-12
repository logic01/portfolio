using System.Collections;

namespace Algorithms.Practice.RoundThree
{
    public class MultiMap<T, V> : IEnumerable<KeyValuePair<T, IList<V>>>
        where T : notnull
        where V : notnull
    {
        private readonly Dictionary<T, IList<V>> map = [];

        public IEnumerable<T> Key => map.Keys;
        public IEnumerable<IList<V>> Values => map.Values;

        public IEnumerator<KeyValuePair<T, IList<V>>> GetEnumerator()
        {
            return map.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IList<V> this[T key]
        {
            get
            {
                return map[key];
            }
        }

        public void Add(T key, IList<V> value)
        {
            map.Add(key, value);
        }

    }
}
