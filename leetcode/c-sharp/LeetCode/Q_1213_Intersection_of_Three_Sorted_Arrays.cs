
namespace LeetCode
{
    public static class Q_1213_Intersection_of_Three_Sorted_Arrays
    {
        public static void Do()
        {
            var result = ThreePointers(
                new[] { 1, 2, 3, 4, 5 },
                new[] { 1, 2, 5, 7, 9 },
                new[] { 1, 3, 4, 5, 8 }
                );
        }

        public static IList<int> Library(int[] arr1, int[] arr2, int[] arr3)
        {
            return arr1.Intersect(arr2).Intersect(arr3).ToList();
        }

        public static IList<int> ThreePointers(int[] arr1, int[] arr2, int[] arr3)
        {

            int i = 0;
            int j = 0;
            int k = 0;

            var results = new List<int>();

            while (i < arr1.Length && j < arr2.Length && k < arr3.Length)
            {
                var v1 = arr1[i];
                var v2 = arr2[j];
                var v3 = arr3[k];

                if (v1 == v2 && v1 == v3)
                {
                    results.Add(v1);
                    i++;
                    j++;
                    k++;
                    continue;
                }

                var min = Math.Min(v1, Math.Min(v2, v3));

                if (v1 == min)
                    i++;

                if (v2 == min)
                    j++;

                if (v3 == min)
                    k++;
            }

            return results;
        }
    }
}