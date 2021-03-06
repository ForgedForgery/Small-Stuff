    /*
      Insert Node at the end of a linked list
      head pointer input could be NULL as well for empty list
      Node is defined as
      class Node {
         int Data;
         Node Next;
      }
    */
    // This is a "method-only" submission.
    // You only need to complete this method.

    public static Node Insert(Node head, int x)
    {
        Node tail = head;
        while(tail.Next != null) {
            tail = tail.Next;
        }
        tail.Next = new Node();
        tail = tail.Next;
        tail.Data = x;
        tail.Next = null;
        return head;
    }
