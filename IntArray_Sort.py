exampleArr = [1, 9, 4, 2, 19, 12]

def sortIntArray(unsortedArray):
    flags = True
    while flags:
        flags = False
        for i in range(len(unsortedArray) - 1):
            if unsortedArray[i] > unsortedArray[i + 1]:
                unsortedArray[i], unsortedArray[i + 1] = unsortedArray[i + 1], unsortedArray[i]
                flags = True
    return unsortedArray

def Main():
    print("Unsorted array:")
    print(", ".join(map(str, exampleArr)))
    sortedArray = sortIntArray(exampleArr[:])
    print("\nSorted array:")
    print(", ".join(map(str, sortedArray)))

Main()