using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        int plusCount = 0;
        int minusCount = 0;
        int zeroCount = 0;
        foreach(int i in arr) {
            switch (System.Math.Sign(i)) {
                case 1:
                    plusCount++;
                    break;
                case -1:
                    minusCount++;
                    break;
                case 0:
                    zeroCount++;
                    break;
            }
        }
        Console.WriteLine((float) plusCount/n);
        Console.WriteLine((float) minusCount/n);
        Console.WriteLine((float) zeroCount/n);
    }
}
