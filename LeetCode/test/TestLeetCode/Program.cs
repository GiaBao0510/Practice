using System.Collections;
using System;
using System.Collections.Generic;
public class Solution {

    public static bool CanJump(int[] nums) {

        /*
            Example: A[3,2,1,0,4]
            Intinal: flag = A.Length - 1 = 4

            -- repeat from last index to first index --
            Repeat 0:
                - index = 3, A[index] = 0
                - A[index] + index = 3; Flag = 4
            Repeat 1:
            - index = 2, A[index] = 1
            - A[index] + index = 3; Flag = 3
            Repeat 2:
            - index = 1, A[index] = 2
            - A[index] + index = 3; Flag = 2
            Repeat 3:
            - index = 0, A[index] = 3
            - A[index] + index = 3; Flag = 0
            
            So return False. Because it can't reach the end of the array
        */

        int finalIndex = nums.Length - 1;       //Flag, if it reaches the beginning of the array then true

        //Iterate from the end of the array
        for(int index = nums.Length - 2; index >= 0; index --){
            if(nums[index] + index >= finalIndex){  //Check if the current index can reach the final index
                finalIndex = index;                 //If it can, then update the final index
            }
        }

        return finalIndex == 0; //Check has reached the first index

    }

    static void Main(string[] args) {
        //Console.WriteLine(RomanToInt("MCDLXXVI"));
        Console.WriteLine(CanJump(new int[]{5,4,0,2,0,1,0,1,0}));
    }
}