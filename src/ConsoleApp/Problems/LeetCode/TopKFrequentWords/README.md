# [692. Top K Frequent Words](https://leetcode.com/problems/top-k-frequent-words)

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

- Iterate the list to count the frequencies of words
- Use bucket sorting
  - initialize an array of priority queues, the size of the array is the max frequency
  - assign words to the buckets, they will be sorted lexicographically by the priority queue
- Iterate the buckets and pick the top `k`