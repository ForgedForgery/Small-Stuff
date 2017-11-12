using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    
    static int calculateHourglass(int[][] a, int i, int j) {
        int sum = 0, x = 0;
        sum += a[i][j];
        while (x < 3) {
            sum += a[i-1][j-1+x];
            sum += a[i+1][j-1+x];
            x++;
        }
        return sum;
    }

    static void Main(String[] args) {
        int[][] arr = new int[6][];
        for(int arr_i = 0; arr_i < 6; arr_i++){
           string[] arr_temp = Console.ReadLine().Split(' ');
           arr[arr_i] = Array.ConvertAll(arr_temp,Int32.Parse);
        }
        int maxSum = Int32.MinValue, currSum = 0;
        for (int i = 1; i < arr.GetLength(0) - 1; i++) {
            for (int j = 1; j < arr.GetLength(0) - 1; j++) {
                currSum = calculateHourglass(arr, j, i);
                maxSum = currSum > maxSum ? currSum : maxSum;
            }
        }
        Console.WriteLine(maxSum);
    }
}
