# [678. Valid Parenthesis String](https://leetcode.com/problems/valid-parenthesis-string)

Given a string s containing only three types of characters: '(', ')' and '*', return true if s is valid.

The following rules define a valid string:

- Any left parenthesis '(' must have a corresponding right parenthesis ')'.
- Any right parenthesis ')' must have a corresponding left parenthesis '('.
- Left parenthesis '(' must go before the corresponding right parenthesis ')'.
- '*' could be treated as a single right parenthesis ')' or a single left parenthesis '(' or an empty string "".


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


#### Follow up:

- 

### Solution:

- Initialize leftMin and leftMax to 0.
- Iterate through each character in the string s.
- If the character is '(', increment both leftMin and leftMax by 1.
- If the character is ')', decrement both leftMin and leftMax by 1.
- If the character is '*', decrement leftMin by 1 and increment leftMax by 1.
- If leftMax becomes negative at any point, return False since it means there are more closing parentheses than opening ones.
- If leftMin becomes negative, reset it to 0 since we can't have negative open parentheses count.
- After iterating through the string, check if leftMin is 0. If it is, return True; otherwise, return False.
