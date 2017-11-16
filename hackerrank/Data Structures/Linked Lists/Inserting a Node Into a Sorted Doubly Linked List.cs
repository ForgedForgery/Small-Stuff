/*
    Insert Node in a doubly sorted linked list
    After each insertion, the list should be sorted
    Node is defined as
    var Node = function(data) {
        this.data = data;
        this.next = null;
        this.prev = null;
    }
*/

// This is a "method-only" submission.
// You only need to complete this method.

function sortedInsert(head, data) {
    let newNode = new Node();
    newNode.data = data;
    let p = head;
    
    if(p == null)
        return newNode;

    while(p.next != null) {
        if(p.next.data < newNode.data) {
            p = p.next;
        } else if(p.next.data > newNode.data) {
            newNode.next = p.next;
            p.next.prev = newNode;
            p.next = newNode;
            newNode.prev = p;
            return head;
        }
    }
    
    if(p.data < newNode.data) {
        p.next = newNode;
        newNode.prev = p;
        return head;
    } else if(newNode.data < p.data) {
        p.prev = newNode;
        newNode.next = p;
        return newNode;
    }
}
