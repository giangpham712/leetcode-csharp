# [42. Trapping Rain Water](https://leetcode.com/problems/trapping-rain-water)

Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.

#### Example 1:
```
Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
Output: 6
Explanation: The above elevation map (black section) is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. In this case, 6 units of rain water (blue section) are being trapped.
``` 

#### Example 2:
```
Input: height = [4,2,0,3,2,5]
Output: 9
``` 

#### Constraints:

- n == height.length
- 1 <= n <= 2 * 104
- 0 <= height[i] <= 105

### Solution:
- Observation: The trapped water level at an index is the min of its left highest bar and right highest bar
- We use two arrays to keep track of the highest bar to the left and highest bar to the right at each index
- Iterate the list and for each index, keep track of the highest bars on its left and right
- Iterate the list again to calculate and sum up the water level