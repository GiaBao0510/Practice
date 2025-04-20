using System.Collections;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;


public class Solution {

    public static void Test(int[][] image){
        
        int n = image.Length;   //Vì đây là ma trận vuông
        
    }

   
    public static void Main(string[] args)
    {
       
        int[][] image = new int[4][];
        image[0] = new int[]{1, 2, 3, 4};
        image[1] = new int[]{5, 6, 7 ,8};
        image[2] = new int[]{9, 10 ,11 , 12};
        image[3] = new int[]{13, 14, 15, 16};

        Test(image);

        //Console.WriteLine("Hello, World!");

    }
}