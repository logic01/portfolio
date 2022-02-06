namespace Verifying_an_Alien_Dictionary
{
    public class AlienSort
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            var lastWord = words[0];

            foreach (var word in words)
            {
                if (lastWord == word)
                {
                    continue;
                }

                if (!IsLexy(lastWord, word, order))
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsLexy(string word_one, string word_two, string alphabet)
        {
            var chars_one = word_one.ToCharArray();
            var chars_two = word_two.ToCharArray();

            for (int i = 0; i < chars_one.Length && i < chars_two.Length; i++)
            {
                var index_one = alphabet.IndexOf(chars_one[i]);
                var index_two = alphabet.IndexOf(chars_two[i]);

                if (index_one == index_two)
                    continue;

                return index_one < index_two;
            }

            return chars_one.Length < chars_two.Length;
        }
    }
}
