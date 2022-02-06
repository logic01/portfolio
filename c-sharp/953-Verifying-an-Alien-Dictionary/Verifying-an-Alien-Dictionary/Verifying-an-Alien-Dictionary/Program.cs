// https://leetcode.com/problems/verifying-an-alien-dictionary/

// In an alien language, surprisingly, they also use English lowercase letters, but possibly in a different order.
// The order of the alphabet is some permutation of lowercase letters.
// Given a sequence of words written in the alien language, and the order of the alphabet,
// return true if and only if the given words are sorted lexicographically in this alien language.

using Verifying_an_Alien_Dictionary;

var alienSort = new AlienSort();

Console.WriteLine(alienSort.IsAlienSorted(new string[] { "hello", "leetcode" }, "hlabcdefgijkmnopqrstuvwxyz"));

Console.WriteLine(alienSort.IsAlienSorted(new string[] { "word", "world", "row" }, "worldabcefghijkmnpqstuvxyz"));
Console.WriteLine(alienSort.IsAlienSorted(new string[] { "apple", "app" }, "abcdefghijklmnopqrstuvwxyz"));
Console.WriteLine(alienSort.IsAlienSorted(new string[] { "app", "apple" }, "abcdefghijklmnopqrstuvwxyz"));
Console.WriteLine(alienSort.IsAlienSorted(new string[] { "app", "app" }, "abcdefghijklmnopqrstuvwxyz"));