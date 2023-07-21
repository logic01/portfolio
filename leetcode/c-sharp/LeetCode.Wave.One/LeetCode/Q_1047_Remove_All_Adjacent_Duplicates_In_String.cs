
namespace LeetCode
{
    public static class Q_1047_Remove_All_Adjacent_Duplicates_In_String
    {
        public static string RemoveDuplicates(string s)
        {
            var stack = new Stack<char>();
            var cArray = s.ToCharArray();

            for (var i = 0; i < cArray.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(cArray[i]);
                    continue;
                }

                var pop = stack.Pop();

                if (cArray[i] != pop)
                {
                    stack.Push(pop);
                    stack.Push(cArray[i]);
                }
            }

            string result = String.Empty;

            while (stack.Count > 0)
                result = $"{stack.Pop()}{result}";

            return result;
        }
    }
}
