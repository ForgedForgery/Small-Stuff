   /* 
    
    class Node 
       int data;
       Node left;
       Node right;
   */
   void levelOrder(Node root) {
       int height = height(root);
       for(int i = 0; i <= height; i++) {
           printOneLevel(i, root);
       }
    }

    void printOneLevel(int level, Node root) {
        if(root == null)
            return;
        if(level == 0) {
            System.out.print(root.data + " ");
            return;
        }
        printOneLevel(level-1, root.left);
        printOneLevel(level-1, root.right);
    }

	static int height(Node root) {
      	// Write your code here.
        if(root == null)
            return -1;
        int leftPath = 1 + height(root.left);
        int rightPath = 1 + height(root.right);
        
        return leftPath>rightPath?leftPath:rightPath;
    }
