# [859. Buddy Strings](https://leetcode.com/problems/buddy-strings)

Given two strings s and goal, return true if you can swap two letters in s so the result is equal to goal, otherwise, return false.

Swapping letters is defined as taking two indices i and j (0-indexed) such that i != j and swapping the characters at s[i] and s[j].

- For example, swapping at indices 0 and 2 in "abcd" results in "cbad".


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
- Iterate both strings and compare the character at each index
- Use a boolean variable `swapped` to track whether a swap has been identified
- When the first mismatching pair of letters is encountered, track the index as the candidate swap index.
- When the second mismatching pair of letters is encountered, 
  - Return `false` if they don't match with the first pair
  - Set `swapped` to `true`
- Continue the iteration
- If another mismatching pair of letters is encountered, return `false`
- At the end, 
  - if the swap index has been set, 
    - return `false` if `swapped` is `false`
    - return `true` if `swapped` is `true`
  - if the swap index has not been set which means the two strings are identical
    - Return `true` if there exists at least a letter with more than one occurence
    - Else, return `false`