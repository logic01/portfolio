namespace Algorithms.Practice.RoundThree
{
    public static class MultiMapExtensions
    {
        public static MultiMap<T, V> Union<T, V>(this MultiMap<T, V> m1, MultiMap<T, V> m2)
            where T : notnull
            where V : notnull
        {
            MultiMap<T, V> map = [];

            var data = m1.Where(pair => m2.Contains(pair));

            foreach (var pair in data)
            {
                map.Add(pair.Key, pair.Value);
            }

            return map;
        }
    }
}
