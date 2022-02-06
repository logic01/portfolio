# https://leetcode.com/problems/palindrome-number/
# Given an integer x, return true if x is palindrome integer.
# An integer is a palindrome when it reads the same backward as forward.
#   For example, 121 is a palindrome while 123 is not.


class Solution(object):

    def isPalindrome_asString(x) -> bool:

        # short circuit negative numbers
        if x < 0:
            return False

        # convert int to string
        x = str(x)
        length = (len(x) - 1)

        # loop through and compare each value to each other
        for i, j in zip(range(length), range(length, -1, -1)):
            if(i == j or i > j):
                break
            if(x[i] != x[j]):
                return False

        return True

    def isPalindrome_asInt(x) -> bool:

        # short circuit negative numbers
        if x < 0:
            return False

        z = x
        reverse = 0
        multiple = 10
        multiple_1 = 1
        while z > 0:
            y = z % 10
            z = (z - y) / 10
            reverse = reverse + (y * multiple_1)
            multiple_1 = multiple_1 * multiple

        i_reverse = int(reverse)

        if(i_reverse == x):
            return True

        return False

    def isPalindrome_rec(x, workingNum) -> bool:

        # short circuit negative numbers
        if x < 0:
            return False

        

        return False

    print("int:", isPalindrome_asInt(-121))
    print("int:", isPalindrome_asInt(1331))
    print("int:", isPalindrome_asInt(121))
    print("int:", isPalindrome_asInt(11211))
    print("int:", isPalindrome_asInt(1))
    print("int:", isPalindrome_asInt(102))
    print("int:", isPalindrome_asInt(1021))

    print("str:", isPalindrome_asString(-121))
    print("str:", isPalindrome_asString(1111))
    print("str:", isPalindrome_asString(121))
    print("str:", isPalindrome_asString(11211))
    print("str:", isPalindrome_asString(1))
    print("str:", isPalindrome_asString(102))
    print("str:", isPalindrome_asString(1021))
