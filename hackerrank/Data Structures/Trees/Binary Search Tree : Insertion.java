 /* Node is defined as :
 class Node 
    int data;
    Node left;
    Node right;
    
    */

static Node Insert(Node root,int value) {
    Node p = root;
    Node newNode = new Node();
    newNode.data = value;
    
    if(p == null)
        return newNode;
    
    while(p != null) {
        if(p.data > value) {
            if(p.left == null) {
                p.left = newNode;
                return root;
            } else {
                p = p.left;
            }
        }
        if(p.data < value) {
            if(p.right == null) {
                p.right = newNode;
                return root;
            } else {
                p = p.right;
            }
        }
    }
    
    return root;
}


