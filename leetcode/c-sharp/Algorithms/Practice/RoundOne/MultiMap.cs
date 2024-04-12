using System.Collections;


namespace Algorithms.Practice.RoundOne
{
    public class MultiMap<T, V> : IEnumerable<KeyValuePair<T, List<V>>>
        where T : notnull
        where V : notnull
    {
        private readonly Dictionary<T, List<V>> data = [];
        public IEnumerable<T> Keys => data.Keys;
        public IEnumerable<List<V>> Values => data.Values;

        public void Add(T key, List<V> value)
        {
            data.Add(key, value);
        }
        public bool TryAdd(T key, List<V> value)
        {
            return data.TryAdd(key, value);
        }

        public void AddRange(IEnumerable<KeyValuePair<T, List<V>>> range)
        {
            foreach(var pair in range)
            {
                data.Add(pair.Key, pair.Value);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<KeyValuePair<T, List<V>>> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        public List<V> this[T key]
        {
            get
            {
                return data[key];
            }
        }
    }
}
