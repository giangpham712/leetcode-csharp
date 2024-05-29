# 41. First Missing Positive

Given an unsorted integer array nums. Return the smallest positive integer that is not present in nums.

You must implement an algorithm that runs in O(n) time and uses O(1) auxiliary space.

#### Example 1:
```
Input: nums = [1,2,0]
Output: 3
Explanation: The numbers in the range [1,2] are all in the array.
``` 

#### Example 2:
```
Input: nums = [3,4,-1,1]
Output: 2
Explanation: 1 is in the array but 2 is missing.
``` 

#### Example 3:
```
Input: nums = [7,8,9,11,12]
Output: 1
Explanation: The smallest positive integer 1 is missing.
```

#### Constraints:

- 1 <= nums.length <= 105
- -231 <= nums[i] <= 231 - 1

### Solution:

#### O(n) time and O(1) space:

- Use the input array to track progress
- Iterate the array and set all numbers that are negative or greater than the size of the array
- Iterate the array again, if the absolute value of a number `x` at index `i` is positive, set the value at index `x - 1` to 
  - 0 if the value at index `x-1` which is `nums[x - 1]` is 0
  - else, `-abs(nums[x - 1])` if `nums[x - 1]`
- Iterate the array for the last time, 
  - for the first number `x` at index `i` where `x` is not negative, return `i + 1`
  - if not found, return `len(nums) + 1`

#### O(n) time and O(n) space:

- Add a numbers into a set (or hash map)
- Iterate from 1 to n, return the value if it's missing from the set