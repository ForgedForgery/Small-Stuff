using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string timeConversion(string s) {
        // Complete this function
        string h = s.Substring(0, 2);
        string m = s.Substring(3, 2);
        string sec = s.Substring(6, 2);
        string apm = s.Substring(8, 2);
        
        int hours = Convert.ToInt32(h);
        
        h = apm == "AM" ? (hours == 12 ? "00" : h) : (hours == 12 ? "12" : (hours + 12).ToString());
        
        return h+":"+m+":"+sec;
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);
    }
}
