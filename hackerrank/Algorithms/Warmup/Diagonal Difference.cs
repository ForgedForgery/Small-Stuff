using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    
    static int diagonalDifference(int n, int[][] a) {
        int sum1 = 0;
        int sum2 = 0;
        int n2 = 0;
        while (n > 0) {
            n--;
            sum1 += a[n][n];
            sum2 += a[n][n2];
            n2++;
        }
        return System.Math.Abs(sum1 - sum2);
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }
        
        int result = diagonalDifference(n, a);
        Console.WriteLine(result);
    }
}
