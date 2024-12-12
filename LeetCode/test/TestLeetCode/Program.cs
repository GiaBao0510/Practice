using System.Collections;
using System;
using System.Collections.Generic;
public class Solution {

    public static void Merge(int[] nums1, int m, int[] nums2, int n) {
        int last = m+n - 1;             //Lấy vị trí cuối trong mảng đầu để đặt
        int i = m-1, j= n-1;

        //Lặp với điều kiện dừng khi cả 1 trong 2 là 0
        while(i >= 0 && j >=0){
            if(nums1[i] > nums2[j]){
                nums1[last] = nums1[i];
                last--;
                i--;
            }else{
                nums1[last] = nums2[j];
                last--;
                j--;
            }
        }

        //Nếu còn phần tử nào trong nums2, đưa vào mảng đầu
        while(j >=0){
            nums1[last] = nums2[j];
            last--;
            j--;
        }


        Console.WriteLine("{0}", string.Join(",", nums1));
    }

    static void Main(string[] args) {
        Merge(new int[]{1,2,4,7,0,0,0,0,0}, 4, new int[]{1,3,5,8,9}, 5);
    }
}