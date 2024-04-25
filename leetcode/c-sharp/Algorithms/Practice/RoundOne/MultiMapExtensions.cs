using System.Reflection;

namespace Algorithms.Practice.RoundOne
{
    public static class MultiMapExtensions
    {
        public static MultiMap<T, V> Union<T, V>(this MultiMap<T, V> map1, MultiMap<T, V> map2)
            where T: notnull
            where V: notnull
        {
            var result = new MultiMap<T, V>();

          // result.AddRange(map1.Where((pair) => map2.Contains(pair)));

            return result;
        }
    }
}
