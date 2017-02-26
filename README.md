# O(1) Max and Int

The other day I was presented with a whiteboard interview scenario where I was presented with solving the following problem.

Create a class for storing integers with the following properties: 

  - Push: push an integer in O(1) 
  - Remove: remove an integer (first in last out) in O(1) 
  - Get Max: return the value of the largest integer stored in O(1)

### First Pass

I won't submit my first pass code here, but there were several problems with it.

1. My containers I chose initially were *TWO* List<int>'s which prove to be a mistake.
2. List<>.RemoveAt is O(N) which I used for the Remove function.
3. List<>.Add is O(N) if List.Count == List.Capacity. Not quite as big of a problem as #2 but still not quite O(1).
4. I never initialized my lists. I chalk this up to being rushed to get my ideas onto paper.
5. No null checks or exception handling. Same excuse as #4.
6. No unit tests. Typically I would try to include unit tests in something like this but time constraints for the interview made me skip over them.

### Fixes

1. List<int> at first glance (coming from a C++ background in college) isn't a problem but it really is! List<> in C# acts more like STL::vector instead of STL::list and it's easy to make that mistake when using it on a daily basis as your primary resizable collection. Also, I should have used a Node struct or class to hold the current int and max for quick retrieval. This leads me to change the primary container to LinkedList<Node>.
2. LinkedList<>.RemoveFirst and RemoveLast are O(1) operations and if business needs change to require change from a stack to a queue, it would be trivial to change and maintain O(1) complexity.
3. LinkedList<>.AddFirst and AddLast again are O(1) operations and would be trivial to change if needed.
4. Initialize the LinkedList and try not to rush into the fun parts of the code next time. :)
5. Same as 4.
6. Added unit tests.

### Additional Enhancements

LinkedList<> isn't the absolute best container in the world for the problem as you don't really need a doubly linked list and the extra memory it uses but it will serve it's function just fine. As pointed out above, it does easily allow you to switch from a stack to a queue if business requirements change which happens more often than not. X-D If the whiteboard were a bit longer I would have gotten to this point eventually and solved my unknown (at the time) problems related to the List<int> complexity.
