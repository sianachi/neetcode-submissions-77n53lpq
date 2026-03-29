class Solution:
    def insertIntoBST(self, root: Optional[TreeNode], val: int) -> Optional[TreeNode]:
        if not root:
            return TreeNode(val)
        cur = root

        while True:
            if val > cur.val and cur.right is not None:
                cur = cur.right
            elif val > cur.val and cur.right is None:
                cur.right = TreeNode(val)
                break
            elif val < cur.val and cur.left is not None:
                cur = cur.left
            elif val < cur.val and cur.left is None:
                cur.left = TreeNode(val)
                break
        return root