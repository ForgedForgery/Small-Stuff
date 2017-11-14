    /*
      Print linked list from the end to the begin
      head can be NULL
      Node is defined as
      class Node {
         int Data;
         Node Next;
      }
    */

    // This is a "method-only" submission.
    // You only need to complete this method.

    public static void ReversePrint(Node head)
    {
        if(head != null) {
            if(head.Next != null)
                ReversePrint(head.Next);
            Console.WriteLine(head.Data);
        }
    }
