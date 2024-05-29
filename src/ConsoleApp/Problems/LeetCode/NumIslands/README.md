# [200. Number of Islands](https://leetcode.com/problems/number-of-islands)

Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.

An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

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

- Iterate the matrix
- Use recursion to expand from one cell to its adjacent cells
  - When we start at a new node, use its coordinate as the key for the island and for the expansion
  - Update the value of a cell to `0` to mark it as visited