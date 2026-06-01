"""
# Definition for a Node.
class Node:
    def __init__(self, val = 0, neighbors = None):
        self.val = val
        self.neighbors = neighbors if neighbors is not None else []
"""

class Solution:
    def cloneGraph(self, node: Optional['Node'], visited = {}) -> Optional['Node']:
        if not node: return None
        if node in visited: return visited[node]

        node_copy = Node(node.val)
        visited[node] = node_copy

        # Copy all the neigbours recursively
        for n in node.neighbors:
            node_copy.neighbors.append(self.cloneGraph(n, visited))
        
        return node_copy

        