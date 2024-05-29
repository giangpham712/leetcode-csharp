# [1386. Cinema Seat Allocation](https://leetcode.com/problems/cinema-seat-allocation)

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


### Solution:

- Iterate the list of reserved seats and use a dictionary of integer to arrays to track the availability of seats on each row
  - The seats for each row are tracked using an array of 10 booleans 
- Iterate the dictionary where the keys are row numbers and values are arrays of seats
  - Count the number of available four adjacent seats that follow the rule