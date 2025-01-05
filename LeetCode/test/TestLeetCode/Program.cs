using System.Collections;
using System;
using System.Collections.Generic;
public class Solution {

    public static void Rotate(int[] nums, int k){
        if(nums == null ||nums.Length == 0 || k < 0) return;

        //Normalize k if it's larger than array length (k > nums.Length)
        k %= nums.Length;
        if(k == 0) return;

        /*
            Example: nums = [1,2,3,4,5,6,7], k = 3
            Output: [5,6,7,1,2,3,4]
            --------------------------------
            1. Reverse entire array: [7,6,5,4,3,2,1]        (0, nums.Length-1)
            2. Reverse first k elements: [5,6,7,4,3,2,1]    (0, k-1)
            3. Reverse remaining elements: [5,6,7,1,2,3,4]  (k, nums.Length-1)
        */
        //Step 1: Reverse entire array (0, nums.Length-1)
        Reverse(nums, 0, nums.Length-1);

        //Step 2: Reverse first k elements (0, k-1)
        Reverse(nums, 0, k-1);
        
        //Step 3: Reverse remaining elements (k, nums.Length-1)
        Reverse(nums, k, nums.Length-1);
    }

    public static void Reverse(int[] nums, int start, int end){
        while(start < end){
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }

    static void Main(string[] args) {
        //Console.WriteLine(RomanToInt("MCDLXXVI"));
        Rotate(new int[]{1,2,3,4,5,6,7}, 3);
    }
}