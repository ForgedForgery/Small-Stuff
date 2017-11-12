    /*
      Print elements of a linked list on console
      head pointer input could be NULL as well for empty list
      Node is defined as
      class Node {
         int Data;
         Node Next;
      }
    */

    // This is a "method-only" submission.
    // You only need to complete this method.

    public static void Print(Node head)
    {
        while(head != null) {
            Console.WriteLine(head.Data);
            head = head.Next;
        }
    }
