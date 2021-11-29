# https://leetcode.com/problems/two-sum/
# Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
# You may assume that each input would have exactly one solution, and you may not use the same element twice.
# You can return the answer in any order.

def brute_force(nums, target):
    print("target: ", target)
    print("nums: ", nums)
    found = False
    for i_index, iVal in enumerate(nums):
        for j_index, jVal in enumerate(nums):
            if(iVal + jVal == target):
                print(iVal, "+", jVal, "=", target)
                print(i_index, "-", j_index)
                found = True
                break
        if(found):
            break


def elegent(nums, target):
    print("target: ", target)
    print("nums: ", nums)
    dictionary = dict()
    for index, val in enumerate(nums):
      if(val in dictionary):
        print(val, "+", value, "=", target)
        print(index, "-", dictionary[val])
        break
      value = target-val
      print(value)
      dictionary[value] = index



brute_force([2, 7, 11, 15], 9)
brute_force([3, 2, 4], 6)
brute_force([3, 3], 6)

elegent([2, 7, 11, 15], 9)
elegent([3, 2, 4], 6)
elegent([3, 3], 6)