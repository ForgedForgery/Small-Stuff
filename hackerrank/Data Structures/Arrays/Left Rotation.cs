using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] leftRotation(int[] a, int d) {
        // Complete this function
        int[] result = new int[a.Length];
        for(int i = 0; i < a.Length; i++) {
            result[i] = a[(i + d) % a.Length];
        }
        return result;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int d = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        int[] result = leftRotation(a, d);
        Console.WriteLine(String.Join(" ", result));
    }
}
