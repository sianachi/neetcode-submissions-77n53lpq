"""
# Definition for a Node.
class Node:
    def __init__(self, val = 0, neighbors = None):
        self.val = val
        self.neighbors = neighbors if neighbors is not None else []
"""

class Solution:
    def cloneGraph(self, node: Optional['Node']) -> Optional['Node']:
        if not node: 
            return None
        
        oldToNewDict = {}
        oldToNewDict[node] = Node(node.val)

        processing_queue = deque([node])

        while processing_queue:
          processing_node = processing_queue.popleft()

          for neighbor in processing_node.neighbors:
            if neighbor not in oldToNewDict:
              oldToNewDict[neighbor] = Node(neighbor.val)
              processing_queue.append(neighbor)
            oldToNewDict[processing_node].neighbors.append(oldToNewDict[neighbor])

        return oldToNewDict[node]