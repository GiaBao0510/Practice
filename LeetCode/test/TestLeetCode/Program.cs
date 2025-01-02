using System.Collections;
using System;
using System.Collections.Generic;
public class Solution {

    public static int birthdayCakeCandles(List<int> candles)
    {
        int maxval = candles[0],  //Get the first value of the Array to compare with the next elements
            count = 1;             //Count the largest number of values
        
        for(int i = 1; i < candles.Count();i++){
            if(maxval == candles[i]){           //If the maxval is equal to the next element, increment the count
                count++;
            }else if(maxval < candles[i]){    //If the maxval is less than the next element, update the maxval and reset the count
                maxval = candles[i];
                count = 1;
            }
        }
        return count;
    }

    static void Main(string[] args) {
        Console.WriteLine(birthdayCakeCandles( new List<int>(){44 ,53, 31 ,27, 77, 60 ,66, 77, 26 ,36}));
    }
}