using System.Collections;
using System;
using System.Collections.Generic;
public class Solution {

    public static int MajorityElement(int[] nums) {
        int count = 0;          //Count number of identical elements
        int candidate = 0;      //Get value with high duplicate count
        
        //Loop through the array
        foreach (int num in nums) 
        {
            if (count == 0)                         //If count is 0, assign the current number as candidate
            {
                candidate = num;
            }
            count += (num == candidate) ? 1 : -1;   //If count is 0, assign the current number as candidate
        }
        
        return candidate;
    }

    static void Main(string[] args) {
        Console.WriteLine(MajorityElement(new int[] {1,1,2,2,1,1,1,2,2,2,2,3,3,3,3}));
    }
}