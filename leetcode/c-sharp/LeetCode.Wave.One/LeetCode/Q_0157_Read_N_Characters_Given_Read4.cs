
namespace LeetCode
{
    public static class Q_0157_Read_N_Characters_Given_Read4
    {
        public static int Read(char[] buf, int n)
        {

            var i = 0;

            while (i < n)
            {

                var buf4 = new char[4];
                var read = 0; //Read4(buf4); (we don't have the Read4 method)

                // nothing left to read
                if (read == 0)
                    break;

                var j = 0;

                while (j < read && i < n)
                {
                    buf[i] = buf4[j];
                    j++;
                    i++;
                }
            }

            return i;
        }
    }
}
