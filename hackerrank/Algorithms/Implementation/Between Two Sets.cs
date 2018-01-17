using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int getTotalX(int[] a, int[] b) {
        return countXBetween(a, b);
    }
    
    static int countXBetween(int[] divides, int[] getsDivided) {
        int xmax = getsDivided.Min();
        int xmin = divides.Max();
        
        List<int> possibleXAmount = new List<int>();
        for(int x = xmax; x >= xmin; x -= xmin) {
            int counter = 0;
            foreach(int a in divides) {
                if(x % a == 0)
                    counter++;
            }
            foreach(int b in getsDivided) {
                if(b % x == 0)
                    counter++;
            }
            if(counter == divides.Length + getsDivided.Length)
                possibleXAmount.Add(x);
        }
        return possibleXAmount.Count;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        string[] b_temp = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(b_temp,Int32.Parse);
        int total = getTotalX(a, b);
        Console.WriteLine(total);
    }
}
