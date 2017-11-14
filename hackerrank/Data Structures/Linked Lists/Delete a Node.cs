    /*
      Delete Node at a given position in a linked list
      head pointer input could be NULL as well for empty list
      Node is defined as
      class Node {
         int Data;
         Node Next;
      }
    */

    // This is a "method-only" submission.
    // You only need to complete this method.

    public static Node Delete(Node head, int position)
    {
        if(position == 0) {
            head = head.Next;
        } else {
            Node temp = head;
            for(;position > 1; position--) {
                temp = temp.Next;
            }
            Node n = temp.Next;
            temp.Next = n.Next;
            n.Next = null;
        }
        return head;
    }
