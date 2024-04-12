using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Parallelism
    {
        public async void Do()
        {
            // List of items to execute on
            List<int> items = [1, 2, 3, 4];

            // Thread Safe memory space
            ConcurrentDictionary<int, int> dic = new ();

            // Run this functionality in paralell
            Parallel.ForEach(items, i =>
            {
                dic.TryAdd(i, i);
            });

            // Track our Tasks
            List<Task> tasks = [];

            for (int i = 0; i < items.Count; i++)
            {
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    dic.TryAdd(i, i);
                }));
            }

            await Task.WhenAll(tasks);
        }

        private static async Task DoAsync()
        {
            // Makes this run async even if nothing under is called async
            await Task.Yield();
            await Task.Delay(1);
        }
    }
}
