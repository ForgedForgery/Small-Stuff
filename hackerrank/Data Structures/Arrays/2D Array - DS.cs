using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        int[][] arr = new int[6][];
        for(int arr_i = 0; arr_i < 6; arr_i++){
           string[] arr_temp = Console.ReadLine().Split(' ');
           arr[arr_i] = Array.ConvertAll(arr_temp,Int32.Parse);
        }
        
        int result1 = solveWithMethods(arr);
        int result2 = solveWithClass(arr);
        Console.WriteLine(result1);
        Console.WriteLine(result2);
    }
    
    static int solveWithClass(int[][] inArr) {
        Array2D problem = new Array2D(inArr, 6);
        int result = problem.getMaxHourglassSum();
        return result;
    }
    
    solveWithMethods(int[][] inArr) {
        int maxSum = Int32.MinValue, currSum = 0;
        
        for (int i = 1; i < inArrarr.GetLength(0) - 1; i++) {
            for (int j = 1; j < inArr.GetLength(0) - 1; j++) {
                currSum = calculateHourglass(inArr, j, i);
                maxSum = currSum > maxSum ? currSum : maxSum;
            }
        }
    }
    
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
}
class Array2D {
    private int[][] arr;
    private int width, height;
    private int maxHourglassSum;
    
    public Array2D(int[][] inArr) {
        this.arr = inArr;
        this.height = inArr.Length;
        this.width = inArr[0].Length;
        this.maxHourglassSum = Int32.MinValue;
    }
    
    public Array2D(int[][] inArr, int inHeightWidth) : this(inArr) {
        this.height = inHeightWidth;
        this.width = inHeightWidth;
    }
    public Array2D(int[][] inArr, int inWidth, int inHeight) : this(inArr) {
        this.height = inHeight;
        this.width = inWidth;
    }
        
    public int getMaxHourglassSum() {
        if(maxHourglassSum > Int32.MinValue) {
            return this.maxHourglassSum;
        } else {
            this.maxHourglassSum = calculateEveryHourglass();
            return this.maxHourglassSum;
        }
    }
    
    private int calculateEveryHourglass() {
        int maxSum = Int32.MinValue, currSum = 0;
        
        for(int h = 1; h < this.height - 1; h++) {
            for(int w = 1; w < this.width - 1; w++) {
                currSum = calculateHourglassAt(h, w);
                maxSum = currSum > maxSum ? currSum : maxSum;
            }
        }
        
        return maxSum;
    }
    
    private int calculateHourglassAt(int h, int w) {
        int sum = 0, x = 0;
        
        sum += this.arr[h][w];
        while(x < 3) {
            sum += this.arr[h - 1][w - 1 + x];
            sum += this.arr[h + 1][w - 1 + x];
            x++;
        }
        
        return sum;
    }
}
