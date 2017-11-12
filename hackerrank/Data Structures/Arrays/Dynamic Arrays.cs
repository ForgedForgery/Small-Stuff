using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string[] a1_temp = Console.ReadLine().Split(' ');
        int[] a1 = Array.ConvertAll(a1_temp, Int32.Parse);
        int n = a1[0], q = a1[1];
        int[][] queries = new int[q][];
        for(int i = 0; i < q; i++) {
            string[] a2_temp = Console.ReadLine().Split(' ');
            queries[i] = Array.ConvertAll(a2_temp, Int32.Parse);
        }    
        List<int>[] seqList = new List<int>[n];
        for(int i = 0; i < n; i++) {
            seqList[i] = new List<int>();
        }
        int lastAnswer = 0;
        
        foreach(int[] query in queries) {
            int type = query[0], x = query[1], y = query[2];
            int seq = (x ^ lastAnswer) % n;
            if(type == 1) {
                seqList[seq].Add(y);
            } else if(type == 2) {
                lastAnswer = seqList[seq][y % seqList[seq].Count];
                Console.WriteLine(lastAnswer);
            }
        }
    }
}
