/*
    Reverse a linked list and return the head
    The input list will have at least one element
    Node is defined as
    var Node = function(data) {
        this.data = data;
        this.next = null;
    }
*/

// This is a "method-only" submission.
// You only need to complete this method.

function reverseLinkedList(head) {

    let h1 = head;
    let h2 = head;
    if(h1 != null) {
        h1 = h1.next;
        h2.next = null; 
    }
    
    while(h1 != null) {
        temp = h1.next;
        h1.next = h2;
        h2 = h1;
        h1 = temp;
        
    }
    return h2;
}
