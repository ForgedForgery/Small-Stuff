using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        string[] strings = new string[n];
        for(int i = 0; i < n; i++) {
            strings[i] = Console.ReadLine();
        }
        int q = Convert.ToInt32(Console.ReadLine());
        string[] queries = new string[q];
        for(int i = 0; i < q; i++) {
            queries[i] = Console.ReadLine();
        }
        
        foreach(string query in queries) {
            int amount = 0;
            foreach(string str in strings) {
                if (query == str) {
                    amount++;
                }
            }
            Console.WriteLine(amount);
        }
    }
}
