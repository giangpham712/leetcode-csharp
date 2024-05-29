# [1405. Longest Happy String](https://leetcode.com/problems/longest-happy-string)

A string s is called happy if it satisfies the following conditions:

- s only contains the letters 'a', 'b', and 'c'.
- s does not contain any of "aaa", "bbb", or "ccc" as a substring.
- s contains at most a occurrences of the letter 'a'.
- s contains at most b occurrences of the letter 'b'.
- s contains at most c occurrences of the letter 'c'.

Given three integers a, b, and c, return the longest possible happy string. If there are multiple longest happy strings, return any of them. If there is no such string, return the empty string "".

A substring is a contiguous sequence of characters within a string.


#### Example 1:
```
Input: a = 1, b = 1, c = 7
Output: "ccaccbcc"
Explanation: "ccbccacc" would also be a correct answer.
``` 

#### Example 2:
```
Input: a = 7, b = 1, c = 0
Output: "aabaa"
Explanation: It is the only correct answer in this case.
``` 

#### Example 3:
```
Input: 
Output: 
Explanation:
```

#### Constraints:

- 0 <= a, b, c <= 100
- a + b + c > 0



### Solution:

- Use Greedy approach with a priority queue
- Use a priority queue to rank the letters by highest occurence
- We dequeue the letter with the highest occurence
- Add it to the result string if that doesn't violate the rule then decrease its occurence and re-enqueue (if not 0)
  If it violates the rule, pick the next one to add and decrease its occurence, then re-enqueue both (if not 0)