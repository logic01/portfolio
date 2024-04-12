namespace LeetCode
{
    // -2147483648 to 2147483647

    // Convert an Integer into it's reverse.
    public static class Q_0007_Reverse_Integer
    {
        public static int Reverse(int x)
        {
            var isNeg = x < 0;

            if (isNeg)
                x *= -1;

            double reverse = 0;

            while (x > 0)
            {
                var number = (x % 10);

                reverse = (reverse * 10) + number;

                if (reverse < int.MinValue || reverse > int.MaxValue)
                {
                    reverse = 0;
                    break;
                }

                x = (x - number) / 10;
            }

            return isNeg ? -1 * (int)reverse : (int)reverse;
        }
    }
}
