/*
    Merge two sorted lists A and B as one Linked List and return the head of merged list
    Node is defined as
    var Node = function(data) {
        this.data = data;
        this.next = null;
    }
*/

// This is a "method-only" submission.
// You only need to complete this method.

function mergeLinkedLists( headA, headB) {
    let newH;
    if(headA != null && headB != null) {
        if(headA.data < headB.data) {
            newH = headA;
            headA = headA.next;
        } else if(headB.data < headA.data) {
            newH = headB;
            headB = headB.next;
        }
    } else if(headA != null && headB == null) {
        newH = headA;
        headA = headA.next;
    } else if(headB != null && headA == null) {
        newH = headB;
        headB = headB.next;
    } else {
        newH = null;
    }
    let p = newH;
    
    while(p != null) {
        if(headA != null && headB != null) {
            if(headA.data < headB.data) {
                p.next = headA;
                headA = headA.next;
               
            } else if (headB.data < headA.data) {
                p.next = headB;
                headB = headB.next;
                
            }
        } else if(headA != null) {
            p.next = headA;
            headA = headA.next;
            
        } else if(headB != null) {
            p.next = headB;
            headB = headB.next;
        } 
        p = p.next;
    }
   
    return newH;
}
