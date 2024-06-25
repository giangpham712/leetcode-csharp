# [560. Subarray Sum Equals K](https://leetcode.com/problems/subarray-sum-equals-k)

Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.

A subarray is a contiguous non-empty sequence of elements within an array.

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

- For each index i of array A we store cumulative sums sum(A[:i]) in a hash table

- We know that sum(A[:j]) = sum(A[:i]) + sum(A[i:j]) for some j > i

- Let's assume that there is some contiguous subarray A[i:j] which sum is equal to k: sum(A[i:j]) == k

- If sum(A[i:j]) == k, then we can rewrite previous equality in the following ways:
    - sum(A[:j]) = sum(A[:i]) + k 
    - sum(A[:j]) - k = sum(A[:i])

- Therefore, if we already saw value of sum(A[:j]) - k as a cumulative sum sum(A[:i]) for some previous i (which we can check by looking at the hash table), then it means that sum of the subarrary A[i:j] is equal to k and we can increment the counter.
