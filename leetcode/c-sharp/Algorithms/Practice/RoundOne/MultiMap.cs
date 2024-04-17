using System.Collections;
using System.Collections.Concurrent;


namespace Algorithms.Practice.RoundOne
{
    public class MultiMap<T, V> : IEnumerable<KeyValuePair<T, HashSet<V>>>
        where T : notnull
        where V : notnull
    {
        private readonly ReaderWriterLockSlim _lock = new(LockRecursionPolicy.SupportsRecursion);

        private readonly ConcurrentDictionary<T, HashSet<V>> data = [];
        public IEnumerable<T> Keys => data.Keys;
        public IEnumerable<HashSet<V>> Values => data.Values;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<KeyValuePair<T, HashSet<V>>> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        public HashSet<V> this[T key]
        {
            get
            {
                return data[key];
            }
        }

        public void Add(T key, V value)
        {
            data.AddOrUpdate(key, [value], (key, oldValue) =>
            {
                oldValue.Add(value);
                return oldValue;
            });
        }

        public bool TryAdd(T key, HashSet<V> value)
        {
            return data.TryAdd(key, value);
        }

        public void AddRange(IEnumerable<KeyValuePair<T, V>> range)
        {
            foreach (var pair in range)            
                Add(pair.Key, pair.Value);            
        }

    }
}
