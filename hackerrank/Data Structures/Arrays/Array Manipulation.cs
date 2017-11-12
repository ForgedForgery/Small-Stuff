using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    
    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        long[] list = new long[n+1];
        for(int i = 0; i < n+1; i++) {
            list[i] = 0;
        }
        for(int a0 = 0; a0 < m; a0++){
            string[] tokens_a = Console.ReadLine().Split(' ');
            long a = Convert.ToInt64(tokens_a[0]);
            long b = Convert.ToInt64(tokens_a[1]);
            long k = Convert.ToInt64(tokens_a[2]);

            list[a] += k;
            if(b + 1 <= n)
                list[b + 1] -= k;
        }
        long temp_max = 0, max = 0;
        for(int i = 1; i < n+1; i++) {
            temp_max += list[i];
            if(temp_max > max)
                max = temp_max;
        }
        Console.WriteLine(max);
    }
}
