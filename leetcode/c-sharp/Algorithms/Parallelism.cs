using System.Collections.Concurrent;

namespace Algorithms
{
    public class Parallelism
    {
        public async IAsyncEnumerable<int> YieldReturnAsync()
        {
            for (int i = 0; i <= 200; i += 2)
            {
                // return i
                yield return await Task.FromResult(i);

                // stops yielding when we hit 199
                if (i == 199)
                    yield break;
            }
        }

        public IEnumerable<int> YieldReturn()
        {
            for (int i = 0; i <= 200; i += 2)
            {
                // return i
                yield return i;

                // stops yielding when we hit 199
                if (i == 199)
                    yield break;
            }
        }

        public async Task<bool> FromResult()
        {
            // When you're implementing an interface that allows asynchronous callers, but your implementation is synchronous.
            // When you're stubbing/mocking asynchronous code for testing.
            return await Task.FromResult(true);
        }

        public async Task WhenAny()
        {
            int[] range = Enumerable.Range(0, 10).ToArray();

            List<Task<int>> tasks = [];

            foreach (int r in range)
                tasks.Add(GetData());

            while (tasks.Count > 0)
            {
                Console.WriteLine($"count-{tasks.Count}");

                var task = await Task.WhenAny(tasks);

                if (task.IsCompletedSuccessfully)
                    Console.WriteLine(task.Result);

                tasks.Remove(task);
            }
        }

        private async void TaskRun()
        {
            int[] items = [1, 2, 3, 4];
            ConcurrentDictionary<int, int> dic = new();

            List<Task> tasks = [];
            for (int i = 0; i < items.Length; i++)
            {
                // Create a task that adds data to an concurrent dictionary
                var task = Task.Run(() => dic.AddOrUpdate(i, i, (i, oldValue) => oldValue++));

                tasks.Add(task);
            }

            await Task.WhenAll(tasks);
        }

        private async void TaskStartNew()
        {
            ConcurrentDictionary<int, int> dic = new();

            int[] items = [1, 2, 3, 4];

            // Track our Tasks
            List<Task> tasks = [];

            for (int i = 0; i < items.Length; i++)
            {
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    dic.TryAdd(i, i);
                }, TaskCreationOptions.LongRunning));
            }

            await Task.WhenAll(tasks);
        }

        private static async Task DoAsync()
        {
            // Makes this run async even if nothing under is called async
            await Task.Yield();
            await Task.Delay(1);
        }

        private async Task<int> GetData()
        {
            var r = new Random();
            await Task.Delay(r.Next(500, 10000));

            return r.Next(0, 1000);
        }

        private void Parallel_For()
        {
            int[] items = [1, 2, 3, 4];

            Parallel.For(0, items.Length, (index) =>
            {
                items[index]++;
            });
        }

        private void Parallel_For_Local_Vars()
        {
            int[] items = [1, 2, 3, 4];

            long total = 0;

            Parallel.For<long>(0, items.Length, () => 0,
            (j, loop, subtotal) =>
            {
                subtotal += items[j];
                return subtotal;
            },
            subtotal => Interlocked.Add(ref total, subtotal));
        }

        private void Parallel_ForEach()
        {
            int[] items = [1, 2, 3, 4];

            // Thread Safe memory space
            ConcurrentDictionary<int, int> dic = new();

            // Run this functionality in paralell
            Parallel.ForEach(items, i =>
            {
                dic.TryAdd(i, i);
            });
        }

        private async void Parallel_ForEachAsync()
        {
            ConcurrentDictionary<int, int> dic = new();

            int[] items = [1, 2, 3, 4];

            await Parallel.ForEachAsync(items, async (item, token) =>
            {
                var key = item;
                var val = item;
                dic.AddOrUpdate(key, val, (key, oldValue) => oldValue++);
                await Task.Yield();
            });
        }

    }
}
