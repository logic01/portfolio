using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Algorithms.Practice
{
    public class MultiMap<T, V> : IEnumerable<KeyValuePair<T, List<V>>>
        where T : notnull
        where V : notnull
    {
        private readonly Dictionary<T, List<V>> _map;

        public MultiMap()
        {
            _map = new();
        }

        public MultiMap(Dictionary<T, List<V>> map)
        {
            _map = map;
        }

        public IEnumerable<T> Keys => _map.Keys;
        public IEnumerable<List<V>> Values => _map.Values;

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T key, List<V> value)
        {
            _map.Add(key, value);
        }

        public bool TryAdd(T key, List<V> value)
        {
            return _map.TryAdd(key, value);
        }

        public bool TryGetValue(T key, [MaybeNullWhen(false)] out List<V> value)
        {           
            return _map.TryGetValue(key, out value);
        }

        public List<V> this[T key]
        {
            get
            {
                return _map[key];
            }
        }

        public IEnumerator<KeyValuePair<T, List<V>>> GetEnumerator()
        {
            return _map.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public void Add(KeyValuePair<T, List<V>> item)
        {
            _map.Add(item.Key, item.Value);
        }

        public void Clear()
        {
            _map.Clear();
        }

        public bool Contains(KeyValuePair<T, List<V>> item)
        {
            return _map.Contains(item);
        }

        public void CopyTo(KeyValuePair<T, List<V>>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<T, List<V>> item)
        {
           return _map.Remove(item.Key);
        }
    }
}
