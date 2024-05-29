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

### Solution:

#### Use iteration

- Use a variable to store the previous node to set for the `next` pointer of the current node

#### Use recursion

- The recursion function
  - takes a node as the input
  - if there `next` node of the current node is not null, set its `next` pointer to the current node
  - return the tail that is the last node in the chain that doesn't have a `next` node