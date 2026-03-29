class DynamicArray:
    
    def __init__(self, capacity: int):
        self.__buffer = [0] * capacity
        self.__size = 0

    def get(self, i: int) -> int:
        return self.__buffer[i]

    def set(self, i: int, n: int) -> None:
        if i < self.__size:
            self.__buffer[i] = n

    def pushback(self, n: int) -> None:
        if self.__size < len(self.__buffer):
            self.__buffer[self.__size] = n
            self.__size += 1
        else:
            #Resize the buffer by creating double the init array and stuff
            self.resize()

            # Add the item like normal
            self.__buffer[self.__size] = n
            self.__size += 1


    def popback(self) -> int:
        self.__size -= 1
        output = self.__buffer[self.__size]

        self.__buffer[self.__size] = 0

        return output

    def resize(self) -> None:
        new_buffer = [0] * len(self.__buffer) * 2
        
        for i in range(len(self.__buffer)):
            new_buffer[i] = self.__buffer[i]

        self.__buffer = new_buffer


    def getSize(self) -> int:
        return self.__size
    
    def getCapacity(self) -> int:
        return len(self.__buffer)