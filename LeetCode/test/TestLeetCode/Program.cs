using System.Collections;
using System;
using System.Collections.Generic;
public class Solution {

    public static int diagonalDifference(List<List<int>> arr)
    {
        int n = arr.Count;
        int primaryDiagonalSum = 0, 
            secondaryDiagonalSum = 0;
        for(int i = 0; i< n ;i++){
            primaryDiagonalSum += arr[i][i];
            secondaryDiagonalSum += arr[i][n- 1 - i];
        }
        return Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
    }

    static void Main(string[] args) {
        diagonalDifference(new List<List<int>>{
            new List<int>{11, 2, 4},
            new List<int>{4, 5, 6},
            new List<int>{10, 8, -12}
        });
    }
}