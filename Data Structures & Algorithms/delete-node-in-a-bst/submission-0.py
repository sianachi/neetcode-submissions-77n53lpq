class Solution:
    def deleteNode(self, root: Optional[TreeNode], key: int) -> Optional[TreeNode]:
        if not root:
            return None
        if root.val == key:
            if not root.left: return root.right
            if not root.right: return root.left
            temp = root.right
            while temp.left: temp = temp.left
            root.val = temp.val
            root.right = self.deleteNode(root.right, temp.val)
            return root
        if root.val > key:
            root.left = self.deleteNode(root.left, key)
        else:
            root.right = self.deleteNode(root.right, key)
        return root