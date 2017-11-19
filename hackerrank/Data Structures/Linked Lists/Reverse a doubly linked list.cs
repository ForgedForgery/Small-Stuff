/*
    Reverse a doubly linked list, input list may also be empty
    Node is defined as
    var Node = function(data) {
        this.data = data;
        this.next = null;
        this.prev = null;
    }
*/

// This is a "method-only" submission.
// You only need to complete this method.

function reverse(head) {
    let p = head;
    
    while(p != null) {
        head = p.next;
        p.next = p.prev;
        p.prev = head;
        head = p;
        p = p.prev;
    }
    
    return head;
}

