/*
    Detect a cycle in a Linked List.
    Note that the head may be 'null' if the list is empty.
    Node is defined as
    var Node = function(data) {
        this.data = data;
        this.next = null;
    }
*/

// This is a "method-only" submission.
// You only need to complete this method.

function hasCycle(head) {
    let tortoise = head;
    let hare = head;
    
    while(hare != null && hare.next != null) {
        tortoise = tortoise.next;
        hare = hare.next.next;
        
        if(hare == tortoise)
            return true;
    }
    return false;
}
