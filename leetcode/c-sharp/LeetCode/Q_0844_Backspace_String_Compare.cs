
namespace LeetCode
{
    public static class Q_0844_Backspace_String_Compare
    {
        public static bool Do()
        {
            string s = "bxj##tw";
            string t = "bxo#j##tw";

            var sStack = new Stack<char>(s);
            var tStack = new Stack<char>(t);

            while (sStack.Count > 0 || tStack.Count > 0)
            {

                int spop = 0;
                while (sStack.Count > 0 && sStack.Peek() == '#')
                {
                    sStack.Pop();
                    spop++;
                }

                while (spop != 0 && sStack.Count > 0)
                {
                    sStack.Pop();
                    spop--;
                }

                int tpop = 0;
                while (tStack.Count > 0 && tStack.Peek() == '#')
                {
                    tStack.Pop();
                    tpop++;
                }

                while (tpop != 0 && tStack.Count > 0)
                {
                    tStack.Pop();
                    tpop--;
                }

                if (sStack.Count == 0 ^ tStack.Count == 0)
                {
                    if (sStack.Count == 0 && tStack.Peek() != '#')
                        return false;

                    if (tStack.Count == 0 && sStack.Peek() != '#')
                        return false;

                    continue;
                }


                if (sStack.Count == 0 && tStack.Count == 0)
                    return true;

                if (sStack.Pop() != tStack.Pop())
                    return false;
            }

            return true;
        }

        public static bool BackspaceCompare(string s, string t)
        {
            var i = 0;
            var sStack = new Stack<char>();

            while (i < s.Length)
            {
                if (s[i] != '#')
                    sStack.Push(s[i]);
                else if (sStack.Count != 0)
                    sStack.Pop();
                i++;
            }

            var j = 0;
            var tStack = new Stack<char>();

            while (j < t.Length)
            {
                if (t[j] != '#')
                    tStack.Push(t[j]);
                else if (tStack.Count != 0)
                    tStack.Pop();

                j++;
            }

            if (tStack.Count != sStack.Count)
                return false;

            while (tStack.Count > 0)
            {
                var tVal = sStack.Pop();
                var sVal = tStack.Pop();

                if (sVal != tVal)
                    return false;
            }


            return true;
        }
    }
}
