using System.Collections.Concurrent;

namespace Algorithms.Practice.RoundOne
{
    public static class Parallelism
    {
        public static async Task Do()
        {
            int[] data = [1, 2, 3, 4, 5];

            ConcurrentBag<int> concurrentData = [];

            Parallel.ForEach(data, item =>
            {
                Task.Delay(100);
                item++;
                concurrentData.Add(item);
            });

            foreach (var val in concurrentData)
            {
                Console.WriteLine(val);
            }

            ConcurrentBag<int> concurrentTwo = [];
            ParallelOptions parallelOptions = new()
            {
                MaxDegreeOfParallelism = 3
            };

            await Parallel.ForEachAsync(data, parallelOptions, async (item, token) =>
            {
                await Task.Delay(100, token);
                item++;
                concurrentTwo.Add(item);
            });


            foreach (var val in concurrentTwo)
            {
                Console.WriteLine(val);
            }


        }
    }
}
