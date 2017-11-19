/*  
   class Node
      public  int frequency; // the frequency of this tree
       public  char data;
       public  Node left, right;
    
*/ 

void decode(String S ,Node root) {
    String message = "";
    Node p = root;
    for(char i : S.toCharArray()) {
        if(i == "0".charAt(0))
            p = p.left;
        if(i == "1".charAt(0))
            p = p.right;
        
        if(p.data != '\0') {
            message += p.data;
            p = root;
        }
    }
    System.out.print(message);
}

