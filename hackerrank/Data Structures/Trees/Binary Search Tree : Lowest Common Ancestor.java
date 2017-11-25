/* Node is defined as :
 class Node 
    int data;
    Node left;
    Node right;
    
    */

static Node Mylca(Node root,int v1,int v2) {
    if(root == null)
        return root;
    Node p1 = root;
    Node p2 = root;
    
    p1 = root.data > v1 ? p1.left : root.data < v1 ? p1.right : p1;
    p2 = root.data > v2 ? p2.left : root.data < v2 ? p2.right : p2;
    
    if(p1!=p2)
        System.out.print(root.data);
    return p1==p2 ? lca(p1, v1, v2) : root;
}

// simplified
static Node lca(Node root, int v1, int v2) {
    if(root.data > v1 && root.data > v2)
        return lca(root.left, v1, v2);
    if(root.data < v1 && root.data < v2)
        return lca(root.right, v1, v2);
    
    return root;
}




