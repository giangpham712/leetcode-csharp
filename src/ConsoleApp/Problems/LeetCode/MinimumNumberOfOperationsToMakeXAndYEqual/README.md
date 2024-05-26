# [2998. Minimum Number of Operations to Make X and Y Equal](https://leetcode.com/problems/minimum-number-of-operations-to-make-x-and-y-equal)

You are given two positive integers x and y.

In one operation, you can do one of the four following operations:

    Divide x by 11 if x is a multiple of 11.
    Divide x by 5 if x is a multiple of 5.
    Decrement x by 1.
    Increment x by 1.

Return the minimum number of operations required to make x and y equal.

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

- 1 <= x, y <= 10^4


### Solution:

1. Use BFS approach
   - Use a queue
   - Keep track of seen values of x 

2. Use Dynamic Programming with recursion
   - Try to increase to a number dividable by 11
   - Try to decrease to a number dividable by 11
   - Try to increase to a number dividable by 5
   - Try to decrease to a number dividable by 11
   - Take the min
