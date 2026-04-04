# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def kthSmallest(self, root: Optional[TreeNode], k: int) -> int:
        # dfs till we have gotten at least k elements
        dfsCache = []
        self.dfsInOrderTill(root, k, dfsCache)
        if len(dfsCache) >= k:
            return dfsCache[k-1]
        else:
            return -1

    def dfsInOrderTill(self, root: Optional[TreeNode], k: int, memoCache : List[int]):
        if not root:
            return
        
        if len(memoCache) >= k:
            return
        
        self.dfsInOrderTill(root.left, k, memoCache)
        
        if len(memoCache) < k:
            memoCache.append(root.val)

        self.dfsInOrderTill(root.right, k, memoCache)
