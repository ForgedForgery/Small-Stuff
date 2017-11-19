using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string kangaroo(int x1, int v1, int x2, int v2) {
        // Complete this function
        if(x1<x2&&v1>v2) {
            int temp = x1;
            x1 = x2;
            x2 = temp;
            temp = v1;
            v1 = v2;
            v2 = temp;
        }
            
        while(x1>=x2&&v1<v2) {
            if(x1 == x2)
                return "YES";
            x1 += v1;
            x2 += v2;
        }
        return "NO";
    }
    
    static string kangarooWithMath(int x1, int v1, int x2, int v2) {
        // y*v1 + x1 = y*v2 + x2
        // x1 - x2 = y*(v2 - v1)
        // (x1 - x2) / (v2 - v1) = y
        // y is amount of steps for 1 and 2 to meet
        // y can't be negative
        // y has to be a Natural number
        float y = (x1 - x2) / (v2 - v1);
        y = y % 1;
        if(y == 0f)
            return "YES";
        return "NO";
        
    }

    static void Main(String[] args) {
        string[] tokens_x1 = Console.ReadLine().Split(' ');
        int x1 = Convert.ToInt32(tokens_x1[0]);
        int v1 = Convert.ToInt32(tokens_x1[1]);
        int x2 = Convert.ToInt32(tokens_x1[2]);
        int v2 = Convert.ToInt32(tokens_x1[3]);
        string result = kangaroo(x1, v1, x2, v2);
        Console.WriteLine(result);
    }
}
