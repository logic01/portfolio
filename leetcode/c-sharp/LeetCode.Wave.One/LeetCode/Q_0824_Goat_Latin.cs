
namespace LeetCode
{
    public static class Q_0824_Goat_Latin
    {
        public static string ToGoatLatin(string sentence)
        {
            var words = sentence.Split(" ");

            var maHash = new HashSet<char>();
            maHash.Add('a');
            maHash.Add('e');
            maHash.Add('i');
            maHash.Add('o');
            maHash.Add('u');
            maHash.Add('A');
            maHash.Add('E');
            maHash.Add('I');
            maHash.Add('O');
            maHash.Add('U');

            var index = 1;

            var finalSentence = String.Empty;

            foreach (var word in words)
            {

                var localWord = word;

                if (maHash.Contains(localWord[0]))
                    localWord = $"{localWord}ma";
                else
                {
                    var letter = localWord[0];
                    localWord = $"{localWord.Substring(1)}{letter}ma";
                }

                for (int i = 0; i < index; i++)
                {
                    localWord = $"{localWord}a";
                }

                if (index == 1)
                    finalSentence = $"{localWord}";
                else
                    finalSentence = $"{finalSentence} {localWord}";

                index++;
            }

            return finalSentence;
        }
    }
}
