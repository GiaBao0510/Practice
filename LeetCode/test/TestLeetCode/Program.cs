using System.Collections;
using System;
using System.Collections.Generic;
public class Solution {



    public static char Test(char[] letters , char target) {
        int targetValue = Convert.ToInt32(target);
        char charTarget = letters[0];
        

        for(int i = 0; i < letters.Length; i++){
            if(Convert.ToInt32(letters[i]) > targetValue){
                charTarget = letters[i];
                break;
            } 
        }

        return charTarget;
    }

    static void Main(string[] args) {
        
        char[] arr = { 'c','f','j'};

       
        Console.WriteLine("\nSearch 1: {0}", String.Join(", ", Test(arr,'c')));
        
    }
}