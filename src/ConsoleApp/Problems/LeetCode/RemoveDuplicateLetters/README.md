# [316. Remove Duplicate Letters](https://leetcode.com/problems/remove-duplicate-letters)

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

- Use a map to track the frequencies of all letters
- Use a map to track whether a letter has been added to the result string
- Iterate the string, at each letter
  - Decrease its frequency in the map
  - If the letter has not been used
    - Compare it with the previous letter, 
      - if there is no more of that letter (by checking the frequency map), keep it
      - if there is more of that letter and that letter is lexicographical larger than the current letter, remove it from the result string and mark it as not added
    - Add the current letter to the result string and mark it as added in the used map
 