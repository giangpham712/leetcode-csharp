# [72. Edit Distance](https://leetcode.com/problems/edit-distance)

Given two strings word1 and word2, return the minimum number of operations required to convert word1 to word2.

You have the following three operations permitted on a word:

- Insert a character
- Delete a character
- Replace a character


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


Follow up: 

### Solution:

1. Use BFS. Skip matching letters from left to right and try one of the followings for a mismatching pair:
   - Replace the first letter of sequence with the first letter of word 
2. Use Dynamic Programming