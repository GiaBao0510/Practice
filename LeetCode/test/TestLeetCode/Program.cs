using System.Collections;
using System;
using System.Collections.Generic;
public class Solution {

    public static int RemoveElement(int[] nums, int val) {
        int k=0;
        for(int i=0; i< nums.Length; i++){
            if(nums[i] != val){
                nums[k] = nums[i];  //Đưa phần tử khác val vào vị trí k
                k++;
            } 
        }
        return k;
    }

    static void Main(string[] args) {
        Console.WriteLine(RemoveElement(new int[]{0,1,2,2,3,0,4,2}, 2));
    }
}