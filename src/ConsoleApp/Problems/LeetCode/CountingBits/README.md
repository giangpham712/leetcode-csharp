# [338. Counting Bits](https://leetcode.com/problems/counting-bits)

Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n), ans[i] is the number of 1's in the binary representation of i.

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




Follow up: 
- It is very easy to come up with a solution with a runtime of O(n log n). Can you do it in linear time O(n) and possibly in a single pass?
- Can you do it without using any built-in function (i.e., like __builtin_popcount in C++)?


### Solution:
- Numbers that are powers of 2 always have one bit
