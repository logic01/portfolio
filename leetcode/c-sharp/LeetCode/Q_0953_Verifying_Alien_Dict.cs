
namespace LeetCode
{
    public static class Q_0953_Verifying_Alien_Dict
    {
        public static bool IsAlienSorted(string[] words, string order)
        {

            var hash = new Dictionary<char, int>();
            var val = 0;

            // build up hash of alient language order
            foreach (var c in order.ToCharArray())
            {
                hash.Add(c, val++);
            }

            for (var i = 0; i < words.Length - 1; i++)
            {
                // get two words to compare
                var current_word = words[i];
                var next_word = words[i + 1];

                // only loop through prefix
                var length = current_word.Length < next_word.Length ? current_word.Length : next_word.Length;

                for (var j = 0; j < length; j++)
                {
                    // get current char at index and get hash value
                    var current_char = hash[current_word[j]];
                    var next_char = hash[next_word[j]];

                    // words match
                    if (current_char == next_char)
                    {
                        // prefix are equal but the longer word should come second
                        if (j == length - 1 && current_word.Length > next_word.Length)
                            return false;

                        // check next char
                        continue;
                    }


                    // words in order
                    if (current_char < next_char)
                        break;

                    // words not in order
                    if (current_char > next_char)
                        return false;
                }

            }

            return true;
        }
    }
}
