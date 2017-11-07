using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    
    static long[] getMinAndMaxSum(long[] a) {
        long minSum = Int64.MaxValue;
        long maxSum = 0;
        
        foreach(long i in a) {
            long sum = 0;
            
            foreach(long j in a) {
                sum += i != j ? j : 0;
            }
            
            maxSum = sum > maxSum ? sum : maxSum;
            minSum = sum < minSum ? sum : minSum;
        }
        
        return new long[] {minSum, maxSum};
    }

    static void Main(String[] args) {
        string[] arr_temp = Console.ReadLine().Split(' ');
        long[] arr = Array.ConvertAll(arr_temp,Int64.Parse);
        
        long minSum = arr.Sum() - arr.Max();
        long maxSum = arr.Sum() - arr.Min();
        Console.WriteLine("{0} {1}", minSum, maxSum);
    }
}
