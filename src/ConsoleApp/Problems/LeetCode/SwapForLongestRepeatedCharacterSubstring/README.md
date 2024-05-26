# [1156. Swap For Longest Repeated Character Substring](https://leetcode.com/problems/swap-for-longest-repeated-character-substring)

You are given a string text. You can swap two of the characters in the text.

Return the length of the longest substring with repeated characters.

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

- Use Sliding Window technique
- Keep track of frequencies of letters
- From each position, count the maximum length of repeated character with only gap allowed