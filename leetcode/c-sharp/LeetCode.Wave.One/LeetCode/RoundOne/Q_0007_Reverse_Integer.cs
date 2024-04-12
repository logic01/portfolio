namespace LeetCode.RoundOne
{
    public static class Q_0007_Reverse_Integer
    {
        public static void Do(int x)
        {
            var res = DoIt(x);
        }

        private static int DoIt(int x)
        {
            int result = 0;
            bool neg = false;
            if (x < 0)
                neg = true;

            x = Math.Abs(x);

            while (x > 0)
            {
                result *= 10;
                result += x % 10;
                x -= result % 10;
                x /= 10;
            }

            return !neg ? result : result * -1;
        }
    }
}