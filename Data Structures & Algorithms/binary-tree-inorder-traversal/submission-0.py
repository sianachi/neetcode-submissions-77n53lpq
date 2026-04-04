# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def inorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        return self.bstToList(root, [])

    def bstToList(self, root: Optional[TreeNode], memoCache) -> List[int]:
        if not root:
            return memoCache

        self.bstToList(root.left, memoCache)

        memoCache.append(root.val)

        self.bstToList(root.right, memoCache)

        return memoCache

        