using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Q_0408_Valid_Word_Abbreviation
    {
        public static bool Do(string word, string abbr)
        {

            // quick exit
            if (word == abbr)
                return true;

            // could use arrays but I felt like trying queues.
            var letter_q = new Queue<Char>(word.ToCharArray());
            var abbr_q = new Queue<Char>(abbr.ToCharArray());

            // loop through abbreviation
            while (abbr_q.Count > 0)
            {

                // early exit - we don't have any matching letters to match
                if (letter_q.Count == 0)
                    return false;

                // deal with alpha
                if (!Char.IsDigit(abbr_q.Peek()))
                {

                    // our letters do not match so our abbreviation does not match
                    if (letter_q.Dequeue() != abbr_q.Dequeue())
                        return false;

                    continue;
                }

                // pull all the digits from the abbr queue and calculate a length
                var digit = 0;
                while (abbr_q.Count > 0 && Char.IsDigit(abbr_q.Peek()))
                {

                    // calculate new digit
                    // (digit * 10) push our digits to the left as we loop
                    // abbr_q.Dequeue() - '0' char ascii math to get the decimal represetnation of the char
                    digit = (digit * 10) + abbr_q.Dequeue() - '0';

                    // no leading zero!
                    if (digit == 0)
                        return false;
                }

                // Dequeue n letters from our letter queue
                while (digit > 0)
                {

                    // if we run out of letters then our abbreviation is wrong
                    if (letter_q.Count == 0)
                        return false;

                    // pop one char for the count of digits
                    letter_q.Dequeue();

                    digit--;
                }

            }

            // make sure both queues are empty.
            // if they are not empty then we have hanging chads
            return abbr_q.Count == 0 && letter_q.Count == 0;

        }
    }
}
