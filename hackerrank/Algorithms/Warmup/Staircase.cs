using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    
    static void buildStaircase(int spaceN) {
        int symbolN = 0;
        while(spaceN > 0) {
            spaceN--;
            buildStaircaseRow(spaceN, symbolN);
            symbolN++;
        }
    }
    
    static void buildStaircaseRow(int i, int j) {
        while (i > 0) {
            Console.Write(" ");
            i--;
        }
        while (j > 0) {
            Console.Write("#");
            j--;
        }
        Console.WriteLine("#");
    }
      

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        buildStaircase(n);
    }
}
