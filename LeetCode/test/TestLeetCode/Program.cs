using System.Collections;
using System;
using System.Collections.Generic;
public class Solution {

    public static int SearchInsert(int[] nums, int target) {
        
        // If array is empty, return 0
        if (nums == null || nums.Length == 0) return 0;

        int L = 0, R = nums.Length - 1;

        //iterative steps to fin the result. O(log n)
        while(L <= R){
            int mid = L + (R-L)/2;              // calculate mid point
            if(nums[mid]  == target) return mid;       // if mid point is target, return mid
            else if(nums[mid] < target) L = mid+ 1;   // if mid point is less than target, move left pointer to mid + 1
            else R = mid -1;                    // if mid point is greater than target, move right pointer to mid - 1
        }
        return L; // return the position where target can be inserted to maintain sorted array
    }

    static void Main(string[] args) {
        //Console.WriteLine(RomanToInt("MCDLXXVI"));
        Console.WriteLine(SearchInsert(new int[]{1,3,5,6,7,10,11}, 9));
    }
}