using System;
using System.Collections.Generic;

namespace Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First");
            BasicRoutine(new int[] { 2, 7, 11, 15 }, 9);
            DictionaryRoutine(new int[] { 2, 7, 11, 15 }, 9);

            Console.WriteLine("Second");
            BasicRoutine(new int[] { 3, 2, 4 }, 6);
            DictionaryRoutine(new int[] { 3, 2, 4 }, 6);

            Console.WriteLine("Third");
            BasicRoutine(new int[] { 3, 3 }, 6);
            DictionaryRoutine(new int[] { 3, 3 }, 6);

         /* Console.WriteLine("Last");
            var nums = FillArray(100);

            var random = new Random();
            int randomIndex1 = random.Next(0, nums.Length);
            int randomIndex2 = randomIndex1;
            while (randomIndex1 == randomIndex2)
            {
                randomIndex2 = random.Next(0, nums.Length);
            }

            var target = nums[randomIndex1] + nums[randomIndex2];

            Console.WriteLine(target);
            BasicRoutine(nums, target);
            DictionaryRoutine(nums, target);*/

        }

        private static void DictionaryRoutine(int[] nums, int target)
        {
            var start = DateTime.Now;

            var pairs = new Dictionary<int, int>();

            // { 1, 2, 3, 4, 5 }; 5  2,3
            for (int i = 0; i < nums.Length; i++)
            {
                // [4,0], [3,1] [2,3]
                var key = target - nums[i];

                if (pairs.ContainsKey(nums[i]))
                {
                    pairs.TryGetValue(nums[i], out int indexTwo);
                    Console.WriteLine($"[{indexTwo}, {i}] {nums[i]} + {nums[indexTwo]} = {nums[i] + nums[indexTwo]} {(DateTime.Now.Subtract(start).TotalMilliseconds)}");
                    break;
                }

                // store what my pair as the key and my index as the value
                pairs.Add(key, i);

            }
        }

        private static void BasicRoutine(int[] nums, int target)
        {
            var start = DateTime.Now;
            var found = false;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine($"[{i}, {j}] {nums[i]} + {nums[j]} = {nums[i] + nums[j]} {(DateTime.Now.Subtract(start).TotalMilliseconds)}");
                        found = true;
                        break;
                    }
                }

                if (found)
                    break;
            }
        }

        private static int[] FillArray(int length)
        {
            var nums = new List<int>();
            var sumations = new List<int>();

            for (int i = 0; i < length; i++)
            {
                var random = new Random();
                var value = random.Next();

                // value already exists so try again
                if (nums.Contains(value))
                {
                    i--;
                    continue;
                }

                var innerSummation = new List<int>() { value };
                var tryAgain = false;
                foreach (var num in nums)
                {
                    double target = value + num;

                    if (target > int.MaxValue)
                    {
                        innerSummation = new List<int>();
                        tryAgain = true;
                        break;
                    }

                    if (sumations.Contains((int)target) || innerSummation.Contains(num))
                    {
                        innerSummation = new List<int>();
                        tryAgain = true;
                        break;
                    }

                    innerSummation.Add((int)target);
                }

                if (!tryAgain)
                {
                    sumations.AddRange(innerSummation);
                    nums.Add(value);
                }
            }

            return nums.ToArray();
        }
    }
}
