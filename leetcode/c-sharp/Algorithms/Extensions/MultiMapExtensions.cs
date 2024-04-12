using Algorithms.Practice;

namespace Algorithms.Extensions
{
    public static class MultiMapExtensions
    {
        public static MultiMap<T, V> Union<T, V>(this MultiMap<T, V> m1, MultiMap<T, V> m2)
            where T : notnull
            where V : notnull
        {
            var results = new MultiMap<T, V>();

            foreach (var pair in m1)
            {
                if(m2.TryGetValue(pair.Key, out var value))
                {
                    if(value.SequenceEqual(pair.Value))
                        results.Add(pair.Key, pair.Value);
                }

            }

            return results;
        }
    }
}
