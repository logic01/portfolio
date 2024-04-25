using System.Collections.Concurrent;

namespace Algorithms.Practice.RoundOne
{
    public class Parallelism
    {

        public void ConcurrentCollections()
        {
            ConcurrentDictionary<int, string> cdic = [];
            ConcurrentQueue<int> cque = [];
            Stack<int> stack = [];
        }

        public void ParallelFor()
        {
            int[] items = [1, 2, 3, 4];

            Parallel.For(0, items.Length, (index) =>
            {
                items[index]++;
            });
        }
       
        public async void ParallelForAsync()
        {
            int[] items = [1, 2, 3, 4];

            await Parallel.ForAsync(0, items.Length, async (index, token) =>
            {
                index++;
                await Task.Yield();
            });

            var tasks = Enumerable.Range(0, 100).Select(async (index) =>
            {
                await Task.Yield();

                return 1;
            });

            await Task.WhenAll(tasks);
        }

        public void ParallelForLocal()
        {
            int[] items = [1, 2, 3, 4];
            int total = 0;

            Parallel.For(0, items.Length, () => 0,
                (index, loop, subtotal) =>
                {
                    subtotal += items[index];
                    return subtotal;
                },
                subtotal => Interlocked.Add(ref total, subtotal)
            );
        }

        public void ParallelForEach()
        {
            int[] items = [1, 2, 3, 4];

            Parallel.ForEach(items, (item) =>
            {
                item++;
            });
        }

        public async void ParallelForEachAsync()
        {
            int[] items = [1, 2, 3, 4];

            await Parallel.ForEachAsync(items, async (item, token) =>
            {
                item++;
                await Task.Yield();
            });
        }

        public async void TaskRun()
        {
            int[] items = [1, 2, 3, 4];

            List<Task> tasks = [];

            tasks.Add(Task.Run(() => { }));

            await Task.WhenAll(tasks);
        }

        public async void TaskStartNew()
        {
            int[] items = [1, 2, 3, 4];

            List<Task> tasks = [];

            tasks.Add(Task.Factory.StartNew(() => { }, TaskCreationOptions.LongRunning));

            await Task.WhenAll(tasks);
        }
    }
}
