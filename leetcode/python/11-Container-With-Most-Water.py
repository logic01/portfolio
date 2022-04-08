# https://leetcode.com/problems/container-with-most-water/

# You are given an integer array height of length n.
# There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
# Find two lines that together with the x-axis form a container, such that the container contains the most water.
# Return the maximum amount of water a container can store.
# Notice that you may not slant the container.

from typing import List


class Solution:
    def maxArea(self, heights: List[int]) -> int:

        maxArea = 0

        # L * W = Area
        # (i, 0) and (i, height[i]).
        for index_one, height_one in enumerate(heights):
            for index_two, height_two in enumerate(heights):
                width = index_two - index_one
                height = height_one < height_two and height_one or height_two
                area = width * height
                maxArea = area > maxArea and area or maxArea
        return maxArea


sln = Solution()
sln.maxArea([1,8,6,2,5,4,8,3,7])