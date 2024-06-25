# [53. Maximum Subarray](https://leetcode.com/problems/maximum-subarray)

#### Example 1:
```
Input: 
Output: 
Explanation:
``` 

#### Example 2:
```
Input: 
Output: 
Explanation:
``` 

#### Example 3:
```
Input: 
Output: 
Explanation:
```

#### Constraints:

-


### Solution:

#### Iterate the array

- Use two variables
  - one for tracking the max
  - one for tracking the current sum
- At each index 
  - if the sum before adding the number at the current index is negative, update current to the value of the current index
  - if the sum before adding the number at the current index is positive and adding the value makes it negative, update current to the value of the current index
  - otherwise, add the value to current
  - update the max if the current sum is larger

#### Divide and conquer
