/*
    Remove all duplicate elements from a sorted Linked List
    Node is defined as
    var Node = function(data) {
        this.data = data;
        this.next = null;
    }
*/

// This is a "method-only" submission.
// You only need to complete this method.

function removeDuplicates(head) {
    let newH = head != null ? head : null;
    let p = newH;
    
    while(p != null && p.next != null) {
        if(p.data == p.next.data) {
            let p2 = p.next;
            while(p2 != null && p.data == p2.data) {
                p2 = p2.next;
            }
            p.next = p2;
        }
        p = p.next;
    }
    return newH;
}
