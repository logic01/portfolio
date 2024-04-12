using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Practice.RoundTwo
{
    public class MultiMap<T,V> : IEnumerable<KeyValuePair<T, List<V>>>
    {
        private readonly Dictionary<T, List<V>> map = [];

        IEnumerable<T> Keys => map.Keys;
        IEnumerable<List<V>> Values => map.Values;
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

        public void Add(T key, List<V> value)
        {
            map.Add(key, value);
        }

        public IEnumerator<KeyValuePair<T, List<V>>> GetEnumerator()
        {
            return map.GetEnumerator();
        }


    }
}
