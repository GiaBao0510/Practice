using System.Collections;
using System;
using System.Collections.Generic;
public class Solution {


    public static int NaiveSearch(string target, string text){
        
        //Get the length of the text and the target
        int n = text.Length;
        int m = target.Length;

        //Loop through the text
        for(int i = 0; i < n; i++){
            
            // compare each character from the substring in the text
            int j;
            for(j = 0; j < m; j++){

                //If the characters do not match, break
                if(text[i + j] != target[j])
                    break;
            }

            //If the inner loop completed, it means the substring was found
            if(j == m)
                return i;
        }

        return -1;  //If the substring was not found
    }


    static void Main(string[] args) {
        string text = "AABAACAADAAAECCBAA";
        string target = "CCMK";
        Console.WriteLine(NaiveSearch(target, text));
    }
}