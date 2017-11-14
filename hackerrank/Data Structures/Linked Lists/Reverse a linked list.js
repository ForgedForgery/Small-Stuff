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

//recursive
function reverseLinkedList(head) {
    // recursive until last node is met
    if(head == null || head.next == null)
        return head;
    var newHead = reverseLinkedList(head.next);
    
    // reverse the pointer
    head.next.next = head;
    
    // head (now the tail) needs to point to null
    head.next = null;
    
    return newHead;
}

// non recursive
// first answer
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
