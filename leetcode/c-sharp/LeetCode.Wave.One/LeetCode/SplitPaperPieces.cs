namespace LeetCode
{
    public class SplitPaperPieces
    {
        public static void Do()
        {
            int[] o1 = new int[] { 2, 3, 7, 5, 6, 1, 8, 4, 12, 10, 11, 9 };
            int[] d1 = new int[] { 1, 2, 3, 4, 7, 5, 6, 8, 11, 9, 12, 10 };

            Console.WriteLine(Do(o1, d1));

            int[] o2 = new int[] { 1, 4, 3, 2, 5 };
            int[] d2 = new int[] { 1, 4, 3, 5, 2 };


            Console.WriteLine(Do(o2, d2));

            int[] o3 = new int[] { 1, 4, 3, 2 };
            int[] d3 = new int[] { 4, 3, 1, 2 };


            Console.WriteLine(Do(o3, d3));

            int[] o4 = new int[] { 1, 3, 4, 2 };
            int[] d4 = new int[] { 4, 2, 1, 3 };


            Console.WriteLine(Do(o4, d4));
        }

        private static int Do(int[] original, int[] desired)
        {

            if (original.Length != desired.Length)
                throw new ArgumentException("Invalid Request");

            var windows = new Dictionary<int, int>();

            // Loop through every desired item
            for (int desired_index = 0; desired_index < desired.Length;)
            {
                int original_index = 0;

                // move through the originals until we find the desired item
                while (desired[desired_index] != original[original_index])
                {
                    if (windows.TryGetValue(original_index, out int value))
                        original_index += value;
                    else
                        original_index++;
                }

                // capture the index of the start of our window
                int startIndex = original_index;
                int windowLength = 0;

                // move through our window until we have as many matches as possible
                // don't exceed our array lengths
                while (desired_index < desired.Length
                    && original_index < original.Length
                    && desired[desired_index] == original[original_index])
                {
                    original_index++;
                    desired_index++;
                    windowLength++;
                }

                // add this section of the array to a dictionary for fast reference.
                windows.Add(startIndex, windowLength);
            }

            return windows.Count;
        }
    }
}
