# CollectionInsertionDeletionTimes
This repo contains basic LinkedList, List, and Array all populated with random integers from 0 - 1000. All lists populated with 1 million elements.

Insertion times on avg: (10 runs and used method `AddLast()` for LinkedList and `Add` for list. Using a different function will result in different times)
LinkedList: 98 ms
List: 29 ms
Array: 16 ms

Deletion Times for LinkedList and List:
LinkedList: 101 ms
List: 31 ms

This show show for speed an Array is faster for insertions (in this case, not always true) and for a List deletion a List wins. This is only for speed not accounting how these collections are stored in data. There are certain scenarios where one is better than the other for example inserting into the middle of a collection and LinkedList is more ideal compared to an array since you just have to change what the previous element is pointing to whereas an array all elements have to be shifted down.
