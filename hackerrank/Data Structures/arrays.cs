using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        int[] solution = new int[n];
        int i = 0;
        while (n > 0) {
            solution[i++] = arr[--n]; 
        }
        
        string end = string.Join(" ", solution.Select(element => element.ToString()));
        
        Console.WriteLine(end);
    }

}
