# [105. Construct Binary Tree from Preorder and Inorder Traversal](https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal)

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

#### Use recursion

- The first value in the `preorder` list is the root
- In the inorder list
  - values that are on the left side of the root value belongs to the left subtree 
  - values that are on the right side of the root value belongs to the right subtree
- 