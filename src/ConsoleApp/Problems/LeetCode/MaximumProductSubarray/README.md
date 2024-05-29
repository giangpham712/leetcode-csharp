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


#### Follow up:

- 

### Solution:

- Set three variables, `min` and `max` to track the max and min products observed, and `totalMax`
- Iterate the array
  - at each index,
    - if the number is negative
      - update `max` to the larger value between the product of the current `min` and the current number, and the current number
      - update `min` to the smaller value between the product of the current `max` and the current number, and the current number
    - if the number is not negative
      - update `max` to the larger value between the product of the current `max` and the current number, and the current number
      - update `min` to the smaller value between the product of the current `min` and the current number, and the current number