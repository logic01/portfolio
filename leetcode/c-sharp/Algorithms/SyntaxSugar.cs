using Algorithms.Util;

namespace Algorithms
{
    public static class SyntaxSugar
    {


        public static void Do()
        {
            int val = 10;
            ListChild<int> node = [];

            if (val is >= 10 and < 100 and not 6)
                Console.Write("look at me now!");

            if (node is List<int> n)
                Casted(n);

            int[] arr = [1, 2, 3, 4, 5];
            
            if (arr is [_, var second, .., 4, var last])
                Console.WriteLine($"Pattern Matched 4 {second}{last}");

            if (arr is [_, var two, .., 3, var five])
                Console.WriteLine($"Pattern Matched 3: {two}{five}");

        }

        private static void Casted(List<int> data)
        {

        }
    }
}
