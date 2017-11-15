/*
    Get Nth element data from the end in a Linked List
    Number of elements in the list will always be greater than N.
    Node is defined as
    var Node = function(data) {
        this.data = data;
        this.next = null;
    }
*/

// This is a "method-only" submission.
// You only need to complete this method.

function getNodeValue( head, position) {
    let p1 = head;
    let p2 = head;
    while(p1 != null) {
        p1 = p1.next;
        if(position < 0) {
            p2 = p2.next;
        } else {
            position--;
        }
    }
    return p2.data;
}
