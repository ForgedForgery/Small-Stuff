    /*
      Insert Node at a given position in a linked list
      head can be NULL
      First element in the linked list is at position 0
      Node is defined as
      class Node {
         int Data;
         Node Next;
      }
    */

    // This is a "method-only" submission.
    // You only need to complete this method.

    public static Node InsertNth(Node head, int data, int position)
    {
        Node temp = head;
        for(; position>1; position--) {
            temp = temp.Next;
        }
        Node n = new Node();
        n.Data = data;
        if(position == 0) {
            n.Next = temp;
            return n;
        } else {
            n.Next = temp.Next;
            temp.Next = n;
            return head;
        }
    }
