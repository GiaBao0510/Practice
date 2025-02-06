using System.Collections;
using System;
using System.Collections.Generic;
public class Solution {



    public int[] TwoSum(int[] numbers, int target) {

        // Edge cases check
        if (numbers == null || numbers.Length < 2) 
            return new int[] { -1, -1 };
        
        // Diction
        Dictionary<int, int> seen = new Dictionary<int, int>();

        // iterate over each element in the array
        for(int i = 0; i < numbers.Length; i++ ){

            //Check if the computed value is contained in the dictionary
            int implemented = target - numbers[i];

            // If the computed value is in the dictionary, return the indices of the two numbers.
            if(seen.ContainsKey(implemented)){
                return new int[]{ seen[implemented] + 1 ,i+1};
            }

            // If not, add the current number and its index to the dictionary.
            else{
                seen[numbers[i]] = i;
            } 
        }

        // If no solution is found, return [-1,-1]
        return new int[]{-1,-1};
    }

    static void Main(string[] args) {

         Solution s = new Solution();
         int[] numbers = {1,3,5,9,18,22};
         int target = 23;
         int[] result = s.TwoSum(numbers, target);
         Console.WriteLine("The indices of the two numbers that add up to the target are: " + result[0] + " and " + result[1]);
        
    }
}