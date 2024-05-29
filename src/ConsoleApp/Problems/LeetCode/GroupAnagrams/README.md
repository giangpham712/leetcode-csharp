# [49. Group Anagrams](https://leetcode.com/problems/group-anagrams)

Given an array of strings strs, group the anagrams together. You can return the answer in any order.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

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

- Implement a hashing function to hash a string so that strings that have the same letters can be grouped together
- The hashing function 
  - use an array of size 26 to track the frequencies of the letter
  - iterate the array to generate a string 