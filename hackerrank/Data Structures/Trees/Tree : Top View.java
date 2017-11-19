   /* 
    
    class Node 
       int data;
       Node left;
       Node right;
   */
   void topView(Node root) {
      leftView(root);
      rightView(root.right);
    }
    void leftView(Node root) {
        if(root == null)
            return;
        leftView(root.left);
        System.out.print(root.data + " ");
    }
    void rightView(Node root) {
        if(root == null)
            return;
        System.out.print(root.data + " ");
        rightView(root.right);
    }
