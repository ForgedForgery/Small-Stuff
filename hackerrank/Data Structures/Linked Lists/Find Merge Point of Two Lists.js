/*
    Find merge point of two linked lists
    Note that the head may be 'null' for the empty list.
    Node is defined as
    var Node = function(data) {
        this.data = data;
        this.next = null;
    }
*/

// This is a "method-only" submission.
// You only need to complete this method.

function findMergeNode(headA, headB) {
    let pA = headA;
    let pB = headB;
    while(pA != pB) {
        // both pointers need same amount to find the merge point
        // once connected with the other list
        // since last part has same length
        pA = pA.next != null ? pA.next : headB;
        pB = pB.next != null ? pB.next : headA;
    }
    return pA.data;
}
