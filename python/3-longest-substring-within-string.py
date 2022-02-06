# https://leetcode.com/problems/longest-substring-without-repeating-characters/
# Given a string s, find the length of the longest substring without repeating characters.


class Solution(object):

    # brute force -
    # - loop through array
    # - add char to hash set (if exist) exit
    # - return count of hash set
    # - highest count wins

    # O(n^2)
    def lengthOfLongestSubstring(self, s: str) -> int:
        count = 0

        for ch_1 in s:
            hash = set()
            for ch in s:
                if(ch not in hash):
                    hash.add(ch)
                else:
                    break

            length = len(hash)

            if(length > count):
                count = len(hash)
            s = s[1:]

        return count

    def lengthOfLongestSubstring_index(self, string: str) -> int:

        stack = []
        n = 0

        for i in string:
            if i not in stack:
                stack.append(i)
                n = max(n, len(stack))
            else:
                stack.append(i)
                stack = stack[stack.index(i)+1:]


sln = Solution()
print(sln.lengthOfLongestSubstring_index("pwwkew"))  # Output: 3
print(sln.lengthOfLongestSubstring_index("abcabcbb"))  # Output: 3
print(sln.lengthOfLongestSubstring_index("bbbbb"))  # Output: 1
print(sln.lengthOfLongestSubstring_index("abcalpot"))  # Output: 7

print(sln.lengthOfLongestSubstring("pwwkew"))  # Output: 3
print(sln.lengthOfLongestSubstring("abcabcbb"))  # Output: 3
print(sln.lengthOfLongestSubstring("bbbbb"))  # Output: 1
print(sln.lengthOfLongestSubstring("abcalpot"))  # Output: 7
