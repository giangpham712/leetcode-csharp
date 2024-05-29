# [Example]()

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
- Iterate the list starting from the smallest possible value of `j`
- At each index `j`, add value of number at index `i` to a sorted list
- For each number at `j`, use binary search to find the number in the sorted list with smallest difference 