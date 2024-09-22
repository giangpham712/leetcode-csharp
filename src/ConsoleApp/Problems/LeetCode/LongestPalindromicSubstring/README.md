# [5. Longest Palindromic Substring](https://leetcode.com/problems/longest-palindromic-substring)

#### Example 1:
```
Input: s = "babad"
Output: "bab"
Explanation: "aba" is also a valid answer.
``` 

#### Example 2:
```
Input: s = "cbbd"
Output: "bb"
``` 

#### Constraints:

- 1 <= s.length <= 1000
- s consist of only digits and English letters.


### Solution:
- Use dynamic programming and two pointers
  - A substring s[i j] is palindromic if s[i] == s[j] and s[i + 1 j - 1] is also palindromic