	/*
    class Node 
    	int data;
    	Node left;
    	Node right;
	*/
	static int height(Node root) {
      	// Write your code here.
        if(root == null)
            return -1;
        int leftPath = 1 + height(root.left);
        int rightPath = 1 + height(root.right);
        
        return leftPath>rightPath?leftPath:rightPath;
    }
