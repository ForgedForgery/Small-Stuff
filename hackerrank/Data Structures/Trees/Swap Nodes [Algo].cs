using System;
using System.Collections.Generic;
using System.IO;

class Node {
    public int data;
    public Node left;
    public Node right;
    
    public Node() {
        this.left = null;
        this.right = null;
    }
}

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] ab = new int[n][];
        for(int i = 0; i < n; i++) {
            ab[i] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        }
        int t = Convert.ToInt32(Console.ReadLine());
        int[] k = new int[t];
        for(int i = 0; i < t; i++) {
            k[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        Node root = new Node();
        root.data = 1;
        createTheTree(root, ab);
        
        for(int i = 0; i < t; i++) {
            swapNodesEveryKHeight(root, k[i]);
            inOrder(root);
            Console.WriteLine("");
        }
    }
    
    static void inOrder(Node root) {
        if(root == null)
            return;
        inOrder(root.left);
        Console.Write(root.data + " ");
        inOrder(root.right);
    }
    
    static void swapNodesEveryKHeight(Node root, int k) {
        for(int i = k; i < heightOfTree(root)+1; i += k) {
            swapNodesAtK(root, i);
        }
    }
    
    static void swapNodesAtK(Node root, int k) {
        if(root == null)
            return;
        if(k == 1) {
            swapNodes(root);
            return;
        }
        swapNodesAtK(root.left, k-1);
        swapNodesAtK(root.right, k-1);
    }
    
    static void swapNodes(Node root) {
        Node temp = root.left;
        root.left = root.right;
        root.right = temp;
    }
    
    static int heightOfTree(Node root) {
        if(root == null)
            return -1;
        int leftPath = 1 + heightOfTree(root.left);
        int rightPath = 1 + heightOfTree(root.right);
        
        return leftPath>rightPath?leftPath:rightPath;
    }
    
    static void createTheTree(Node root, int[][] vals) {
        // n is amount of nodes in next level
        int n = vals[0][0] != -1 || vals[0][1] != -1 ? 1 : 0;
        // c is amount of nodes in current level
        int c = 0;
        int row = 0;
        // h is height of current level
        int h = 1;
        
        while(row < vals.Length) {
            List<Node> p = new List<Node>();
            putRowOfNodesByHeightIntoP(root, p, h);
            c = n;
            n = 0;
            h++;
            for(int i = 0; i < c; i++) {
                if(vals[row][0] != -1) {
                    p[i].left = new Node();
                    p[i].left.data = vals[row][0];
                    n++;
                }
                if(vals[row][1] != -1) {
                    p[i].right = new Node();
                    p[i].right.data = vals[row][1];
                    n++;
                }
                row++;
            }
        }
    }
    
    static void putRowOfNodesByHeightIntoP(Node root, List<Node> p, int h) {
        if(root == null)
            return;
        if(h == 1) {
            p.Add(root);
            return;
        }
        putRowOfNodesByHeightIntoP(root.left, p, h - 1);
        putRowOfNodesByHeightIntoP(root.right, p, h - 1);
    }
}
